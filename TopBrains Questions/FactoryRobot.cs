using System;

public class RobotHazardAuditor
{
    public double CalculateHazardRisk(double armPrecision, int WorkerDensity, string machineryState)
    {
        if(armPrecision < 0.0 || armPrecision > 1.0)
        {
            throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
        }
        if(WorkerDensity <1 || WorkerDensity > 20)
        {
            throw new RobotSafetyException("Error: Worker density must be 1-20");
        }
        if(!machineryState.Equals("Worn") && !machineryState.Equals("Faulty") && !machineryState.Equals("Critical"))
        {
            throw new RobotSafetyException("Error: Unsupported machinery state");
        }
        double riskFactor=0;
        switch (machineryState)
        {
            case "Worn":
                riskFactor = 1.3;
                break;
            case "Faulty":
                riskFactor = 2.0;
                break;
            case "Critical":
                riskFactor = 3.0;
                break;
            default:
                break;
        }
        double hazardRisk = ((1.0 - armPrecision) * 15.0)+(WorkerDensity * riskFactor);
        return hazardRisk;


    }
}

public class RobotSafetyException : Exception
{
    public RobotSafetyException(string message): base(message)
    {
        
    }


}


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
        double armPrecision = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Worker Density (1 - 20):");
        int workerDensity = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
        string machineryState = Console.ReadLine();

        RobotHazardAuditor robotHazardAuditor = new RobotHazardAuditor();
        try
        {
            Console.WriteLine($"Robot Hazard Risk Score: {robotHazardAuditor.CalculateHazardRisk(armPrecision,workerDensity,machineryState)}");
        }
        catch(RobotSafetyException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}