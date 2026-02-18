using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;

class Assesment
{
    public void Problem1()
    {
        string str=Console.ReadLine();
        Console.WriteLine(str);
    }

    public void Problem2()
    {
        string[] str=new string[10];
        for(int i = 0; i < 10; i++)
        {
            str[i]=Console.ReadLine();
        }
        Console.WriteLine("\n\n");
        foreach(string i in str){
            Console.WriteLine(i);
        }
    }

    public void Problem3()
    {
        int[,] matrix = new int[2,2];
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                matrix[i,j]=int.Parse(Console.ReadLine());
            }
        }

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }

        
    }

    public void Problem4()
    {
        Console.Write("Enter n for 2 nXn matrixes: ");
        int n=int.Parse(Console.ReadLine());
        int[,] matrix1 = new int[n,n];
        int[,] matrix2= new int[n,n];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                matrix1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                matrix2[i,j]=int.Parse(Console.ReadLine());
            }
        }

        int[,] res = new int[n,n];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                res[i,j]=matrix1[i,j]+matrix2[i,j];
            }
        }

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write(res[i,j]+" ");
            }
            Console.WriteLine();
        }
    }

    public void Problem5()
    {
        Console.Write("Enter the number of elements: ");
        int n=int.Parse(Console.ReadLine());
        int min=int.MaxValue,max=int.MinValue;
        int[] arr=new int[n];
        for(int i = 0; i < n; i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
            min=Math.Min(min,arr[i]);
            max=Math.Max(max,arr[i]);
        }

        Console.WriteLine($"Smalled element is {min} and largest element is {max}");
    }


    public void Problem6()
    {
        Console.Write("Enter n for 2 nXn matrixes: ");
        int n=int.Parse(Console.ReadLine());
        int[,] matrix1 = new int[n,n];
        int[,] matrix2= new int[n,n];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                matrix1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                matrix2[i,j]=int.Parse(Console.ReadLine());
            }
        }

        int[,] res = new int[n,n];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                for(int k=0;k<n;k++){
                    res[i,j]+=matrix1[i,k]+matrix2[k,j];
                }
            }

        }

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write(res[i,j]+" ");
            }
            Console.WriteLine();
        }
        
    }
    public void Problem7(){
        Console.Write("Enter n for an nXn matrixes: ");
        int n=int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                matrix[i,j]=int.Parse(Console.ReadLine());
            }
        }

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                int temp=matrix[i,j];
                matrix[i,j]=matrix[j,i];
                matrix[j,i]=temp;
            }
        }

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }   
    }

    public void Problem8()
    {
        Console.Write("Enter n for 2 nXn matrixes: ");
        int n=int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                matrix[i,j]=int.Parse(Console.ReadLine());
            }
        }

        bool res = true;

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(i!=j && matrix[i, j] != 0)
                {
                    res = false;
                }
                else
                {
                    continue;
                }
            }
        }
        Console.WriteLine("Matrix is a diagonal matrix?? : "+res);

    }


    public void Problem9()
    {
        string str=Console.ReadLine();
        char[] chars=str.ToCharArray();
        Array.Reverse(chars);
        string res=new string(chars);
        Console.WriteLine(res);
    }

    public void Problem10()
    {
        string str=Console.ReadLine();
        string res=string.Empty;
        for(int i = 0; i < str.Length; i++)
        {
            res= res+str[str.Length-1-i];
        }
        Console.WriteLine(res);
    }

    public void Problem11()
    {
        string str=Console.ReadLine();
        string res;
        if (str.ToLower().Equals(str))
        {
            res=str.ToUpper();
        }
        else
        {
            res=str.ToLower();            
        }
        Console.WriteLine(res);
    }

    public void Problem12()
    {
        string str=Console.ReadLine();
        string res=string.Empty;
        if (str.ToLower().Equals(str))
        {
            for(int i = 0; i < str.Length; i++)
            {
                char c=str[i];
                res = res+(char)((int)c-32);
            }
        }
        else
        {
            for(int i = 0; i < str.Length; i++)
            {
                res = res+ (char)((int)str[i]+32);
            }
        }
        Console.WriteLine(res);
    }

    public void Problem13()
    {
        string str1=Console.ReadLine();
        string str2=Console.ReadLine();

        if (string.Compare(str1, str2)==0) //str1.Equals(str2) also works.
        {
            Console.WriteLine($"The strings {str1} and {str2} are same");
        }
        else
        {
            Console.WriteLine($"The strings {str1} and {str2} are not same");
        }
    }

    public void Problem14()
    {
        string str1=Console.ReadLine();
        string str2=Console.ReadLine();
        bool res=true;

        if (str1.Length != str2.Length)
        {
            Console.WriteLine($"The string {str1} and {str2} are not same");
        }
        for(int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                res=false;
                break;
            }
        }
        if (res)
        {
            Console.WriteLine($"The string {str1} and {str2} are same");
        }
        else
        {
            Console.WriteLine($"The string {str1} and {str2} are not same");
        }
    }

    public void Problem15()
    {
        string str1=Console.ReadLine();
        string str2=Console.ReadLine();
        string str3=string.Concat(str1," ",str2);
        Console.WriteLine(str3);
    }

    public void Problem16()
    {
        string str1=Console.ReadLine();
        string str2=Console.ReadLine();
        string str3=str1+" "+str2;
        Console.WriteLine(str3);
    }

    public void Problem17()
    {
        string str=Console.ReadLine();
        string substr=Console.ReadLine();
        if (str.Contains(substr))
        {
            Console.WriteLine($"String {str} contains substring {substr}");
        }
        else
        {
            Console.WriteLine($"String {str} does not contain substring {substr}");
        }
    }
}