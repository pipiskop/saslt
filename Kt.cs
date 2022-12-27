using Newtonsoft.Json;

namespace MYASAAAA
{
    internal class myasabrat1
    {


        public static void R()
        {
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                                                         ");

            string Tuk = File.ReadAllText("C:\\10 Практическая\\Данные.json");
            List<List<string>> all = JsonConvert.DeserializeObject<List<List<string>>>(Tuk);

            foreach (var itm in all)
            {
                if (itm[0] == mayasko4.login && itm[1] == mayasko4.password)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        mayasko4.Chelen[i] = itm[i];
                    }

                    mayasko4.Gru = 0;

                    myas3.UUUU();
                }
            }
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("  авторизоваться:");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("  такого пользователя нет");
        }
        public static void Login()
        {
            mayasko4.login = "";
            mayasko4.login = Console.ReadLine();
        }

        public static void Pass()
        {
            mayasko4.password = "";
            mayasko4.password = string.Empty;
            ConsoleKey key;

            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;
                {

                }
                if (key == ConsoleKey.Backspace && mayasko4.password.Length > 0)
                {
                    Console.Write("\n \n");
                    mayasko4.password = mayasko4.password[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    mayasko4.password += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);



        }
    }
}
