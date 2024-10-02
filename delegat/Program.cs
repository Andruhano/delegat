namespace delegat
{
    using System;

    class Program
    {

        delegate void MenuAction();

        static void Main(string[] args)
        {
            MenuAction[] menuActions = new MenuAction[]
            {
            Exit,
            NewGame,
            LoadGame,
            ShowRules,
            AboutAuthor
            };

            while (true)
            {
                Console.Clear();
                ShowMenu();

                Console.Write("Введите номер пункта меню: ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= 4)
                {
                    menuActions[choice]();
                }
                else
                {
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите пункт от 0 до 4.");
                }

                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }

        static void NewGame()
        {
            Console.WriteLine("Вы выбрали: Новая игра");
        }

        static void LoadGame()
        {
            Console.WriteLine("Вы выбрали: Загрузить игру");
        }

        static void ShowRules()
        {
            Console.WriteLine("Вы выбрали: Правила");
        }

        static void AboutAuthor()
        {
            Console.WriteLine("Вы выбрали: Об авторе");
        }

        static void Exit()
        {
            Console.WriteLine("Вы выбрали: Выход. Программа завершена.");
            Environment.Exit(0); 
        }

        static void ShowMenu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - Новая игра");
            Console.WriteLine("2 - Загрузить игру");
            Console.WriteLine("3 - Правила");
            Console.WriteLine("4 - Об авторе");
            Console.WriteLine("0 - Выход");
        }
    }

}
