using System;
using System.Runtime.InteropServices.Marshalling;

public class Assignment6
{
    public static void Main(string[] args){

        Console.WriteLine("1. Desktop\n2. Laptop");
        Console.Write("Choose an option: ");
        int choice = int.Parse(Console.ReadLine());
        if(choice == 1)
        {
            Desktop desktop = new Desktop();
            Console.Write("Enter the processor: ");
            desktop.Processor = Console.ReadLine();
            Console.Write("Enter the Ram size: ");
            desktop.RamSize = int.Parse(Console.ReadLine());
            Console.Write("Enter the hard disk size: ");
            desktop.HardDiskSize = int.Parse(Console.ReadLine());
            Console.Write("Enter the graphic card size: ");
            desktop.GraphicCard = int.Parse(Console.ReadLine());
            Console.Write("Enter the moniter size: ");
            desktop.MoniterSize = int.Parse(Console.ReadLine());
            Console.Write("Enter the power supply volt: ");
            desktop.PowerSupplyVolt = int.Parse(Console.ReadLine());

            Console.WriteLine($"Desktop price is {desktop.DesktopPriceCalculation()}");

        }
        else if(choice == 2)
        {
            Laptop laptop = new Laptop();
            Console.Write("Enter the processor: ");
            laptop.Processor = Console.ReadLine();
            Console.Write("Enter the Ram size: ");
            laptop.RamSize = int.Parse(Console.ReadLine());
            Console.Write("Enter the hard disk size: ");
            laptop.HardDiskSize = int.Parse(Console.ReadLine());
            Console.Write("Enter the graphic card size: ");
            laptop.GraphicCard = int.Parse(Console.ReadLine());
            Console.Write("Enter the moniter size: ");
            laptop.DisplaySize = int.Parse(Console.ReadLine());
            Console.Write("Enter the power supply volt: ");
            laptop.BatteryVolt = int.Parse(Console.ReadLine());

            Console.WriteLine($"Desktop price is {laptop.LaptopPriceCalculation()}");
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }

    }
}

class Computer
{
    public string Processor { get; set; }
    public int RamSize { get; set; }
    public int HardDiskSize { get; set; }
    public int GraphicCard { get; set; }
}

class Desktop : Computer
{
    public int MoniterSize { get; set; }    
    public int PowerSupplyVolt { get; set; }

    public double DesktopPriceCalculation()
    {
        double ramPrice = 200, hardDiskPrice = 1500,
        graphicCardPrice = 2500, powerSupplyVoltPrice = 20,
        moniterPrice = 250 ;

        double processorPrice = 0;
        switch (Processor)
        {
            case "i3":
                processorPrice = 1500;
                break;
            case "i5":
                processorPrice = 3000;
                break;
            case "i7":
                processorPrice = 4500;
                break;
            default:
                break;
        }
        double price = processorPrice + (RamSize * ramPrice)
        + (HardDiskSize * hardDiskPrice)
        +(GraphicCard * graphicCardPrice)
        + (MoniterSize * moniterPrice) 
        + (PowerSupplyVolt * powerSupplyVoltPrice);

        return price;
    }    
}

class Laptop : Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }

    public double LaptopPriceCalculation()
    {
        double ramPrice = 200, hardDiskPrice = 1500 ,
        graphicCardPrice = 2500 , batteryVoltPrice = 20 ,
        displayPrice = 250 ;

        double processorPrice = 0;
        switch (Processor)
        {
            case "i3":
                processorPrice = 2500;
                break;
            case "i5":
                processorPrice = 5000;
                break;
            case "i7":
                processorPrice = 6500;
                break;
            default:
                break;
        }
        double price = processorPrice + (RamSize * ramPrice)
        + (HardDiskSize * hardDiskPrice)
        +(GraphicCard * graphicCardPrice)
        + (DisplaySize * displayPrice) 
        + (BatteryVolt * batteryVoltPrice);

        return price;
        
    }
}