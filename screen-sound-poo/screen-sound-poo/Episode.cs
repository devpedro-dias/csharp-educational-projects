class Episode
{
    public Episode(int sequence, string title, int duration)
    {
        Sequence = sequence;
        Title = title;
        Duration = duration;
    }

    public List<string> guests = new();
    public int Sequence { get; }
    public string Title { get; }
    public int Duration { get; }
    public string Resume => $"{Sequence}. {Title} ({Duration} minutes) - {string.Join(", ", guests)}";

    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }
}