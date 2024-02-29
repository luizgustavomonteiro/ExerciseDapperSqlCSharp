using Blog.Screens.TagScreens;
using Blog.Screens.CategoryScreens;


namespace Blog.Screens.MenuScreen
{
    public static class MainMenuScreen
    {
        public static void MainLoad()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine("8 - Sair da aplicação");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 8:
                    ExitApplication();
                    break;
                default: MainLoad(); break;
            }
        }

        static void ExitApplication()
        {
            Console.WriteLine("Encerrando a aplicação...");
            Thread.Sleep(2000);

            Environment.Exit(0);
        }
    }
}