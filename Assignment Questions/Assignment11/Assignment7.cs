using System;

public class Assignment7
{
    public static void Main(string[] args)
    {
        float constructionArea = float.Parse(Console.ReadLine());
        float siteArea = float.Parse(Console.ReadLine());
        Assignment7 assignment7 = new Assignment7();
        try
        {
            EstimateDetails obj = assignment7.ValidateConstructionEstimate(constructionArea,siteArea);
        }
        catch(ConstructionEstimateException e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine("Construction Estimate Successfull");
    }

    public EstimateDetails ValidateConstructionEstimate(float constructionArea, float siteArea)
    {
        if (constructionArea > siteArea)
        {
            throw new ConstructionEstimateException("Sorry your Construction Estimate is not approved.");
        }


        return new EstimateDetails
        {
            ConstructionArea = constructionArea,
            SiteArea = siteArea
        };
    }
}

public class ConstructionEstimateException : Exception
{
    public ConstructionEstimateException(string Message) : base(Message)
    {
        
    }
}
public class EstimateDetails
{
    public float ConstructionArea { get; set; }
    public float SiteArea { get; set; }
}