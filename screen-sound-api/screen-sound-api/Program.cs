using screen_sound_api.Filtros;
using screen_sound_api.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        // Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        // Console.WriteLine(musicas.Count());
        // musicas[0].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Kodak Black");
        //var musicasFavoritas = new MusicasFavoritas("Pedro");
        //musicasFavoritas.AdicionarMusicasFavoritas(musicas[2]);
        //musicasFavoritas.AdicionarMusicasFavoritas(musicas[512]);
        //musicasFavoritas.AdicionarMusicasFavoritas(musicas[123]);
        //musicasFavoritas.AdicionarMusicasFavoritas(musicas[987]);
        //musicasFavoritas.AdicionarMusicasFavoritas(musicas[1083]);

        //musicasFavoritas.ExibirMusicasFavoritas();
        //musicasFavoritas.GerarArquivoJson();
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C");
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}
