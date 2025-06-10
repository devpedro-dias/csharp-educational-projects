using screen_sound_api.Modelos;

namespace screen_sound_api.Filtros;

internal class LinqOrder
{
    public static void ExibirArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine("Lista de artistas ordenados: ");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
