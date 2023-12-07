class Program
{
    static void Main()
    {
        // Crie instâncias de Biblioteca e Livro.
        Biblioteca biblioteca = new Biblioteca();
        Livro livro1 = new Livro(1, "O programador pragmático", "Dave Thomas");
        Livro livro2 = new Livro(2, "Clean Code", "Robert C. Martin");
        Livro livro3 = new Livro(3, "Algoritmos: Teoria e Prática", "Thomas H. Cormen");
        Livro livro4 = new Livro(4, "Refactoring", "Martin Fowler");

        // Adicione mais livros à biblioteca.
        biblioteca.AdicionarItem(livro1);
        biblioteca.AdicionarItem(livro2);
        biblioteca.AdicionarItem(livro3);
        biblioteca.AdicionarItem(livro4);

        while (true)
        {
            // Exibe o menu interativo.
            Console.WriteLine("\n### Menu Interativo ###");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Buscar Livro");
            Console.WriteLine("3. Remover Livro");
            Console.WriteLine("4. Sair");

            // Recebe a escolha do usuário.
            Console.Write("Escolha uma opção (1-4): ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    // Opção: Adicionar Livro
                    Console.Write("\nDigite o ID do livro: ");
                    int id;
                    bool inputValido = int.TryParse(Console.ReadLine(), out id);

if (inputValido)
{
    // O valor de 'id' é válido.
    // Restante do código...
}
else
{
    Console.WriteLine("Por favor, insira um número válido para o ID.");
}

                    Console.Write("Digite o título do livro: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Digite o autor do livro: ");
                    string autor = Console.ReadLine();

                    Livro novoLivro = new Livro(id, titulo, autor);
                    biblioteca.AdicionarItem(novoLivro);
                    Console.WriteLine($"Livro '{titulo}' adicionado com sucesso!");
                    break;

                case "2":
                    // Opção: Buscar Livro
                    Console.Write("\nDigite o título do livro a ser buscado: ");
                    string tituloBusca = Console.ReadLine();

                    List<ItemBiblioteca> livrosEncontrados = biblioteca.BuscarItemPorTitulo(tituloBusca);
                    ExibirResultados(livrosEncontrados);
                    break;

                case "3":
    // Opção: Remover Livro
    Console.Write("\nDigite o ID do livro a ser removido: ");
    
    if (int.TryParse(Console.ReadLine(), out int idRemocao))
    {
        ItemBiblioteca livroParaRemover = biblioteca.BuscarItemPorId(idRemocao);
        if (livroParaRemover != null)
        {
            biblioteca.RemoverItem(livroParaRemover);
            Console.WriteLine($"Livro '{livroParaRemover.Titulo}' removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }
    else
    {
        Console.WriteLine("Por favor, insira um número válido para o ID.");
    }
    break;


                case "4":
                    // Opção: Sair
                    Console.WriteLine("\nEncerrando o programa. Até mais!");
                    return;

                default:
                    // Opção inválida
                    Console.WriteLine("\nOpção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    // Métodos auxiliares (ExibirResultado e ExibirResultados) permanecem iguais.
    static void ExibirResultados(List<ItemBiblioteca> resultados)
    {
        if (resultados.Count > 0)
        {
            Console.WriteLine("\nLivros encontrados:");
            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado.Titulo);
            }
        }
        else
        {
            Console.WriteLine("\nNenhum livro encontrado.");
        }
    }
}