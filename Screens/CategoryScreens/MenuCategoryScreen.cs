using Blog.Screens.MenuScreen;

namespace Blog.Screens.CategoryScreens
{
    public class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Categorias");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Listar categorias");
            Console.WriteLine("2 - Criar categoria");
            Console.WriteLine("3 - Atualizar categoria");
            Console.WriteLine("4 - Deletar categoria");
            Console.WriteLine("5 - Retornar ao menu principal");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);
            switch (option)
            {
                case 1:
                    ListCategoryScreen.Load();
                    break;

                case 2:
                    CreateCategoryScreen.Load();
                    break;

                case 3:
                    UpdateCategoryScreen.Load();
                    break;

                case 4:
                    ListCategoryScreen.Load();
                    break;

                case 5:
                    MainMenuScreen.MainLoad();
                    break;

                default:
                    Load();
                    break;
            }

        }
    }
}