using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Categorias");
            Console.WriteLine("-------------------");
            ListCategories();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void ListCategories()
        {
            var repository = new Repository<Category>(Database.Connection);
            var category = repository.Get();
            foreach (var item in category)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");
            }
        }

    }
}
