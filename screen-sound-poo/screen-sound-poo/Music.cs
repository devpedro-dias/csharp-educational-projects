class Music
{
    public Music(string title, Band artist, int duration, bool available)
    {
        this.Title = title;
        this.Artist = artist;
        this.Duration = duration;
        this.Available = available;
    }

    private string Title { get; }
    private Band Artist { get; }
    private string Description => $"Music {Title} belogns to {Artist}";
    public int Duration { get; }
    private bool Available { get; }


    public void DisplayTechnicalDetails()
    {
        Console.WriteLine($"\nTitle: {Title}, \nArtist: {Artist.Name}, \nDescription: {Description}, \nDuration: {Duration} seconds, \nAvailable: {Available}");
        if (Available)
        {
            Console.WriteLine("\nThis music is available on subscription.");
        }
        else
        {
            Console.WriteLine("\nThis music is not available on subscription.");
        }
    }
}