namespace Domain
{
    public abstract class Product
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public int PriorityLevel { get; set; }
        public int Stock { get; set; }
        public int Threshold { get; set; }

        public virtual bool Validate()
        {
            if(SKU==string.Empty || SKU == null)
            {
                return false;
            }
            else if(Name==null || Name == string.Empty)
            {
                return false;
            }
            else if(PriorityLevel<1 || PriorityLevel > 10)
            {
                return false;
            }
            else if (Stock < 0)
            {
                return false;
            }
            else if (Threshold < 0)
            {
                return false;
            }
            return true;
        } // TODO: Implement validation
    }

    public class Electronics : Product
    {
        public string Brand {get; set;}

        public override bool Validate()
        {
            return base.Validate();
        }

    }

    public class Perishable : Product
    {
        public DateTime ExpiryDate {get; set;}

        public override bool Validate()
        {
            return base.Validate();
        }

    }

    public class FragileItem : Product
    {
        public string FragilityLevel {get; set;}

        public override bool Validate()
        {
            return base.Validate();
        }

    }
}



