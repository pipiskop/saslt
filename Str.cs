namespace MYASAAAA
{
    internal class myasnayastr
    {

        int max;
        int min;
        public myasnayastr(int Min, int Max)
        {
            max = Max;
            min = Min;
        }
        public ConsoleKey Myas()
        {
            mayasko4.J = 0;
            mayasko4.Gru = 0;
            do
            {
                Console.SetCursorPosition(0, mayasko4.posii);
                Console.Write("->");

                mayasko4.key = Console.ReadKey(false);

                if (mayasko4.key.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, mayasko4.posii);
                    Console.WriteLine("  ");
                    mayasko4.posii--;
                }
                else if (mayasko4.key.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, mayasko4.posii);
                    Console.WriteLine("  ");
                    mayasko4.posii++;
                }

                if (mayasko4.posii < min)
                {
                    mayasko4.posii++;
                }
                else if (mayasko4.posii > max)
                {
                    mayasko4.posii--;
                }

                if (mayasko4.key.Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(0, mayasko4.posii);
                    Console.Write("  ");
                    return mayasko4.key.Key;
                }
                else if (mayasko4.key.Key == ConsoleKey.F1)
                {
                    mayasko4.O = 1;
                    return mayasko4.key.Key;
                }
                else if (mayasko4.key.Key == ConsoleKey.F2)
                {
                    mayasko4.O = 2;
                    return mayasko4.key.Key;
                }
                else if (mayasko4.key.Key == ConsoleKey.F10)
                {
                    mayasko4.O = 10;
                    return mayasko4.key.Key;
                }
                else if (mayasko4.key.Key == ConsoleKey.S)
                {
                    return mayasko4.key.Key;
                }
                else if (mayasko4.key.Key == ConsoleKey.Delete)
                {
                    mayasko4.D = 1;
                    return mayasko4.key.Key;
                }
                Console.SetCursorPosition(0, mayasko4.posii);
                Console.Write("->");
            } while (mayasko4.key.Key != ConsoleKey.Escape);

            mayasko4.J = 1;
            Console.SetCursorPosition(0, mayasko4.posii);
            Console.Write("  ");
            return mayasko4.key.Key;
        }
    }
}
