namespace MYASAAAA
{
    internal class admmmm : myasiko5
    {
        public void Admin()
        {

            while (mayasko4.Gru != 1)
            {
                mayasko4.J = 1;
                mayasko4.O = 0;
                mayasko4.D = 0;


                Read();

                int i = 2;
                int str = 3;
                if (mayasko4.posk == 0)
                {
                    Myasnoe2.ForAdmin();
                    Myasnoe2.Dob();

                    foreach (var itmm in mayasko4.AllVse)
                    {
                        Console.SetCursorPosition(15, str);
                        Console.Write(itmm[2]);
                        Console.SetCursorPosition(30, str);
                        Console.Write(itmm[0]);
                        Console.SetCursorPosition(45, str);
                        Console.Write(itmm[1]);
                        Console.SetCursorPosition(60, str);
                        Console.Write(itmm[3]);
                        str += 1;
                        i += 1;
                    }
                }
                {




                }
                if (mayasko4.posk == 1)
                {
                    Myasnoe2.ForAdmin();
                    Myasnoe2.Dob();

                    foreach (var item in mayasko4.SerchVse)
                    {
                        Console.SetCursorPosition(15, str);
                        Console.Write(item[2]);
                        Console.SetCursorPosition(30, str);
                        Console.Write(item[0]);
                        Console.SetCursorPosition(45, str);
                        Console.Write(item[1]);
                        Console.SetCursorPosition(60, str);
                        Console.Write(item[3]);
                        str += 1;
                        i += 1;
                        mayasko4.posk = 0;
                    }
                }

                mayasko4.posii = 3;
                myasnayastr StrelkaUsing = new myasnayastr(3, i);
                StrelkaUsing.Myas();

                if (mayasko4.J == 1)
                {
                    Program.Main();
                }
                else if (mayasko4.O == 1)
                {
                    Create();
                }
                else if (mayasko4.O == 2)
                {
                    Console.Clear();
                    Meatt();
                }

                if (mayasko4.key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Myasnoe2.IA();
                    Podrobnaya();
                }
            }
        }

        public void Create()
        {
            Myasnoe2.F1AT();
            Myasnoe2.Dob();
            string[] ADD = new string[4];
            List<string> ADDL = new List<string>();

            while (true)
            {
                myasnayastr StrelkaUsing = new myasnayastr(2, 5);
                StrelkaUsing.Myas();

                if (mayasko4.key.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    break;
                }
                else if (mayasko4.J == 1)
                {
                    admmmm AdUsing = new admmmm();
                    AdUsing.Admin();
                }

                if (mayasko4.posii == 2)
                {
                    Console.SetCursorPosition(7, 2);
                    ADD[2] = Console.ReadLine();
                }
                else if (mayasko4.posii == 3)
                {
                    Console.SetCursorPosition(10, 3);
                    ADD[0] = Console.ReadLine();
                }
                else if (mayasko4.posii == 4)
                {
                    Console.SetCursorPosition(11, 4);
                    ADD[1] = Console.ReadLine();
                }
                else if (mayasko4.posii == 5)
                {
                    Console.SetCursorPosition(23, 5);
                    ADD[3] = Console.ReadLine();
                }
            }
            {



            }

            if (ADD[3] == "0")
            {
                ADD[3] = "Admin";
            }
            else
            {
                ADD[3] = "User";
            }

            for (int i = 0; i < 4; i++)
            {
                ADDL.Add(ADD[i]);
            }

            mayasko4.AllVse.Add(ADDL);
            flack.S();
            admmmm AdminUsing = new admmmm();
            AdminUsing.Admin();
        }

        private void Podrobnaya()
        {
            int position = mayasko4.posii;
            int Massiv = position - 3;
            mayasko4.PInf = mayasko4.AllVse[Massiv];

            while (mayasko4.Gru != 1)
            {
                Console.SetCursorPosition(0, 2);
                Console.Write("  ID: "); Console.WriteLine(mayasko4.PInf[2]);
                Console.Write("  ЛОГИН: "); Console.WriteLine(mayasko4.PInf[0]);
                Console.Write("  ПАРОЛЬ: "); Console.WriteLine(mayasko4.PInf[1]);
                Console.Write("  РОЛЬ: "); Console.WriteLine(mayasko4.PInf[3]);

                myasnayastr StrelkaUsing = new myasnayastr(2, 5);
                StrelkaUsing.Myas();

                if (mayasko4.O == 10)
                {
                    Update();
                }
                else if (mayasko4.D == 1)
                {
                    Delll(Massiv);
                }
                else if (mayasko4.key.Key == ConsoleKey.Escape)
                {
                    admmmm AdminUsing = new admmmm();
                    AdminUsing.Admin();
                }
            }
            for (int i = 0; i < 4; i++)
            {
                mayasko4.AllVse[Massiv] = mayasko4.PInf;
            }
            if (mayasko4.J == 1)
            {
                admmmm AdminUsing = new admmmm();
                AdminUsing.Admin();
            }
        }
        public void Read()
        {
            flack.sdsd();
        }
        public void Update()
        {
            if (mayasko4.posii == 2)
            {
                Console.SetCursorPosition(7, 2);
                mayasko4.PInf[2] = Console.ReadLine();
            }
            else if (mayasko4.posii == 3)
            {
                Console.SetCursorPosition(10, 3);
                mayasko4.PInf[0] = Console.ReadLine();
            }
            else if (mayasko4.posii == 4)
            {
                Console.SetCursorPosition(11, 4);
                mayasko4.PInf[1] = Console.ReadLine();
            }
            else if (mayasko4.posii == 5)
            {
                Console.SetCursorPosition(23, 5);
                mayasko4.PInf[3] = Console.ReadLine();
            }

            flack.S();
            admmmm AdminUsing = new admmmm();
            AdminUsing.Admin();
        }
        private void Meatt()
        {
            mayasko4.SerchVse.Clear();
            Myasnoe2.Dob();
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Критерии поиска:");
            Console.WriteLine("  ID");
            Console.WriteLine("  ЛОГИН");
            Console.WriteLine("  ПАРОЛЬ");
            Console.WriteLine("  РОЛЬ");

            string sear = "";
            int isear = 0;

            while (mayasko4.D != 1)
            {
                myasnayastr StrelkaUsing = new myasnayastr(3, 6);
                StrelkaUsing.Myas();
                if (mayasko4.posii == 3)
                {
                    isear = 2;
                }
                else if (mayasko4.posii == 4)
                {
                    isear = 0;
                }
                else if (mayasko4.posii == 5)
                {
                    isear = 1;
                }
                else if (mayasko4.posii == 6)
                {
                    isear = 3;
                }
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Введите данные чтобы чтоб");
                sear = Console.ReadLine();
                foreach (var item in mayasko4.AllVse)
                {
                    if (item[isear] == sear)
                    {
                        mayasko4.SerchVse.Add(item);
                    }
                }
                mayasko4.posk = 1;
                admmmm AdminUsing = new admmmm();
                AdminUsing.Admin();
            }


        }
        public void Delll(int Massiv)
        {
            mayasko4.AllVse.RemoveAt(Massiv);
            flack.S();
            admmmm AdminUsing = new admmmm();
            AdminUsing.Admin();
        }
    }
}
