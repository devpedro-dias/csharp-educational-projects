//Band band = new Band("Band1");
//Album album = new Album("Album1");

//band.AddAlbum(album);

//Console.WriteLine("-------------------------------");
//Console.WriteLine("Band details: \n");
//band.DisplayBandDetails();

//Music music1 = new Music("Song1", band, 200, true);
//Music music2 = new Music("Song2", band, 180, false);

//album.AddMusicToAlbum(music1);
//album.AddMusicToAlbum(music2);

//Console.WriteLine("Album details: \n");
//Console.WriteLine("-------------------------------");
//album.DisplayAlbumDetails();

Episode ep1 = new Episode(2, "Introduction to C#", 30);
ep1.AddGuest("Alice");
ep1.AddGuest("Bob");

Episode ep2 = new Episode(1, "Introduction to Java", 90);
ep2.AddGuest("Pedro");
ep2.AddGuest("Lucas");

Episode ep3 = new Episode(3, "Introduction to Java", 50);
ep3.AddGuest("João");
ep3.AddGuest("Maria");

Podcast podcast = new Podcast("Programming languages", "Pedro");

podcast.AddEpisode(ep1);
podcast.AddEpisode(ep2);
podcast.AddEpisode(ep3);

podcast.DisplayPodcastDetails();