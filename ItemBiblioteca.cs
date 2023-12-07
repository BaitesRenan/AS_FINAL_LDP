public abstract class ItemBiblioteca
{
    // Propriedades com convenções de nomenclatura PascalCase.
    public int Id { get; }
    public string Titulo { get; }
    protected string DescricaoInterna { get; set; }

    // Construtor que inicializa Id, Titulo e define um valor padrão para DescricaoInterna.
    protected ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "Descrição padrão";
    }

    // Método abstrato a ser implementado nas classes derivadas.
    public abstract void ExibirDescricaoInterna();
}

// 2. Classe Livro (Classe Derivada de ItemBiblioteca):
public class Livro : ItemBiblioteca
{
    // Propriedade adicional: Autor
    public string Autor { get; }

    // Construtor que recebe id, título e autor, e inicializa a DescricaoInterna.
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor;
    }

    // Implementação do método abstrato ExibirDescricaoInterna.
    public override void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Descrição interna do livro '{Titulo}': {DescricaoInterna}");
    }
}