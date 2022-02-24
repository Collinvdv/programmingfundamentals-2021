using System;
namespace OO_spotify
{
    public class Song
    {
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public int Duration { get; set; }

        public Song(string title, Artist artist, int duration)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = duration;
        }

        // methods
        public string GetTrack()
        {
            return this.Artist.Name + " - " + this.Title;
        }
    }
}

// class Song
// --------
// title
// Artist artist
// duration in seconds
