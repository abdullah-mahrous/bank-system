using System;
using System.Collections.Generic;
using System.Text;

namespace bankapp
{
    public abstract class user
    {
        protected int id;
        protected string name;
        protected int age;
        protected string email;
        protected string password;

        public abstract void register();

    }

    public class employee : user
    {
        private int id;
        private string name;
        private int age;
        private string email = "admin0@gmail.com";
        private string password = "admin00";
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int AGE
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string EMAIL
        {
            get
            {
                return email;
            }
        }

        public string PASSWORD
        {
            get
            {
                return password;
            }
        }

        public override void register()
        {
            Console.WriteLine("enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("enter your age : ");
            age = int.Parse(Console.ReadLine());

        }

        public void viewcounter()
        {
            Console.WriteLine("we have " + customer.counter + " customer signed in our system");
        }

    }
        public class customer : user
        {
            private int id;
            private string name;
            private int age;
            private string email;
            private string password;
            private double balance ;
            public static int counter;
            
            public customer()
            {
                counter++;
            }
            public int ID
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }

            public double BALANCE
            {
                get
                {
                    return balance;
                }
                set
                {
                    balance = value;
                }
            }

            public string NAME
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public string EMAIL
            {
                get
                {
                    return email;
                }
                set
                {
                    email = value;
                }
            }

            public string PASSWORD
            {
                get
                {
                    return password;
                }
                set
                {
                    password = value;
                }
            }

            public int AGE
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }

            public override void register()
            {
                Console.WriteLine("enter your name : ");
                name = Console.ReadLine();
                Console.WriteLine("enter your age : ");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your email : ");
                email = Console.ReadLine();
                Console.WriteLine("enter your password : ");
                password = Console.ReadLine();

            }

            public double deposit()
            {

             Console.WriteLine("\nyour balance: "+balance);
             Console.WriteLine("\nenter the cash amount you want to deposit");
                double cash_amount = double.Parse(Console.ReadLine());
                balance += cash_amount;
                return balance;
            }

            public double withdrow()
            {

             Console.WriteLine("your balance : " + balance);
             Console.WriteLine("enter the cash amount you want to withdrow");
                double cash_amount = double.Parse(Console.ReadLine());
                balance -= cash_amount;
                return balance;
            }

        }

}
