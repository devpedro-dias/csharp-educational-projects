class Album
{
    public Album(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    private List<Music> musics = new();
    public int TotalDuration => musics.Sum(m => m.Duration);


    public void AddMusicToAlbum(Music music)
    {
        musics.Add(music);
    }

    public void DisplayAlbumDetails()
    {
        Console.WriteLine($"Album Name: {Name}, Total Duration: {TotalDuration} seconds");
        Console.WriteLine("\nMusics in this album:");
        foreach (var music in musics)
        {
            music.DisplayTechnicalDetails();
        }
    }
}