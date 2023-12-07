public class Biblioteca
{
    private List<ItemBiblioteca> itens;

    public Biblioteca()
    {
        itens = new List<ItemBiblioteca>();
    }

    // Método de adição que aceita qualquer item derivado de ItemBiblioteca.
    public void AdicionarItem(ItemBiblioteca item)
    {
        itens.Add(item);
    }

    // Método de remoção que aceita qualquer item derivado de ItemBiblioteca.
    public void RemoverItem(ItemBiblioteca item)
    {
        itens.Remove(item);
    }

    // Métodos com sobrecarga: BuscarItemPorTitulo e BuscarItemPorId.
    public List<ItemBiblioteca> BuscarItemPorTitulo(string titulo)
    {
        return itens.FindAll(item => item.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase));
    }

    public ItemBiblioteca BuscarItemPorId(int id)
    {
        return itens.Find(item => item.Id == id);
    }
}