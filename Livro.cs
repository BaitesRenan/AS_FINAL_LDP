using System; // Importe outros namespaces conforme necessário.

namespace BibliotecaNamespace
{
    // Defina um namespace para evitar conflitos com o namespace global.
    public class Livro : ItemBiblioteca
    {
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

        // Adicione outros membros da classe, se necessário.
    }
}