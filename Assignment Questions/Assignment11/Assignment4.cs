using System;
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

public class Assignment4
{

    public static ArrayList list = new ArrayList();
    public static void Main(string[] args)
    {
        int memberId,age;
        double weight,height;
        string goal;

        memberId = int.Parse(Console.ReadLine());
        age = int.Parse(Console.ReadLine());
        weight = double.Parse(Console.ReadLine());
        height = double.Parse(Console.ReadLine());
        goal = Console.ReadLine();

        Assignment4 assignment4 =new Assignment4();

        assignment4.AddYogaMember(memberId,age,weight,height,goal);
        foreach(MeditationCentre i in list)
        {
            i.BMI = assignment4.CalculateBMI(i.MemberId);
            Console.WriteLine(i.BMI);
        }
        
        Console.WriteLine(assignment4.CalculateYogaFee(memberId));
        
    }

    public void AddYogaMember(int memberId, int age, double weight, double height, string goal)
    {
        MeditationCentre member = new MeditationCentre
        {
            MemberId = memberId,
            Age = age,
            Weight = weight,
            Height = height,
            Goal = goal
        };
        list.Add(member);
    }

    public double CalculateBMI(int memberId)
    {
        foreach(MeditationCentre member in list)
        {
            if(member.MemberId == memberId)
            {
                return member.Weight/(member.Height*member.Height);
            }
        }
        return 0;
    }

    public int CalculateYogaFee(int memberId)
    {
        foreach(MeditationCentre member in list)
        {
            if(member.MemberId == memberId)
            {
                if(member.Goal.Equals("Weight Gain"))
                {
                    return 2500;
                }
                else
                {
                    if(member.BMI >=25 && member.BMI < 30)
                    {
                        return 2000;
                    }
                    else if(member.BMI >=30 && member.BMI < 35)
                    {
                        return 2500;
                    }
                    else if(member.BMI >=35)
                    {
                        return 3000;
                    } 
                }
            }
        }
        return 0;
    }
}

public class MeditationCentre
{
    public int MemberId { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string Goal { get; set; }
    public double BMI { get; set; }
}