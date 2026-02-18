using System;

namespace Exceptions
{
    public class InventoryExceptions : Exception
    {
        public InventoryExceptions(string message) : base(message) { }
    }
}
