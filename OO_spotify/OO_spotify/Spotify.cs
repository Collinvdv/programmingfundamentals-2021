using System;
using System.Collections.Generic;

namespace OO_spotify
{
    public class Spotify
    {
        public List<Song> Songs { get; set; }
        public List<Artist> Artists { get; set; }

        // constructor
        public Spotify()
        {
            
            // create artists
            Artist artist1 = new Artist("Justin The Bieber");
            Artist artist2 = new Artist("Billy The Irish");

            this.Artists = new List<Artist>() { artist1, artist2};
      
            // add songs
            Song song1 = new Song("what do you mean", artist1, 900);
            Song song2 = new Song("lonely", artist1, 100);
            Song song3 = new Song("ocean eyes", artist2, 900);

            this.Songs = new List<Song>() { song1, song2, song3 };
        }

        // methods
        public Artist SearchArtist(string name)
        {
            foreach(Artist artist in this.Artists)
            {
                if (artist.Name.ToLower() == name.ToLower())
                {
                    return artist;
                }
            }

            return null;
        }

        public List<Song> GetSongsByArtist(Artist artist)
        {
            List<Song> songs = new List<Song>();

            // populating songs
            foreach(Song song in this.Songs)
            {
                if (song.Artist == artist)
                {
                    songs.Add(song);
                }
            }

            return songs;
        }

        public void ShowSongsByArtist(Artist artist)
        {
            List<Song> songs = GetSongsByArtist(artist);

            // show the songs
            int index = 0;

            foreach (Song song in songs)
            {
                Console.WriteLine(index + ". " + song.GetTrack());
                index++;
            }
        }

        public void PlaySongFromArtist(Artist artist, int index)
        {
            List<Song> songs = GetSongsByArtist(artist);

            Console.WriteLine(index + ". " + songs[index].GetTrack());
        }
    }
}
