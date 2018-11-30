using System;
using System.Drawing;
using System.IO;

namespace osu_bg
{
    public enum BackgroundState { Normal, Disabled, Blurred, Coloured, Missing }

    public class Background
    {
        public string Name { get { return System.IO.Path.GetFileName(Path); } }
        public string Path { get; private set; }
        public BackgroundState State { get; private set; }

        public Background(string path)
        {
            if (File.Exists(path))
            {
                Path = path;
                State = BackgroundState.Normal;
                if (File.Exists(path + "blr"))
                {
                    State = BackgroundState.Blurred;
                }
                else if (File.Exists(path + "clr"))
                {
                    State = BackgroundState.Coloured;
                }
            }
            else if(File.Exists(path + "dbl"))
            {
                Path = path;
                State = BackgroundState.Disabled;
            }
            else
            {
                State = BackgroundState.Missing;
            }
        }


        
        public void Blur(int BlurRadius)
        {
            if (State != BackgroundState.Blurred)
            {
                Restore();
                if (BlurRadius > 0)
                {
                    try
                    {
                        Image image;
                        image = ImageProcessing.ImportImage(Path);
                        Image blurredImage = ImageProcessing.Blur((Bitmap)image, BlurRadius);
                        File.Move(Path, Path + "blr");
                        blurredImage.Save(Path);
                        State = BackgroundState.Blurred;
                    }
                    catch (IOException ex)
                    {
                        if (File.Exists(Path + "blr") && !File.Exists(Path)) File.Move(Path + "blr", Path);
                        throw new IOException($"Failed to blur background: {Name}. Restored to normal.", ex);
                    }
                }
            }
        }



        public void Disable()
        {
            if (State != BackgroundState.Disabled)
            {
                Restore();
                try { File.Move(Path, Path + "dbl"); }
                catch (IOException ex) { throw new IOException($"Failed to disable background: {Name}. Restored to normal.", ex); }
                State = BackgroundState.Disabled;
            }
        }



        public void Colour(Color colour)
        {
            if (State != BackgroundState.Coloured)
            {
                Restore();
                try
                {
                    Image image;
                    image = ImageProcessing.ImportImage(Path);
                    Image blackImage = new Bitmap(image);
                    Graphics graphics = Graphics.FromImage(blackImage);
                    graphics.Clear(colour);

                    File.Move(Path, Path + "clr");
                    blackImage.Save(Path);
                    State = BackgroundState.Coloured;
                }
                catch (IOException ex)
                {
                    if (File.Exists(Path + "clr") && !File.Exists(Path)) File.Move(Path + "clr", Path);
                    throw new IOException($"Failed to colour background: {Name}. Restored to normal.", ex);
                }
            }
        }



        public void Restore()
        {
            if (!(State == BackgroundState.Normal || State == BackgroundState.Missing))
            {
                if (State == BackgroundState.Disabled)
                {
                    try { File.Move(Path + "dbl", Path); }
                    catch (IOException ex) { throw new IOException($"Failed to restore background: {Name}", ex); }
                }
                else
                {
                    string ext = "";
                    switch (State)
                    {
                        case BackgroundState.Coloured:
                            ext = "clr";
                            break;
                        case BackgroundState.Blurred:
                            ext = "blr";
                            break;
                    }
                    try
                    {
                        File.Move(Path, Path + "temp");
                        File.Move(Path + ext, Path);
                    }
                    catch (IOException ex)
                    {
                        if (File.Exists(Path + "temp")) File.Move(Path + "temp", Path);
                        throw new IOException(ex.Message, ex);
                    }
                    finally { if (File.Exists(Path + "temp")) File.Delete(Path + "temp"); }
                }
                State = BackgroundState.Normal;
            }
        }



        public Image GetImage()
        {
            switch (State)
            {
                case (BackgroundState.Blurred):
                    return ImageProcessing.ImportImage(Path + "blr");
                case (BackgroundState.Coloured):
                    return ImageProcessing.ImportImage(Path + "clr");
                case (BackgroundState.Disabled):
                    return ImageProcessing.ImportImage(Path + "dbl");
                case (BackgroundState.Normal):
                    return ImageProcessing.ImportImage(Path);
                default:
                    return null;
            }
        }



        public Image GetModImage()
        {
            if (State == BackgroundState.Blurred || State == BackgroundState.Coloured)
            {
                return ImageProcessing.ImportImage(Path);
            }
            else if (State == BackgroundState.Disabled)
            {
                return Properties.Resources.defaultbg;
            }
            else return null;
        }



        public override string ToString() => Name;
    }



    class BackgroundTest
    {
        static void Main()
        {
            string test = "C:\\Users\\rifat\\Desktop\\721240 GTA feat Sam Bruno - Red Lips (Mendus Remix)\\wallhaven-313313.jpg";
            Background bg = new Background(test);
            Console.WriteLine("Name: " + bg.Name);
            Console.WriteLine("Path: " + bg.Path);
            // bg.Blur();
            // bg.Remove();
            bg.Restore();
        }
    }
}
