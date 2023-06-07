using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        int number = 496753;
        var time = new Stopwatch();
        var border = new string('=', 110);
        FirstList(number, time);
        Console.WriteLine(border);
        SecondList(number, time);
        Console.WriteLine(border);
        LastList(number, time);

    }

        static void FirstList(int number, Stopwatch time)
        {
            var list = new List<int>();
            time.Start();
            for (int element = 1; element <= 1000000; element++)
            {
                list.Add(element);
            }
            time.Stop();
            Console.WriteLine("Время cоздания коллекции list " + time.Elapsed);
            time.Reset();
            time.Start();
            Console.WriteLine(list[number]);
            time.Stop();
            Console.WriteLine("Время поиска и вывода элемента,в коллекции list, под индексом 496753 " + time.Elapsed);
            time.Reset();
            time.Start();
            foreach (int e in list)
            {
                if (e % 777 == 0)
                {
                    Console.WriteLine(e);
                }
            }
            time.Stop();
            Console.WriteLine("Время поиска и вывода всех чисел в коллекции list, которые делятся на 777 без остатка " + time.Elapsed);
            time.Reset();
        }
        static void SecondList(int number, Stopwatch time)
        {
            var arrList = new ArrayList();
            time.Start();
            for (int element = 1; element <= 1000000; element++)
            {
                arrList.Add(element);
            }
            time.Stop();
            Console.WriteLine("Время cоздания коллекции arrList " + time.Elapsed);
            time.Reset();
            time.Start();
            Console.WriteLine(arrList[number]);
            time.Stop();
            Console.WriteLine("Время поиска и вывода элемента,в коллекции arrList, под индексом 496753 " + time.Elapsed);
            time.Reset();
            time.Start();
            foreach (int e in arrList)
            {
                if (e % 777 == 0)
                {
                    Console.WriteLine(e);
                }
            }
            time.Stop();
            Console.WriteLine("Время поиска и вывода всех чисел в коллекции arrList, которые делятся на 777 без остатка " + time.Elapsed);
            time.Reset();
        }
        static void LastList(int number, Stopwatch time)
        {
            var linkedList = new LinkedList<int>();
            time.Start();
            for (int element = 1; element <= 1000000; element++)
            {
                linkedList.AddLast(element);
            }
            time.Stop();
            Console.WriteLine("Время cоздания коллекции linkedList " + time.Elapsed);
            time.Reset();
            time.Start();
            var f = linkedList.First;
                for (int a = 0; a < number; a++)
            {
                f = f.Next;
            }
            time.Stop();
            Console.WriteLine(f.Value);
            Console.WriteLine("Время поиска и вывода элемента,в коллекции linkedList, под индексом 496753 " + time.Elapsed);
            time.Reset();
            time.Start();
            foreach (int e in linkedList)
            {
                if (e % 777 == 0)
                {
                    Console.WriteLine(e);
                }
            }
            time.Stop();
            Console.WriteLine("Время поиска и вывода всех чисел в коллекции linkedList, которые делятся на 777 без остатка " + time.Elapsed);
            time.Reset();
        }
    
}








