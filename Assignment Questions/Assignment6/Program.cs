using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        // Hashtable table = new Hashtable();
        // table.Add(100,"Amruth");
        // table.Add(200,"Ranjan");
        // table.Add(300,"Nuthan");
        // table.Add(400,"Nithin");

        // Console.WriteLine("Hashtable key value pairs\n");

        // foreach(var k in table)
        // {
        //     Console.WriteLine(k);
        // }

        // ICollection key = table.Keys;

        // Console.WriteLine("\n\nHashtable keys\n");
        // foreach(var k in key)
        // {
        //     Console.WriteLine(k);
        // }

        // ICollection value = table.Values;

        // Console.WriteLine("\n\nHashtable keys\n");
        // foreach(var v in value)
        // {
        //     Console.WriteLine(v);
        // }


        // Console.WriteLine("\n\nAccessing values using keys\n");
        // foreach(var k in key)
        // {
        //     Console.WriteLine($"Key is {k} Value is {table[k]}");
        // }

        // Console.Write("\nEnter input: ");

        // int input = int.Parse(Console.ReadLine());

        // if (table.ContainsKey(input))
        // {
        //     Console.WriteLine($"HashTable contains Key {input} and its value is {table[input]}");
        // }
        // else
        // {
        //     Console.WriteLine($"Hashtbale does not contain key {input}");
        // }

        // SortedList list = new SortedList();
        // list.Add(500,"Naresh");
        // list.Add(800,"suresh");
        // list.Add(700,"ramesh");
        // list.Add(400,"vattesh");

        // Console.WriteLine("\n\nList key value pairs\n");
        // foreach(var k in list)
        // {
        //     Console.WriteLine(k);
        // }
        // ICollection listkey = list.Keys;

        // Console.WriteLine("\n\nList Keys\n");
        // foreach(var k in listkey)
        // {
        //     Console.WriteLine(k);
        // }

        // ICollection listvalue = list.Values;

        // Console.WriteLine("\n\nList Values \n");
        // foreach(var k in listvalue)
        // {
        //     Console.WriteLine(k);
        // }

        // Console.WriteLine("\n\nAccessing Values using Keys\n");
        // foreach(int k in listkey)
        // {
        //     Console.WriteLine($"List key is {k} and its value is {list[k]}");
        // }

        // Stack stack = new Stack();

        // stack.Push('A');
        // stack.Push('B');
        // stack.Push('C');
        // stack.Push('D');
        // stack.Push('E');
        // stack.Push('F');

        // foreach(var item in stack)
        // {
        //     Console.WriteLine(item);
        // }
        // stack.Pop();
        // stack.Pop();
        // stack.Push('G');
        // stack.Push('H');
        // Console.WriteLine("\n\n\n");
        // foreach(var item in stack)
        // {
        //     Console.WriteLine(item);
        // }

        // Console.WriteLine($"\n\nThe element at the top of stack is {stack.Peek()}");
        // Queue queue = new Queue();
        // queue.Enqueue('A');
        // queue.Enqueue('B');
        // queue.Enqueue('C');
        // queue.Enqueue('D');

        // foreach(var q in queue)
        // {
        //     Console.WriteLine(q);
        // }

        // queue.Dequeue();
        // Console.WriteLine("\n\nAfter removing one element");

        // foreach(var q in queue)
        // {
        //     Console.WriteLine(q);
        // }



        // object o;
        // int i=10;
        // o=i;//Boxing

        // int j=(int)o; //UnBoxing;

        // ArrayList list = new ArrayList();
        // //Boxing
        // list.Add(10);
        // list.Add(false);
        // list.Add(6.45f);

        // int k=(int)list[0];//UnBoxing

        // var v=10;
        // // v="Hello";//Error

        // dynamic d=10;
        // d="Hello";

        // AddClass obj=new AddClass();

        // int sumInt=obj.AddInt(30,20);
        // Console.WriteLine($"Sum of integers is: {sumInt}");
        // float sumFloat=obj.AddFloat(40.0f,25.5f);
        // Console.WriteLine($"Sum of integers is: {sumFloat}");
        // string sumString=obj.AddString("Amruth","Varsha");
        // Console.WriteLine($"Sum of integers is: {sumString}");


        // AddClassGeneric<int> obj2= new AddClassGeneric<int>();
        // Console.WriteLine($"Sum of integers is: {obj2.AddAllType(1,2)}");
        // AddClassGeneric<float> obj3= new AddClassGeneric<float>();
        // Console.WriteLine($"Sum of two floats is: {obj3.AddAllType(2.55f,7.85f)}");
        // AddClassGeneric<string> obj4= new AddClassGeneric<string>();
        // Console.WriteLine($"Concat of two strings is: {obj4.AddAllType("Amruth"," Varsha")}");


        // Employee employee1 = new Employee()
        // {
        //     Id = 10,
        //     Name="Rajesh"
        // };

        // Employee employee2 = new Employee()
        // {
        //     Id = 20,
        //     Name="Ramesh"
        // };

        // List<Employee> employees = new List<Employee>();
        // employees.Add(employee1);
        // employees.Add(employee2);

        // foreach(Employee e in employees)
        // {
        //     Console.WriteLine(e);
        // }

        // Dictionary<int, string> directory = new Dictionary<int, string>();
        // directory.Add(100, "Rajeshh");
        // directory.Add(209, "Sureshh");

        // foreach(KeyValuePair<int, string> key in directory)
        // {
        //     Console.WriteLine($"Key is {key.key} value is {key.Value}");
        // }

        // SortedList<string, string> pairs = new SortedList<string, string>();
        // pairs.Add("100", "Rajesh");
        // pairs.Add("200", "Suresh");
        // pairs.Add("300", "Rakesh");

        // Console.WriteLine("\n\n\n Generic Sorted List");
        // foreach(KeyValuePair<string, string> Key in pairs)
        // {
        //     Console.WriteLine($"Key is {Key.key} value is {Key.Value}");
        // }


        // MyCollection obj = new MyCollection();
        // foreach(int i in obj)
        // {
        //     Console.WriteLine(i);
        // }

        Assignment assignment=new Assignment();

        double productAverage;
        // assignment.Problem1(out productAverage);

        int n;
        int[,] matrix;
        // assignment.Problem2(out n,out matrix);
        // assignment.Problem3(n,matrix);
        // assignment.Problem4();
        // assignment.Problem5(productAverage);
        // assignment.Problem6();
        assignment.Problem7();

    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class MyCollection : IEnumerable
{
    int[] data = {1,2,3};
    public IEnumerator GetEnumerator()
    {
        return data.GetEnumerator();
    }

}