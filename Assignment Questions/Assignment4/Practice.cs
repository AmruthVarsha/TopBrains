using System;

public class Practice
{
    public void PrintArray()
    {
        int[] arr=new int[10];
        Console.WriteLine("Input 10 elements in the array: ");
        for(int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i]=int.Parse(Console.ReadLine());
        }
        Console.Write("Elements in Array are: ");
        for(int i = 0; i < 10; i++)
        {
            Console.Write(arr[i]+" ");
        }
    }

    public void PrintReverse()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("The values store into the array are: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(arr[i]+" ");
        }
        Console.Write("\nThe values store into the array in reverse are: ");
        for(int i = n - 1; i >= 0; i--)
        {
            Console.Write(arr[i]+" ");
        }


    }

    public void ArraySum()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        int sum=0;
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
            sum+=arr[i];
        }
        Console.WriteLine($"Sum of all elements stored in the array is: {sum}");

    }

    public void CopyArray()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int[] arr1=arr.ToArray();
        // arr1[1]=5;
        Console.Write("The elements stored in the first array are: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(arr[i]+" ");
        }
        Console.Write("\nThe elements copied into the second array are: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(arr1[i]+" ");
        }
    }

    public void Duplicate()
    {
        HashSet<int> set=new HashSet<int>();
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int count=0;
        int[] arr = new int[n];
        // for(int i = 0; i < n; i++)
        // {
        //     int temp=int.Parse(Console.ReadLine());
        //     if(set.Contains(temp)) count++;
        //     set.Add(temp);
        // }

        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < n-1; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                if(arr[i] == arr[j])
                {
                    count++;
                    break;
                }
            }
        }



        Console.WriteLine(count);
    }

    public void PrintUnique()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < n; i++)
        {
            bool temp=true;
            for(int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }
                else if (arr[i] == arr[j])
                {
                    temp=false;
                }

            }
            if (temp)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }

    public void MergeAndSort()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        int[] arr1=new int[n];
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr1[i] = int.Parse(Console.ReadLine());
        }

        int[] arr2 = new int[n+n];

        for(int i = 0,k=0; i < n; i++)
        {
            arr2[k++]=arr[i];
            arr2[k++]=arr1[i];
        }
        for(int i = 0; i < n +n - 1 ; i++)
        {
            for(int j = 0; j < n + n - i - 1; j++)
            {
                if (arr2[j]>arr2[j+1])
                {
                    int temp=arr2[j+1];
                    arr2[j+1]=arr2[j];
                    arr2[j]=temp;
                }
            }
        }


        for(int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i]+" ");
        }
    }



    public void Frequency()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        bool[] visited = new bool[n];
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < n-1; i++)
        {
            if(visited[i]) continue;

            int count=1;
            for(int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j]=true;
                }
            }
            Console.WriteLine($"The frequency of {arr[i]} is {count}");
        }
        
    }


    public void MinMax()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        int min=int.MaxValue,max=int.MinValue;
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
            min=Math.Min(min,arr[i]);
            max=Math.Max(max,arr[i]);
        }

        Console.WriteLine($"Max element is {max} and min element is {min}");
    }

    public void EvenOdd()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        int oddlen=0,evenlen=0;
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] % 2 == 0)
            {
                evenlen++;
            }
            else
            {
                oddlen++;
            }
        }
        int[] odd = new int[oddlen];
        int[] even = new int[evenlen];
        for(int i = 0,k=0,l=0; i < n; i++)
        {
            if (arr[i] % 2 == 0)
            {
                even[k++]=arr[i];
            }
            else
            {
                odd[l++]=arr[i];
            }
        }
        Console.WriteLine("Evn Elements are: ");
        for(int i = 0; i < evenlen; i++)
        {
            Console.Write(even[i]+" ");
        }
        Console.WriteLine("Odd Elements are: ");
        for(int i = 0; i < oddlen; i++)
        {
            Console.Write(odd[i]+" ");
        }
    }

    public void AscSort()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < n - 1; i++)
        {
            int min=i;

            for(int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min])
                {
                    min=j;
                }
            }
            int temp=arr[min];
            arr[min]=arr[i];
            arr[i]=temp;
        }

        Console.Write("\nElements of array in sorted ascending order: ");

        for(int i = 0; i < n; i++)
        {
            Console.Write(arr[i]+" ");
        }
    }

    public void DescSort()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Element {i} - ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < n - 1; i++)
        {
            int max=i;

            for(int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[max])
                {
                    max=j;
                }
            }
            int temp=arr[max];
            arr[max]=arr[i];
            arr[i]=temp;
        }

        Console.Write("\nElements of the array in sorted descending order: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(arr[i]+" ");
        }
    }


    public void SortedInsert()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n+1];
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int j = 0; j < n; j++)
        {
            Console.Write($"Element {j} - ");
            arr[j] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the element to insert: ");
        int ele=int.Parse(Console.ReadLine()),i=n-1;

        Console.Write("\nThe exist array list is : ");
        for(i = 0; i < n; i++)
        {
            Console.Write(arr[i]+" ");
        }

        while(i >=0 && arr[i]>ele)
        {
            arr[i+1]=arr[i];
            i--;
        }

        arr[i+1]=ele;
        n++;
        Console.Write("\nAfter Insert the list is: ");
        for(i = 0; i < n; i++)
        {
            Console.Write(arr[i]+" ");
        }

    }

    public void UnsortedInsert()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n+1];
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int j = 0; j < n; j++)
        {
            Console.Write($"Element {j} - ");
            arr[j] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the element to insert: ");
        int ele=int.Parse(Console.ReadLine());

        Console.Write("Input the Position, where the value to be inserted: ");
        int pos = int.Parse(Console.ReadLine());


        for(int i = n - 1; i >= pos-1; i--)
        {
            arr[i+1]=arr[i];
        }
        arr[pos-1]=ele;

        for(int i = 0; i < n+1; i++)
        {
            Console.Write(arr[i]+" ");
        }
    }

    public void DeleteEle()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        Console.WriteLine($"Input {n} number of elements in the array: ");
        for(int j = 0; j < n; j++)
        {
            Console.Write($"Element {j} - ");
            arr[j] = int.Parse(Console.ReadLine());
        }

        Console.Write("Input the position where to delete: ");
        int pos = int.Parse(Console.ReadLine());

        for(int i = pos - 1; i < n-1; i++)
        {
            arr[i]=arr[i+1];
        }

        for(int i = 0; i < n-1; i++)
        {
            Console.Write(arr[i]+" ");
        }
    }

}