using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Batch16Oops
{
    internal interface Collections

    {
        static void Main()
        {
            //Generic Collections
            //1) List

            //list declarations
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers[1]);

            //Dictionary

            //initilize dictionary
            Dictionary<string, int> namedict = new Dictionary<string, int>();

            //add key-value pairs to the dictionary

            namedict.Add("Rohit", 25);
            namedict.Add("Abhishek", 30);
            namedict.Add("Gargi", 24);

            Console.WriteLine("All elements added in the dictionary");

            foreach (KeyValuePair<string, int> pair in namedict)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");

            }

            //modify dictionay

            namedict["Gargi"]=26;
            Console.WriteLine("All elements added in the dictionary after mofify");

            foreach (KeyValuePair<string, int> pair in namedict)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");

            }

            //remove element  in dictionay
            namedict.Remove("Rohit");

            //search element in the dictionary

            if (namedict.ContainsKey("Gargi"))
            {
                Console.WriteLine("Exist  in the Dictionary");
            }
            else
            {
                Console.Write("Not exist in the Dictionary");

            }
            //Queue

            //FIFO - First in first OUt

            Queue qu = new Queue();

            qu.Enqueue("Test");//first in
            qu.Enqueue(9985);
            qu.Enqueue(true);


            //remove elemet in queue

            object firstelement = qu.Dequeue();  //first out
            object secondelement = qu.Dequeue();
            object thridelment = qu.Dequeue();

            //display

            Console.WriteLine("Dequed elements");
            Console.WriteLine(firstelement);
            Console.WriteLine(secondelement);
            Console.WriteLine(thridelment);



            //stack
            //LIFO last in first out

            Stack st = new Stack();
            st.Push("TOP");
            st.Push(42);
            st.Push(false);  //last in

            Console.WriteLine(st);

            object topelement = st.Pop();
            object secondelemnt = st.Pop();
            object thirdelement = st.Pop();




            //hasset 

            HashSet<int> numbers1 = new HashSet<int>();

            //add element in to hasset

            numbers1.Add(1);
            numbers1.Add(2);
            numbers1.Add(3);
            numbers1.Add(4);
            numbers1.Add(5);
            numbers1.Add(5);   //duplicate elements

            Console.WriteLine("Hasset Elements");
            foreach (int i in numbers1)
            {
                Console.Write(i);
            }

            //find element in hasset
            bool containstwo = numbers1.Contains(2);
            Console.WriteLine("hastset elememt 2:" + containstwo);

            numbers1.Remove(2);



            //array list
            //creating array list
            ArrayList list = new ArrayList();

            //add elements 

            list.Add(1);
            list.Add("Test");
            list.Add(3.20);
            list.Add(false);


            //insert element  at specific index

            list.Insert(2, "New inerted item");

            //display all elements

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //remove with item
            list.Remove("Test");

            //remove by index
            list.RemoveAt(2);

            Console.WriteLine("\n after removal :");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //hashtable

            //create hashtable
            Hashtable ht = new Hashtable();

            //add key-value paring

            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");

            Console.WriteLine("Value for key 2:"+ht[2]);

            //key exists
            if(ht.ContainsKey(3))
            {
                Console.WriteLine("key 3 is there");
            }

            //remove a key
            ht.Remove(1);


            foreach(DictionaryEntry entry in ht)
            {
                Console.WriteLine($"key: {entry.Key},value {entry.Value}");
            }





        }


    }
}
