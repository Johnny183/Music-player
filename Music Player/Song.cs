using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Music_Player
{
    [Serializable]
    public class Song
    {
        // Holds a static list of all songs
        public static List<Song> songList = new List<Song>();
        public static string filePath = "LocalSave";

        public int id;
        public string name;
        public bool isExplicit;
        public List<string> artists;
        public string album;
        public string imageFileName;
        public ImageType imageType;
        public string audioFileName;
        public AudioType audioType;
        public enum AudioType { mp3, wav }
        public enum ImageType { jpg, png }

        public Song(string _name, List<string> _artists, bool _isExplicit, string _imageFileName, ImageType _imageType, string _audioFileName, AudioType _audioType)
        {
            name = _name;
            isExplicit = _isExplicit;
            artists = _artists;
            audioType = _audioType;
            audioFileName = _audioFileName;
            imageFileName = _imageFileName;
            imageType = _imageType;
            songList.Add(this);
        }

        public static void LocalSaveSongs()
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fileStream, songList);
            fileStream.Close();
        }

        public static void LocalLoadSongs()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    BinaryFormatter b = new BinaryFormatter();
                    songList = (List<Song>)b.Deserialize(fileStream);
                    fileStream.Close();
                } catch { }
            }
        }
    }
}
