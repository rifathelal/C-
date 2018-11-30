using System.Drawing;
using System.IO;

namespace osu_bg
{
    class ImageProcessing
    {
        public static Image ImportImage(string path)
        {
            var bytes = File.ReadAllBytes(path);
            var ms = new MemoryStream(bytes);
            var img = Image.FromStream(ms);
            ms.Close();
            return img;
        }

        public static Image Blur(Bitmap input, int gaussian)
        {
            if (gaussian > 0)
            {
                GaussianBlur filter = new GaussianBlur(input);
                Bitmap blurredImage = filter.Process(gaussian);
                return blurredImage;
            }
            else return input;
        }
    }
}
