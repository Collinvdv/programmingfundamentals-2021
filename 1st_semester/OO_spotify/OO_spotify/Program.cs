using System;

namespace OO_spotify
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Spotify app = new Spotify();

            string command = GetCommand();

            while (command != "stop")
            {
                // execute commands
                switch(command)
                {
                    case "play a song":
                        PlaySong(app);
                        break;
                }

                command = GetCommand();
            }
        }

        public static string GetCommand()
        {
            Console.WriteLine("COMMANDS: [PLAY A SONG, STOP]");
            return Console.ReadLine().ToLower();
        }

        public static void PlaySong(Spotify app)
        {
            // search the artist
            Console.WriteLine("Give me the artist");
            string artistName = Console.ReadLine();
            Artist artist = app.SearchArtist(artistName);

            if (artist == null) // here we check if artist is empty otherwise stop
            {
                Console.WriteLine("Can not find artist, exiting");
            }

            Console.WriteLine("show them the songs");
            app.ShowSongsByArtist(artist);

            int songIndex = Convert.ToInt16(Console.ReadLine());
            app.PlaySongFromArtist(artist, songIndex);

        }
    }
}





// O: COMMANDS: [PLAY A SONG, STOP]
// I: PLAY A SONG
// O: Give me the artist
// I: justin bieber
// O: Pick a song (add the number)
// O: 1. what do you mean
// O: 2. lonely
// I: 1
// O: playing what do you mean - justin bieber











// O: COMMANDS: [PLAY A SONG, SHOW LIKED]
// I: PLAY A SONG
// O: Give me the artist
// I: justin bieber
// O: Pick a song (add the number)
// O: 1. what do you mean
// O: 2. lonely
// I: 1
// O: what do you mean - justin bieber is playing
// O: wanna like the song?
// I: yes
// O: what do you mean - justin bieber is added to the liked playlist


// I: SHOW LIKED
// O: Liked songs:
// O: 1. what do you mean - justin bieber







