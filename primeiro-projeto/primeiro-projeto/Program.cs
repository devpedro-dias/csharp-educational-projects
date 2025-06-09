
void DisplayLogo()
{ 
    string welcomeMessage = "\nWelcome to Screen Sound!";
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(welcomeMessage);
}

// List<string> bands = new List<string> { "U2", "The Beatles", "Iron Maiden", "AC/DC" };

Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();
bands.Add("U2", new List<int>());
bands.Add("The Beatles", new List<int> { 10, 9, 6 });
bands.Add("Iron Maiden", new List<int> { 8, 7, 9 });

void DisplayMenuOptions()
{
    Console.WriteLine("\nEnter 1 to register a band");
    Console.WriteLine("Enter 2 to display all bands");
    Console.WriteLine("Enter 3 to rate a band");
    Console.WriteLine("Enter 4 to display the average of a band");
    Console.WriteLine("Enter -1 to exit");

    Console.Write("\n\r\nEnter option:");
    string option = Console.ReadLine()!;
    int optionNumber = int.Parse(option);

    switch (optionNumber)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            DisplayAllBands();
            break;
        case 3:
            RatingBand();
            break;
        case 4:
            DisplayAverageBand();
            break;
        case -1:
            Console.WriteLine("Exiting the application. Goodbye!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Do not exists this option");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    DisplayOptionTitle("Register a band");
    Console.Write("\nEnter the band name: ");

    string bandName = Console.ReadLine()!;
    bands.Add(bandName, new List<int>());

    Console.WriteLine($"The band {bandName} was registered succesfully.");
        Thread.Sleep(2000);

    DisplayLogoAndMenu();
}

void DisplayAllBands()
{
    Console.Clear();
    DisplayOptionTitle("List of bands: ");

    if (bands.Count == 0) {
        Console.WriteLine("\nNo bands registered yet.");
        Thread.Sleep(3000);

        DisplayLogoAndMenu();
    } else {
        //for (int i = 0; i <bands.Count; i++) {
        //    Console.WriteLine($"\nBanda: {bands[i]}");
        //}
        foreach (string band in bands.Keys) {
            Console.WriteLine($"Band: {band}");
        }

        Console.WriteLine("\nPress any key to return to the menu.");
        Console.ReadKey();

        DisplayLogoAndMenu();
    }
}

void RatingBand()
{
    Console.Clear();
    Console.WriteLine("Which band do you want to rate?");
    Console.WriteLine("\nRegistered bands list:");
    foreach (string band in bands.Keys) {
        Console.WriteLine($"- {band}");
    }

    Console.WriteLine("\nType the band name: ");
    string bandSelected = Console.ReadLine()!;
    if (bands.ContainsKey(bandSelected))
    {
        Console.WriteLine($"\nWhat rating does {bandSelected} deserve:");
        int rating = int.Parse(Console.ReadLine()!);
        bands[bandSelected].Add(rating);
        Console.WriteLine($"The rating: {rating} was registered succesfully.");
        Thread.Sleep(2000);

        DisplayLogoAndMenu();
    } else
    {
        Console.WriteLine($"\nThe Band {bandSelected} was not found.");
        Console.WriteLine("\nPress any key to return to the menu.");
        Console.ReadKey();

        DisplayLogoAndMenu();
    }

}

void DisplayAverageBand()
{
    Console.WriteLine("Bands registered list: ");
    foreach (string band in bands.Keys)
    {
        Console.WriteLine($"- {band}");
    }

    Console.Write("\nEnter band name you want shown average: ");
    string bandName = Console.ReadLine()!;

    if (bands.ContainsKey(bandName) && bands[bandName].Count > 0)
    {
        List<int> ratings = bands[bandName];
        double average = ratings.Average();
        Console.WriteLine($"\nThe average rating for {bandName} is: {average:F2}");
        Console.WriteLine("\nPress any key to return to the menu.");
        Console.ReadKey();

        DisplayLogoAndMenu();
    }
    else
    {
        Console.WriteLine($"\nNo ratings found for {bandName}.");
        Console.WriteLine("\nPress any key to return to the menu.");
        Console.ReadKey();

        DisplayLogoAndMenu();
    }
}

void DisplayOptionTitle(string title)
{
    int titleLength = title.Length;
    string asterisks = string.Empty.PadLeft(titleLength, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}

void DisplayLogoAndMenu()
{
    Console.Clear();
    DisplayLogo();
    DisplayMenuOptions();
}

DisplayLogoAndMenu();