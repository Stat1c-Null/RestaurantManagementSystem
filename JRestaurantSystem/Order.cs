using System.Collections.Generic;

namespace JRestaurantSystem
{
    public class Order
    {
        public int TableNumber { get; set; }
        public string WaiterName { get; set; }
        public List<string> Items { get; set; }

        public Order(int tableNumber, string waiterName, List<string> items)
        {
            TableNumber = tableNumber;
            WaiterName = waiterName;
            Items = items;
        }

        public override string ToString()
        {
            string itemsList = string.Join(", ", Items);
            return $"Table: {TableNumber} | Waiter: {WaiterName} | Items: {itemsList}";
        }
    }
}