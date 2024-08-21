using System;
using System.Net.Sockets;

namespace Property
{
    #region 물이 아프면? 식수
    //class birthdayInfo
    //{
    //    private string name;

    //    private DateTime birthday;
    //    public string Name
    //    {
    //        get
    //        {
    //            return name;
    //        }
    //        set
    //        {
    //            name = value;   
    //        }

    //    }
    //    public DateTime Birthday
    //    {
    //        get
    //        {
    //            return birthday;

    //        }
    //        set
    //        {
    //            birthday = value;
    //        }
    //    }
    //    public int Age
    //    {
    //        get
    //        {
    //            return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
    //        }
    //    }

    //}
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        birthdayInfo birth = new birthdayInfo();
    //        birth.Name = "서현";
    //        birth.Birthday = new DateTime(1991, 6, 28);
    //        Console.WriteLine($"Name : {birth.Name}");
    //        Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
    //        Console.WriteLine($"Age : {birth.Age}");
    //    }
    //}

    #endregion
    #region 사과가 웃으면? 풋사과
    //class BirthdayInfo
    //{
    //    public string Name { get; set; } = "Unkown";
    //    public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
    //    public int Age
    //    {
    //        get
    //        {
    //            return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
    //        }
    //    }
    //}
    //class Mainapp
    //{
    //    static void Main(string[] args)
    //    {
    //        BirthdayInfo birth = new BirthdayInfo();
    //        Console.WriteLine($"Name : {birth.Name}");
    //        Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
    //        Console.WriteLine($"Age : {birth.Age}");

    //        birth.Name = "서현";
    //        birth.Birthday = new DateTime(1991, 6, 28);
    //        Console.WriteLine($"Name : {birth.Name}");
    //        Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
    //        Console.WriteLine($"Age : {birth.Age}");

    //    }



    //}
    #endregion
    #region 습관이 총에 맞으면? 악..습관
    //class BirthdayInfo
    //{
    //    public string Name
    //    {
    //        get; set;

    //    }
    //    public DateTime Birthday
    //    {
    //        get; set;
    //    }
    //    public int Age
    //    {
    //        get
    //        {
    //            return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;

    //        }
    //    }
    //}
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        BirthdayInfo birth = new BirthdayInfo()
    //        {
    //            Name = "서현",
    //            Birthday = new DateTime(1991, 6, 28)

    //        };
    //        Console.WriteLine($"Name : {birth.Name}");
    //        Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
    //        Console.WriteLine($"Age : {birth.Age}");
    //    }
    //}
    #endregion
    #region 눈이 아파서열이 39도인것 같다(아.프.다);
    //class Transaction
    //{
    //    public string From { get; init; }
    //    public string To { get; init; }
    //    public int Amount { get; init; }

    //    public override string ToString()
    //    {
    //        return $"{From,-10}-> {To,-10} : ${Amount}";
    //    }

    //}
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Transaction tr1 = new Transaction{ From = "Alice", To = "Bob", Amount = 100 };
    //        Transaction tr2 = new Transaction{From = "Bob", To = "Charlie", Amount=50};
    //        Transaction tr3 = new Transaction { From = "Charlie", To = "Alice", Amount = 50 };

    //        Console.WriteLine(tr1);
    //        Console.WriteLine(tr2);
    //        Console.WriteLine(tr3);
    //    }
    //}
    #endregion
    record RTransaction
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Amount { get; set; }



        public override string ToString()
        {
            return $"{From,-10}-> {To,-10} : ${Amount}";
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            RTransaction tr1 = new RTransaction()
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };
            RTransaction tr2 = new RTransaction()
            {
                From = "Alice", To = "Charlie", Amount = 100
            };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
        }
    }
}