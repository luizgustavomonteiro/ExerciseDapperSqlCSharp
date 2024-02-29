using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;

namespace Blog.Screens.CategoryScreens
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma Categoria");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new Category
            {
                Id = int.Parse(id!),
                Name = name!,
                Slug = slug!
            });
            Console.ReadKey();
            MenuTagScreen.Load();

        }
        static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                Console.WriteLine("Categoria atualizada com sucesso!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a categoria");
                Console.WriteLine(ex.Message);

            }
        }
    }
}