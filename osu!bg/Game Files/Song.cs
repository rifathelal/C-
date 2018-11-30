using System;
using System.IO;
using System.Collections.Generic;

namespace osu_bg
{
    public class Song
    {
        public string FolderPath { get; }
        public string FolderName { get; }
        public string Name { get; }
        public List<Background> Backgrounds { get; private set; }
        private bool Parsed = false;



        public Song(string folderPath)
        {
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            FolderPath = directory.FullName;
            FolderName = directory.Name;
            Name = FolderName.Substring(FolderName.IndexOf(' ') + 1);
            Backgrounds = new List<Background>();
        }



        public Song(string folderPath, string[] bgNamesList) : this(folderPath)
        {
            if (bgNamesList.Length > 0)
            {
                foreach (string bgName in bgNamesList)
                {
                    Background background = new Background(Path.Combine(folderPath, bgName));
                    Backgrounds.Add(background);
                }
                Parsed = true;
            }
            else Parsed = false;
        }



        private string[] GetOsuFiles()
        {
            string[] osuFiles = Directory.GetFiles(FolderPath, "*.osu");
            return osuFiles;
        }



        private List<string> ParseOsuFiles(string[] list)
        {
            List<string> bgList = new List<string>();
            foreach(var item in list)
            {
                StreamReader file = new StreamReader(item);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    line = line.ToLower();
                    if (line.StartsWith("0") && (
                        line.Contains(".jpg") ||
                        line.Contains(".jpeg") ||
                        line.Contains(".png")))
                    {
                        line = line.Substring(line.IndexOf('\"') + 1);
                        line = line.Split('\"')[0];
                        if (!bgList.Contains(line))
                        {
                            bgList.Add(line.TrimEnd('\n'));
                        }
                        break;
                    }
                }
                file.Close();
            }
            return bgList;
        }



        public void ParseSong()
        {
            try
            {
                if (Parsed == false)
                {
                    foreach (var bg in ParseOsuFiles(GetOsuFiles()))
                    {
                        Background newBg = new Background(Path.Combine(FolderPath, bg));
                        if (newBg.State != BackgroundState.Missing)
                        {
                            Backgrounds.Add(newBg);
                        }
                    }
                    Parsed = true;
                }
            }
            catch (IOException ex)
            {
                Parsed = false;
                Backgrounds.Clear();
                throw new IOException($"Failed to parse files for song: {Name}", ex);
            }
        }



        public override string ToString() => Name;
    }


    class SongTest
    {
        static void Main()
        {
            string test = "";
            Song song = new Song(test);
            Console.WriteLine(song.Name);
            song.ParseSong();
            Console.WriteLine(song);
        }
    }
}
