using System.Security.Cryptography.X509Certificates;

namespace DesignPattern_Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string song1 = "StarBoy";
           string song2 = "Bibabuzelmann";
           string song3 = "Nirvana";
           string song4 = "Foofigthers";
           string song5 = "ACDC";

            List<string> playlist = new List<string>();
            playlist.Add(song1);
            playlist.Add(song2);
            playlist.Add(song3);

            playlist.Add(song4);
            playlist.Add(song5);

            PlaylistIterator playlistIterator = new PlaylistIterator(playlist);
            while (playlistIterator.hasNext())
            {
                Console.WriteLine(playlistIterator.next());
            }
        }
    }
}

