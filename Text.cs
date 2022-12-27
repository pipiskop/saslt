namespace MYASAAAA
{
    internal class Myasnoe2
    {
        public static void Nach()
        {
            Console.Clear();

            Console.SetCursorPosition(55, 0);
            Console.WriteLine("МВГАЗИН");
            Console.WriteLine("╤ ╥ ╦ ╧ ╨ ╩ ╪ ╫ ╬╤ ╥ ╦ ╧ ╨ ╩ ╪ ╫ ╬╤ ╥ ╦ ╧ ╨ ╩ ╪ ╫ ╬╤ ╥ ╦ ╧ ╨ ╩ ╪ ╫ ╬╤ ╥ ╦ ╧ ╨ ╩ ╪ ╫ ╬╤ ╥ ╦ ╧ ╨ ╩ ╪ ╫ ╬╤ ╥ ╦ ╧ ╨ ╩ ╪ ╫ ╬");
            Console.Write("  " + "ЛОГИН: ");
            Console.SetCursorPosition(0, 3);
            Console.Write("  " + "ПАРОЛЬ: ");
            Console.SetCursorPosition(0, 4);
            Console.Write("  " + "АВТОРИЗОВАТЬСЯ");
        }

        public static void ForAdmin()
        {
            Console.Clear();

            Console.SetCursorPosition(15, 2);
            Console.Write("ID");
            Console.SetCursorPosition(30, 2);
            Console.Write("ЛОГИН");
            Console.SetCursorPosition(45, 2);
            Console.Write("ПАРОЛЬ");
            Console.SetCursorPosition(60, 2);
            Console.Write("РOЛЬ");

            for (int i = 2; i < 12; i++)
            {
                Console.SetCursorPosition(75, i);
                Console.Write("╪");
            }

            Console.SetCursorPosition(80, 2);
            Console.Write("F1 - Добавить запись");
            Console.SetCursorPosition(80, 3);
            Console.Write("F2 - Найти запись");
        }

        public static void Dob()
        {
            Console.SetCursorPosition(30, 0);
            Console.Write("Салют, ты вошел как (" + mayasko4.Chelen[0] + ")");
            Console.SetCursorPosition(80, 0);
            Console.WriteLine("Роль: " + mayasko4.Chelen[3]);

            Console.WriteLine("╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪╪");

        }

        public static void F1AT()
        {
            Console.Clear();
            for (int i = 2; i < 12; i++)
            {
                Console.SetCursorPosition(75, i);
                Console.Write("╪");
            }

            Console.SetCursorPosition(80, 2);
            Console.Write("0 - Администратор                    ");
            Console.SetCursorPosition(80, 4);
            Console.Write("                                     ");
            Console.SetCursorPosition(80, 5);
            Console.Write("S - Сохранение                       ");
            Console.SetCursorPosition(80, 6);
            Console.Write("ESC - В меню                         ");

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("  ID:                           ");
            Console.WriteLine("  ЛOГИН:                        ");
            Console.WriteLine("  ПАРОЛЬ:                       ");
            Console.WriteLine("  РОЛЬ:                         ");
        }

        public static void IA()
        {
            for (int i = 2; i < 12; i++)
            {
                Console.SetCursorPosition(75, i);
                Console.Write("╪");
            }

            Console.SetCursorPosition(80, 2);
            Console.Write("F10 - Изменить пункт                               ");
            Console.SetCursorPosition(80, 3);
            Console.Write("DEL - Удалить запись                               ");
            Console.SetCursorPosition(80, 4);
            Console.Write("ESC - Вернуться в меню                             ");

            Myasnoe2.Dob();
        }
    }
}
