using System;
using System.Threading;
using System.Collections.Generic;

namespace HW15
{
    class Program
    {
        public static List<Cusstomer> Cusstomer = new List<Cusstomer>();

    
        static void Main()
        {
                TimerCallback timer = new TimerCallback(CheckBalance);
                 Timer Time = new Timer(timer, Cusstomer, 0, 10000);

                 int Choise= int.Parse(Console.ReadLine());
                 switch (Choise)
                 {
                     case 1:
                     {
                          Thread TheadInsert = new Thread(new ThreadStart(Insert));
                          TheadInsert.start();
                          TheadInsert.join();
                     }
                          
                     
                     default:
                 }
        }
        

        public static void Insert()
        {
            System.Console.WriteLine("Please Add your's Id and Balance:");
            System.Console.Write("Write your Id: ");
            int Id =int.Parse(Console.ReadLine());
            System.Console.Write("Write your Balance: ");
            decimal Balance =decimal.Parse(Console.ReadLine());
            Cusstomer CustInsert=new Cusstomer(id,Balance);
            Cusstomer=Add(CustInsert);
        }
        public static void Select()
        {

        }
        public static void Update()
        {

        }
        public static void Delete()
        {
            
        }
    }
    class Cusstomer
    {
        public int id {get;set;}
        public decimal Balance { get; set; }

        public Cusstomer()
        {

        }
        public Cusstomer(int id, decimal Balance )
        {
            this.id;
            this.Balance;
        }
    }
}