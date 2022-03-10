using System;

namespace bankapp

{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter as :\n1-admin\n2-user\n\n\nto quite enter Q");
                string choice = Console.ReadLine();
                if (choice =="Q")
                {
                    break;
                }
                else if (choice =="1")
                {
                    employee emp = new employee();
               
                    while (true)
                    {
                        Console.WriteLine("1-register\n2-login");
                        choice = Console.ReadLine();
                        if(choice == "1")
                        {
                            emp.register();
                            break;
                        }
                        else if (choice == "2")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("invalide input");
                        }

                    }

                    while (true)
                    {
                        Console.WriteLine("enter your email : ");
                        string logemail = Console.ReadLine();
                        Console.WriteLine("enter your password : ");
                        string logpass = Console.ReadLine();
                        Console.WriteLine("if you want to exite enter Q : ");
                        string quite = Console.ReadLine();
                        if (logemail == emp.EMAIL && logpass == emp.PASSWORD)
                        {

                            Console.WriteLine("welcome admin " + emp.NAME);
                            break;
                        }
                        else if (quite == "Q")
                        {
                            break;
                        }
                        else if (logemail != emp.EMAIL || logpass != emp.PASSWORD)
                        {
                            Console.WriteLine("incorrect password or email");
                        }
                    }
                    Random random = new Random();
                    emp.ID = random.Next(100000000, 999999999); 
                    Console.WriteLine("****************************\nname : " + emp.NAME+"\n****************************\n id : "+emp.ID+
                        "\n****************************\nage : " + emp.AGE+ "\n****************************\nemail : " + emp.EMAIL+
                        "\n****************************\npassword : " + emp.PASSWORD);
                    while (true)
                    { 
                    Console.WriteLine("1-view number of customers in the system\n" +
                        "2-delete users\n3-view users data\nto quite enter Q");
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            emp.viewcounter();
                        }
                        else if (choice == "Q")
                        {
                            break;
                        }
                        else if (choice == "2")
                        {
                            Console.WriteLine("this part of the system is still under development");
                        }
                        else if (choice == "3")
                        {
                            Console.WriteLine("this part of the system is still under development");
                        }
                        else
                        {
                            Console.WriteLine("invalide choice");
                        }

                    }
                }
                else if (choice =="2")
                {
                    customer cust1 = new customer();

                    while (true)
                    {
                        Console.WriteLine("1-register\n2-login");
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            Console.WriteLine("\nregistering \n");
                            cust1.register();
                            break;
                        }
                        else if (choice == "2")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("invalide input");
                        }

                    }

                    Console.WriteLine("\nlogging in \n");

                    while (true)
                    {

                        Console.WriteLine("enter your email : ");
                        string logemail = Console.ReadLine();
                        Console.WriteLine("enter your password : ");
                        string logpass = Console.ReadLine();
                        Console.WriteLine("if you want to exite enter Q : ");
                        string quite = Console.ReadLine();
                        if (logemail == cust1.EMAIL && logpass == cust1.PASSWORD)
                        {

                            Console.WriteLine("welcome " + cust1.NAME);
                            break;
                        }
                        else if (quite == "Q")
                        {
                            break;
                        }
                        else if (logemail != cust1.EMAIL || logpass != cust1.PASSWORD)
                        {
                            Console.WriteLine("incorrect password or email");
                        }
                    }

                    Random random = new Random();
                    cust1.ID = random.Next(100000000, 999999999);
                    Console.WriteLine("****************************\nname : " + cust1.NAME +
                        "\n****************************\nage : " + cust1.AGE + "\n****************************\nemail : " + cust1.EMAIL +
                        "\n****************************\npassword : " + cust1.PASSWORD+ "\n****************************\nbalance : "+cust1.BALANCE);
                    while (true)
                    {
                        Console.WriteLine("1-make a deposit\n" +
                            "2-withdrow\n3-view your data\n4-quite");
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            cust1.deposit();
                            Console.WriteLine("your balance : " + cust1.BALANCE);
                        }
                        else if (choice == "4")
                        {
                            break;
                        }
                        else if (choice == "2")
                        {
                            cust1.withdrow();
                            Console.WriteLine("your balance : "+cust1.BALANCE);
                        }
                        else if (choice == "3")
                        {
                            Console.WriteLine("****************************\nname : " + cust1.NAME +
                          "\n****************************\nage : " + cust1.AGE + "\n****************************\nemail : " + cust1.EMAIL +
                          "\n****************************\npassword : " + cust1.PASSWORD + "\n****************************\nbalance : " + cust1.BALANCE);
                        }
                        else
                        {
                            Console.WriteLine("invalide choice");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("invalid choice");
                }

            }

            Console.WriteLine("goodbye");
    }
    }
}
