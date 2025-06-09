class Band
{
    public Band(string name)
    {
        this.Name = name;
    }

    public string Name { get; }
    private List<Album> albums = new List<Album>();


    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void DisplayBandDetails()
    {
        Console.WriteLine($"Albums de {Name}: ");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.TotalDuration} seconds)");
        }
    }
}