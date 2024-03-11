using Blog;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.CategoryScreens;

public class DeleteCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Excluir uma categoria");
        Console.WriteLine("---------------------");
        Console.WriteLine("Qual a categoria que deseja excluir?");
        var id = Console.ReadLine();

        Delete(int.Parse(id!));
        Console.ReadKey();
        MenuCategoryScreen.Load();

    }

    static void Delete(int id)
    {
        try
        {
            var repository = new Repository<Category>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("Categoria Deletada com sucesso");

        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível excluir a categoria");
            Console.WriteLine(ex.Message);

        }

    }
}
