
namespace bytebank_GeradorChavePix;

/// <summary>
/// Classe que gera chaves PIX usando o formato Guid.
/// </summary>
/// <returns>Retorna uma chave PIX no formato String.</returns>
public static class GeradorPix
{
    /// <summary>
    /// Método que retorna uma chave aleatória de PIX.
    /// </summary>
    /// <returns>Retorna uma chave PIX no formato String.</returns>
    public static string GetChavePix()
    {
        return Guid.NewGuid().ToString();
    }

    /// <summary>
    /// Método que retorna uma lista aleatória de chaves PIX.
    /// </summary>
    /// <param name="numeroChaves">Quantidade de chaves</param>
    /// <returns>Lista de strings de chaves PIX.</returns>
    public static List<string> GetChavesPix(int numeroChaves)
    {
        if (numeroChaves <= 0)
        {
            return null;
        }
        else
        {
            var chaves = new List<string>();
            for (int i = 0; i < numeroChaves; i++)
            {
                chaves.Add(Guid.NewGuid().ToString());
            }

            return chaves;
        }
    }
}