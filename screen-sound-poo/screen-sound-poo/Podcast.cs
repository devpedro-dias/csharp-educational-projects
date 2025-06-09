class Podcast
{
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get; }
    public string Host { get; }
    public List<Episode> episodes = new();
    public int TotalEpisodes => episodes.Count;

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void DisplayPodcastDetails()
    {
        Console.WriteLine($"Podcast {Name} hosted by {Host}\n");
        foreach (Episode episode in episodes.OrderBy(e => e.Sequence))
        {
            Console.WriteLine(episode.Resume);
        }

        Console.WriteLine($"\n\nThis podcast have {TotalEpisodes} episode(s)");
    }
}