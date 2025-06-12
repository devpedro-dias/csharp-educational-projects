using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Requests;
using ScreenSound.API.Responses;
using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.API.Endpoints;

public static class ArtistasExtensions
{
    private static ICollection<ArtistaResponse> EntityListToResponseList(IEnumerable<Artista> listaDeArtistas)
    {
        return listaDeArtistas.Select(a => EntityToResponse(a)).ToList();
    }

    private static ArtistaResponse EntityToResponse(Artista artista)
    {
        return new ArtistaResponse(artista.Id, artista.Nome, artista.Bio, artista.FotoPerfil);
    }

    public static void AddEndpointsArtistas(this WebApplication app)
    {
        app.MapGet("/artistas", ([FromServices] DAL<Artista> dal) =>
        {
            return Results.Ok(dal.Listar());
        });

        app.MapGet("/artistas/{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
        {
            var artista = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome));
            if (artista is null)
            {
                return Results.NotFound();
            }
            return Results.Ok(artista);
        });

        app.MapPost("/artistas", ([FromServices] DAL<Artista> dal, [FromBody] ArtistaRequest artistaReq) =>
        {
            var artista = new Artista(artistaReq.nome, artistaReq.bio);
            dal.Adicionar(artista);
            return Results.Ok(artista);
        });

        app.MapDelete("artistas/{id}", ([FromServices] DAL<Artista> dal, int id) =>
        {
            var artista = dal.RecuperarPor(a => a.Id == id);

            if (artista is null)
            {
                return Results.NotFound();
            }
            dal.Deletar(artista);
            return Results.NoContent();
        });

        app.MapPut("/artistas", ([FromServices] DAL<Artista> dal, [FromBody] ArtistaRequestEdit artistaReq) =>
        {
            var artistaParaAtualizar = dal.RecuperarPor(a => a.Id == artistaReq.Id);
            if (artistaParaAtualizar is null)
            {
                return Results.NotFound();
            }
            artistaParaAtualizar.Nome = artistaReq.nome;
            artistaParaAtualizar.Bio = artistaReq.bio;

            dal.Atualizar(artistaParaAtualizar);
            return Results.Ok(artistaParaAtualizar);

        });

        app.MapGet("/Artistas/{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
        {
            var artista = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
            if (artista is null)
            {
                return Results.NotFound();
            }
            return Results.Ok(artista);

        });
    }
}
