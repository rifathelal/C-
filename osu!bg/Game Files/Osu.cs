using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace osu_bg
{
    public class Osu
    {
        public string BaseDirectory { get; private set; }
        public string SongDirectory { get; private set; }
        public int SongCount { get; private set; }
        public List<Song> Songs { get; private set; }

        public Osu(string execdir)
        {
            FileInfo execFile = new FileInfo(execdir);
            BaseDirectory = execFile.DirectoryName;
            SongDirectory = Path.Combine(BaseDirectory, "Songs");
            Songs = new List<Song>(1000);
            SongCount = 0;
        }



        public void GenerateSongList()
        {
            foreach (string song in Directory.GetDirectories(SongDirectory))
            {
                Songs.Add(new Song(song));
                SongCount++;
            }
        }



        public void UpdateSongList()
        {
            List<string> newSongs = Directory.GetDirectories(SongDirectory).ToList();
            List<string> oldSongs = new List<string>(Songs.Count);
            foreach (Song song in Songs)
            {
                oldSongs.Add(song.FolderPath);
            }
            List<string> addList = newSongs.Except(oldSongs).ToList();
            foreach (string path in addList)
            {
                Songs.Add(new Song(path));
                SongCount++;
            }
        }



        public void AppendSong(Song song)
        {
            Songs.Add(song);
            SongCount++;
        }



        public override string ToString()
        {
            string returnString =
                $"Current Game Directory: {BaseDirectory}\n" +
                $"Current Song Directory: {SongDirectory}\n" +
                $"Number of songs: {SongCount}\n" +
                $"Songs found:\n";
            foreach (Song song in Songs)
            {
                returnString += song.Name + "\n";
            }
            return returnString.TrimEnd('\n');
        }
    }



    class OsuTest
    {
        static void Main() {}
    }
}
