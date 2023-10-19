using System;
using Task;




public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Fairytales: ");

        // Создание объектов сказок

        Cinderella cinderella = new Cinderella("Charles Perrault", 1697, "Prince Charles", true, "French, english, greek", 8.3);

        LittleRedRidingHood redRidingHood = new LittleRedRidingHood("Brothers Grimm", 1812, "Grandma Smith", true, "French", 7.7);

        CockTheRoach cockTheRoach = new CockTheRoach("Korney Chukovsky", 1921, "Sparrow", false, "Russian", 8.2);


        bool flag = true;
        bool flag2 = true;
        while (flag)
        {
            
            try
            {
                Console.WriteLine("\n1 - Cinderella \n2  Little Red Riding Hood \n3 - Cock-The-Roach \n0 - exit\n");
                Console.Write("Choose the option: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    flag2 = true;
                    if (number == 0)
                    {
                        flag = false;
                    }
                    if (number == 1)
                    {
                        cinderella.Name();
                        while (flag2)
                        {
                            Console.WriteLine("1 - short information \n2 - Extended information \n3 - Description \n4 - Plot and moral lesson \n5 - Link \n0 - Back to the book list");
                            Console.Write("\nChoose the option: ");
                            if (int.TryParse(Console.ReadLine(), out int number2))
                            {
                                if (number2 == 1)
                                {
                                    cinderella.ShortInfo();
                                }
                                if (number2 == 2)
                                {
                                    cinderella.ExtendedInfo();
                                }
                                if (number2 == 3)
                                {
                                    cinderella.Description();
                                }
                                if (number2 == 4)
                                {
                                    cinderella.Plot();
                                    cinderella.MoralLesson();
                                }
                                if (number2 == 5)
                                {
                                    cinderella.Link();
                                }
                                if (number2 == 0)
                                {
                                    flag2 = false;
                                }
                            }
                        }

                    }

                    if (number == 2)
                    {
                        redRidingHood.Name();
                        while (flag2)
                        {
                            Console.WriteLine("1 - short information \n2 - Extended information \n3 - Description \n4 - Plot and moral lesson \n5 - Link \n0 - Back to the book list");
                            Console.Write("\nChoose the option: ");
                            if (int.TryParse(Console.ReadLine(), out int number2))
                            {
                                if (number2 == 1)
                                {
                                    redRidingHood.ShortInfo();
                                }
                                if (number2 == 2)
                                {
                                    redRidingHood.ExtendedInfo();
                                }
                                if (number2 == 3)
                                {
                                    redRidingHood.Description();
                                }
                                if (number2 == 4)
                                {
                                    redRidingHood.Plot();
                                    redRidingHood.MoralLesson();
                                }
                                if (number2 == 5)
                                {
                                    redRidingHood.Link();
                                }
                                if (number2 == 0)
                                {
                                    flag2 = false;
                                }
                            }
                        }
                    }
                    if (number == 3)
                    {
                        cockTheRoach.Name();
                        while (flag2)
                        {
                            Console.WriteLine("1 - short information \n2 - Extended information \n3 - Description \n4 - Plot and moral lesson \n5 - Link \n0 - Back to the book list");
                            Console.Write("\nChoose the option: ");
                            if (int.TryParse(Console.ReadLine(), out int number2))
                            {
                                if (number2 == 1)
                                {
                                    cockTheRoach.ShortInfo();
                                }
                                if (number2 == 2)
                                {
                                    cockTheRoach.ExtendedInfo();
                                }
                                if (number2 == 3)
                                {
                                    cockTheRoach.Description();
                                }
                                if (number2 == 4)
                                {
                                    cockTheRoach.Plot();
                                    cockTheRoach.MoralLesson();
                                }
                                if (number2 == 5)
                                {
                                    cockTheRoach.Link();
                                }
                                if (number2 == 0)
                                {
                                    flag2 = false;
                                }
                                
                            }
                        }
                    }
                    if (number < 0 || number > 3)
                    {
                         throw new Exception("Введите номер от 1 до 3");
                    }
                }
                else
                {
                    throw new FormatException("Введите число");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }           
    }                   
}

