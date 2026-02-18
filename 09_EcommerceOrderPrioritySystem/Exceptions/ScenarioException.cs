namespace Exceptions
{
    public class  LowStockException: InventoryExceptions
    {
        public LowStockException(string message) : base(message) { }
    }
    public class  DuplicateSKUException : InventoryExceptions
    {
        public DuplicateSKUException (string message) : base(message) { }
    }
    public class  InvalidProductException : InventoryExceptions
    {
        public InvalidProductException (string message) : base(message) { }
    }
}
