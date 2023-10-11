using System.Text;
namespace N1
{
    class Prog
    {
        static void cube(int a, string b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("{0} ", b);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну куба");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите символ");
            string b = Console.ReadLine();
            cube(a, b);
        }
    }
}
namespace N2
{
    class PROG
    {
        static bool Pali(string a)
        {
            string[] numbers = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int e = numbers.Length;
            int z = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[e - z])
                {
                    z++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число через пробел");
            string a = Console.ReadLine();
            Console.WriteLine(Pali(a));
        }
    }
}
namespace N3
{
    class PROG
    {
        static void Filtr(ref string[] a, string[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        a[i] = "";
                    }
                    else { }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите");
            string[] a = new string[4];
            for (int i = 0; i < 4; i++)
            {
                a[i] = Console.ReadLine();
            }
            Console.WriteLine("Введите");
            string[] b = new string[1];
            for (int i = 0; i < 1; i++)
            {
                b[i] = Console.ReadLine();
            }
            Filtr(ref a, b);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }
        }
    }
}
namespace N4
{
    class Web_site
    {
        public string URL;
        public string Name;
        public string Title;
        public string IP;
        public string url
        {
            get { return URL; }
            set { URL = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        public string ip
        {
            get { return IP; }
            set { IP = value; }
        }

    }
    class Prog
    {
        static void Main(string[] args)
        {
            Web_site website = new Web_site();
            website.name = Console.ReadLine();
            website.url = Console.ReadLine();
            website.title = Console.ReadLine();
            website.ip = Console.ReadLine();
            Console.WriteLine($"Название:{website.name}");
            Console.WriteLine($"URL:{website.url}");
            Console.WriteLine($"Oписание:{website.title}");
            Console.WriteLine($"IP:{website.ip}");
        }
    }
}
namespace N5
{
    class Jornal
    {
        public string Year;
        public string Name;
        public string Title;
        public string Number;
        public string Email;
        public string year
        {
            get { return Year; }
            set { Year = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        public string number
        {
            get { return Number; }
            set { Number = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

    }
    class Prog
    {
        static void Main(string[] args)
        {
            Jornal jornal = new Jornal();
            jornal.name = Console.ReadLine();
            jornal.year = Console.ReadLine();
            jornal.title = Console.ReadLine();
            jornal.number = Console.ReadLine();
            jornal.email = Console.ReadLine();
            Console.WriteLine($"Название:{jornal.name}");
            Console.WriteLine($"Год основания:{jornal.year}");
            Console.WriteLine($"Oписание журнала:{jornal.title}");
            Console.WriteLine($"Kонтактный телефон:{jornal.number}");
            Console.WriteLine($"Kонтактный e-mail:{jornal.email}");
        }
    }
}
namespace N6
{
    class Store
    {
        public string Addres;
        public string Name;
        public string Title;
        public string Email;
        public string Number;
        public string addres
        {
            get { return Addres; }
            set { Addres = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string number
        {
            get { return Number; }
            set { Number = value; }
        }

    }
    class Prog
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.name = Console.ReadLine();
            store.addres = Console.ReadLine();
            store.title = Console.ReadLine();
            store.number = Console.ReadLine();
            store.email = Console.ReadLine();
            Console.WriteLine($"название магазина:{store.name}");
            Console.WriteLine($"адрес:{store.addres}");
            Console.WriteLine($"описание профиля магазина:{store.title}");
            Console.WriteLine($"контактный телефон:{store.number}");
            Console.WriteLine($"контактный e-mail:{store.email}");
        }
    }
}