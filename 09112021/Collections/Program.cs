using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Non generic collections

            //Arraylist
            ArrayList arrList = new ArrayList();
            arrList.Add("P201"); ;
            arrList.Add("Hikmet");
            arrList.Add(2021);
            arrList.Add(new Human { Name = "Nugar", Surname = "Abbasova" });

            arrList.Remove("Hikmet");
            arrList.RemoveAt(0);

            Console.WriteLine(arrList[0]);
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

            //SortedList
            SortedList sortedList = new SortedList();
            sortedList.Add("P201", new Human { Surname = "Abbasova", Name = "Nergiz" });
            sortedList.Add("P200", "Abbas");

            sortedList["P201"] = "fd";
            var value = sortedList["P201"];
            Console.WriteLine(value);

            //Queue
            Queue queue = new Queue();
            queue.Enqueue(13);
            queue.Enqueue(14);
            queue.Enqueue(134);
            queue.Enqueue("P201");


            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());


            Console.WriteLine("Queue items:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Stack
            Stack stack = new Stack();
            stack.Push(400);
            stack.Push("P123");
            stack.Push("P205");
            stack.Push(45.6);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Peek: "+stack.Peek());


            Console.WriteLine("Stack items:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


            //HastTable
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "P201");
            hashtable.Add(4, 345);

            Console.WriteLine("hash table keys:");
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(hashtable[item]);
            }






            #endregion

            #region Generic collections

            //List
            List<int> newNumbers = new List<int> { -90, 98, 84, 13 };
            List<int> numbers = new List<int>(5);
            Console.WriteLine("capacity: "+numbers.Capacity);
            numbers.Add(45);
            numbers.Add(45);
            numbers.Add(15);
            numbers.Add(15);
            numbers.Add(15);
            numbers.Add(45);
            Console.WriteLine("capacity: " + numbers.Capacity);
            numbers.Add(45);
            numbers.Add(15);
            Console.WriteLine("capacity: " + numbers.Capacity);
            numbers.Add(15);
            Console.WriteLine("capacity: " + numbers.Capacity);
            numbers.Add(45);
            numbers.Add(45);
            numbers.Add(15);
            numbers.Add(15);
            numbers.Remove(45);

            Console.WriteLine("capacity: " + numbers.Capacity);

            numbers.Clear();
            Console.WriteLine("capacity: " + numbers.Capacity);

            Console.WriteLine(numbers.Count);

            //numbers.Sort();
            //numbers.Reverse();

            Console.WriteLine("List items:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            List<Human> humans = new List<Human>();
            humans.Add(new Human { Name = "name1", Surname = "Surname1" });
            humans.Add(new Human { Name = "name2", Surname = "Surname2" });
            humans.Add(new Human { Name = "name3", Surname = "Surname3" });
            humans.Add(new Human { Name = "name4", Surname = "Surname4" });

            Console.WriteLine("3. name"+humans[2].Name);

            humans.RemoveAt(1);

            foreach (var item in humans)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(humans[humans.Count-1].Name);

            //Dictionary
            Dictionary<string, Human> studnets = new Dictionary<string, Human>();

            studnets.Add("VB123", new Human { Name = "name1", Surname = "surname1" });
            studnets.Add("VB143", new Human { Name = "name2", Surname = "surname2" });
            studnets.Add("TF444", new Human { Name = "name3", Surname = "surname3" });
            studnets.Add("AA111", new Human { Name = "name4", Surname = "surname4" });

            Console.WriteLine("dictionary items:");
            foreach (var item in studnets)
            {
                Console.WriteLine(item.Key + " - "+item.Value);
            }


            Console.WriteLine("Studentin keyini daxil edin:");
            string key = Console.ReadLine();


            if (studnets.ContainsKey(key))
                Console.WriteLine(studnets[key].Name);
            else 
                Console.WriteLine("Daxil etdiyiniz key-de data yoxdur!");

            SortedList<int, string> genSortedList = new SortedList<int, string>();
            genSortedList.Add(4, "test1");
            genSortedList.Add(1, "tester5");
            genSortedList.Add(3, "test3");

            Console.WriteLine("generic sortedList items:");
            foreach (var item in genSortedList)
            {
                Console.WriteLine(item.Key +" - "+item.Value);
            }

            Queue<string> genQueue = new Queue<string>();
            genQueue.Enqueue("P201");
            genQueue.Enqueue("P202");
            genQueue.Enqueue("P203");

            Console.WriteLine(genQueue.Dequeue());

            Console.WriteLine(genQueue.Count);

            Stack<string> genStack = new Stack<string>();
            genStack.Push("P201");
            genStack.Push("P202");
            genStack.Push("P203");

            Console.WriteLine(genStack.Pop());
            Console.WriteLine(genStack.Count);

            //HashSet

            HashSet<int> intSet = new HashSet<int>();
            intSet.Add(45);
            intSet.Add(15);
            intSet.Add(25);
            intSet.Add(45);
            intSet.Add(45);
            intSet.Add(45);

            HashSet<Human> humanSet = new HashSet<Human>();

            Human human1 = new Human { Name = "Hikmet", Surname = "Abbasov" };
            Human human2 = new Human { Name = "Tunzale", Surname = "Abbasova" };

            humanSet.Add(human1);
            humanSet.Add(human2);
            humanSet.Add(new Human { Name = "Abdulla", Surname = "Hikmetov" });
            human2.Name = "Yeni ad";
            humanSet.Add(human2);
            humanSet.Add(new Human { Name = "Hikmet", Surname = "Abbasov" });


            Console.WriteLine("hashset items:");
            foreach (var item in humanSet)
            {
                Console.WriteLine(item);
            }


            #endregion

            LinkedList<int> linkedInt = new LinkedList<int>();

        }
    }
}
