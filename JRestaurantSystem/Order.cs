using System.Collections.Generic;

namespace JRestaurantSystem
{
    public class Order
    {
        public string TableNumber { get; set; }
        public string WaiterName { get; set; }
        public List<string> Items { get; set; }

        /// <summary>
        /// Constructor to initialize an Order with table number, waiter name, and list of items
        /// </summary>
        /// <param name="tableNumber">table #</param>
        /// <param name="waiterName">Waiter name</param>
        /// <param name="items">List of items ordered</param>
        public Order(string tableNumber, string waiterName, List<string> items)
        {
            TableNumber = tableNumber;
            WaiterName = waiterName;
            Items = items;
        }

        /// <summary>
        /// Returns a format in the kitchenForms to show the details of order
        /// </summary>
        /// <returns>string that has the table number, waiter name, and ordered items</returns>
        public override string ToString()
        {
            string itemsList = string.Join(", ", Items);
            return $"Table: {TableNumber} | Waiter: {WaiterName} | Items: {itemsList}";
        }
    }
}