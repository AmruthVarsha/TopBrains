using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(String[] args)
    {
        // string fname,lname;
        // fname = "Roman";
        // lname = "Atkinson";
        // fname = "Rowan";

        // string fullname = fname+" "+lname;
        // Console.WriteLine(fullname);

        // char[] chars = {'H','E','L','L','O'};
        // string[] sarray = {"Hello","From","Tutorial","Point"};

        // string s=new string(chars);
        // string s1=string.Join(" ",sarray);

        // Console.WriteLine(s+"\n"+s1);

        // DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 20);
        // string chat = string.Format("Message sent at {0:t} on {0:D}",waiting);
        // Console.WriteLine("Message: {0}",chat);


        // string str1 = "This is text";
        // string str2 = "This is test";

        // if (string.Compare(str1, str2) == 0)
        // {
        //     Console.WriteLine(str1 + " and "+str2+" are equal.");
        // }
        // else
        // {
        //     Console.WriteLine(str1+" and "+str2+" are not equal.");
        // }

        // if (str1.Contains("test"))
        // {
        //     Console.WriteLine(str1+" Contains test");
        // }
        // else
        // {
        //     Console.WriteLine(str1+" does not contain test");
        // }


        // string str3 = "Last night i dreamt of san pedro";
        // Console.WriteLine(str3);
        // string substr = str3.Substring(23,5);
        // Console.WriteLine(substr);

        // Console.WriteLine("\"Hello World\"");
        // Console.WriteLine("\\program:\\cs\\Dec30Day9");
        // Console.WriteLine(@"\program:\cs\Dec30Day9");

        // string message = @"Hello Alice,
                            
        //                     Good Morning!
                            
        //                     Your Files have been saved to this location
        //                     \shared\alice
                             
        //                     Thanks.";

        // Console.WriteLine(message);

        // var name = "Alice";

        // var greeting = string.Format("Hello {0} {1}!",name,"good morning");

        // Console.WriteLine(greeting);

        // string csv = "Alice,Bob,Chris,Dave,Eric,Fred";

        // string[] arr = csv.Split(",");
        // foreach(string i in arr)
        // {
        //     Console.WriteLine(i);
        // }

        // string greet = "Hello Alice, Welcome";
        // int index = greet.IndexOf("el");
        // Console.WriteLine(index);


        // int[][] jaggedArray = new int[4][];

        // jaggedArray[0] = new int[]{1,2,3,4};
        // jaggedArray[1] = new int[]{1,2};
        // jaggedArray[2] = new int[]{1,2,3,4,5,6};
        // jaggedArray[3] = new int[]{1,2,3};

        // for(int i = 0; i < jaggedArray.Length; i++)
        // {
        //     for(int j = 0; j < jaggedArray[i].Length; j++)
        //     {
        //         Console.Write(jaggedArray[i][j]+" ");
        //     }
        //     Console.WriteLine();
        // }

        Assesment assesment = new Assesment();
        assesment.Problem1();
        assesment.Problem2();
        assesment.Problem3();
        assesment.Problem4();
        assesment.Problem5();
        assesment.Problem6();
        assesment.Problem7();
        assesment.Problem8();
        assesment.Problem9();
        assesment.Problem10();
        assesment.Problem11();
        assesment.Problem12();
        assesment.Problem13();
        assesment.Problem14();
        assesment.Problem15();
        assesment.Problem16();
        assesment.Problem17();

    }
}