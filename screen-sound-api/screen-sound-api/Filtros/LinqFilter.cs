using screen_sound_api.Modelos;

namespace screen_sound_api.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");

        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasdoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        foreach (var musica in musicasdoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    internal static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasNaTonalidadeEscolhida= musicas
            .Where(musica => musica.Tonalidade.Equals(tonalidade))
            .Select(musica => musica.Nome)
            .ToList();
        Console.WriteLine($"Músicas em {tonalidade}: ");
        foreach (var musica in musicasNaTonalidadeEscolhida)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
