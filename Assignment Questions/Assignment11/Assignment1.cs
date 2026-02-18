class Assignment1
{
    public static SortedDictionary<string,long> itemDetails;
    public static void Main()
    {
        itemDetails = new SortedDictionary<string, long>();
        Console.WriteLine("Enter number of items to the list:");
        int items = int.Parse(Console.ReadLine());
        string itemName;
        long count;
        for (int i = 0; i < items; i++)
        {
            Console.WriteLine($"Enter the {i+1} item name: ");
            itemName = Console.ReadLine();
            Console.WriteLine("Enter sold count:");
            count = long.Parse(Console.ReadLine());
            itemDetails.Add(itemName,count);
            
        }
        Assignment1 assignment1 = new Assignment1();
        Console.WriteLine("Enter Operations to perform\n1.Find item by sold count\n2.Find minimum and maximum sold items\n3.Sort items by sold count");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
            Console.WriteLine("Enter Sold count to search: ");
            long soldCount = long.Parse(Console.ReadLine());
            SortedDictionary<string,long> newDic = assignment1.FindItemDetails(soldCount);
                if (newDic.Count == 0)
                {
                    Console.WriteLine("Invalid sold count");
                }
                else
                {
                    foreach(var i in newDic)
                    {
                        Console.WriteLine($"{i.Key} {i.Value}");
                    }
                }
            break;
            case 2:
            List<string> result = assignment1.FindMinandMaxSoldItems();
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            break;
            case 3:
            Dictionary<string,long> sortedList = assignment1.SortByCount();
            foreach(var i in sortedList)
                {
                    Console.WriteLine($"{i.Key} {i.Value}");
                }
            break;
            default:
            Console.WriteLine("Invalid choice");
            break;

        }
    }
    public  SortedDictionary<string,long> FindItemDetails(long soldCount)
    {
        SortedDictionary<string,long> newDic = new SortedDictionary<string, long>();
        foreach(var i in itemDetails)
            {
                if (i.Value ==soldCount)
                {            
                    newDic.Add(i.Key,i.Value);
                }
            }
            return newDic;
    }
    public List<string> FindMinandMaxSoldItems()
    {
        List<string> result = new List<string>();
        long minSold = itemDetails.Values.Min();
        long maxSold = itemDetails.Values.Max();
        string minItem = itemDetails.First(i=>i.Value == minSold).Key;
        string maxItem = itemDetails.First(i=>i.Value == maxSold).Key;
        result.Add(minItem);
        result.Add(maxItem);
        return result;
    }
    public Dictionary<string,long> SortByCount()
    {
        Dictionary<string, long> sortedDict = new Dictionary<string, long>();

        foreach (var item in itemDetails.OrderBy(i => i.Value))
        {
            sortedDict.Add(item.Key, item.Value);
        }

        return sortedDict;
    }
}