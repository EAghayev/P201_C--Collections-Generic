using System;

namespace _09112021
{
    class Program
    {
        static void Main(string[] args)
        {

            var order1 = new Order();
            var order2 = new Order();
            var order3 = new Order();

            Console.WriteLine(order1.No);
            Console.WriteLine(order2.No);
            Console.WriteLine(order3.No);

            OrderList orderList = new OrderList();
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);


            Console.WriteLine(orderList.FindByIndex(1).No);


            StringList stringList = new StringList();
            stringList.Add("name1");
            stringList.Add("name2");
            stringList.Add("name3");
            stringList.Add("name4");

            Console.WriteLine(stringList.FindByIndex(0));
            Console.WriteLine(stringList.FindByIndex(1));
            Console.WriteLine(stringList.FindByIndex(2));

            IntList intList = new IntList();
            intList.Add(41);
            intList.Add(14);
            intList.Add(4);

            Console.WriteLine(intList.FindByIndex(0));
            Console.WriteLine(intList.FindByIndex(1));
            Console.WriteLine(intList.FindByIndex(2));

            MyList<int> myListInt = new MyList<int>();
            myListInt.Add(50);
            myListInt.Add(51);
            myListInt.Add(52);

            Console.WriteLine(myListInt.FindByIndex(0));
            Console.WriteLine(myListInt.FindByIndex(1));
            Console.WriteLine(myListInt.FindByIndex(2));

            MyList<Order> myListOrders = new MyList<Order>();
            myListOrders.Add(order1);
            myListOrders.Add(order2);
            myListOrders.Add(order3);

            Console.WriteLine(myListOrders.FindByIndex(0).No);
            Console.WriteLine(myListOrders.FindByIndex(1).No);
            Console.WriteLine(myListOrders.FindByIndex(2).No);

            //MyList<Animal> myListAnimals = new MyList<Animal>();

            PhoneBook<string, string> phoneBook = new PhoneBook<string, string>();
            phoneBook.Add("012 421-21-21", "Hikmet");
            phoneBook.Add("012 313-41-71", "Abbas");
            phoneBook.Add("012 615-71-75", "Nigar");

            Console.WriteLine(phoneBook.GetName("012 615-71-75"));
            Console.WriteLine(phoneBook.GetName("012 313-41-71"));


        }
    }
}
