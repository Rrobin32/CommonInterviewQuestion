using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    public class HashTables
    {
        public static void Main(string[] args)
        {
            //Hashtable hashTable = new Hashtable();
            //hashTable.Add("1","Data");

            //foreach (DictionaryEntry item in hashTable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
            //Console.ReadLine();

            //*
            //**
            //***
            //****
            //*****
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j <= 5 - i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int k = 1; k <= 5 - i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            //a  a = new a();
            //int i = a.func(30);
            //Console.WriteLine(i);

            //Single s = a.func(2.5f);
            //Console.WriteLine(s);

            //string q = "olla";
            //string b = "ollA";
            //if (q == b)
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Unequal");
            //}
            //if (q.Equals(b))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Unequal");
            //}

            //ArrayList a = new ArrayList();
            //a.Add("A");
            //a.Add("B");
            //a.Add("C");

            //foreach (var item in a)
            //{
            //    Console.Write(item + " ");
            //}

            //char[] c = { 'a', 'b', 'c' };
            //string str = new string(c);
            //string str1 = "abcd";
            //Console.Write(str1.Length + " " + str.Length);

            int[] val = { 4, 1, 1, 6, 3 };
            var ltavg = from n in val let x = val.Average() where n < x select n;
            Console.WriteLine(val.Average());


        }
    }

    public class a
    {
        public int func(int x)
        {
            x = x + 20;
            return x;
        }

        public float func(float t)
        {
            t = t + 3.4f;
            return t;
        }
    }
}
