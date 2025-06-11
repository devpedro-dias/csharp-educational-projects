namespace ScreenSound.Banco;

internal class DAL<T> where T : class
{

    protected readonly ScreenSoundContext context;

    public DAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<T> Listar()
    {
        return context.Set<T>().ToList();
    }

    public void Adicionar(T objeto)
    {
        context.Set<T>().Add(objeto);
        context.SaveChanges();
    }

    public void Atualizar(T objeto)
    {
        context.Update(objeto);
        context.SaveChanges();
        
    }

    public void Deletar(T objeto)
    {
        var objetoExistente = context.Artistas.Find(objeto);
        if (objetoExistente != null)
        {
            context.Artistas.Remove(objetoExistente);
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("Não encontrado.");
        }
    }

    public T? RecuperarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().FirstOrDefault(condicao);
    }

    public IEnumerable<T> ListarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().Where(condicao);
    }
}
