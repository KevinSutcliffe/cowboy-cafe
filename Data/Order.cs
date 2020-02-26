using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : IOrderItem
    {
        /// <summary>
        /// Order number
        /// </summary>
        private uint lastOrderNumber;

        /// <summary>
        /// list of items for the order
        /// </summary>
        private List<IOrderItem> items;

        /// <summary>
        /// list of items for the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items; } }

        /// <summary>
        /// 
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0;
                foreach(var item in items)
                {
                    total += item.Price;
                }
                return total;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Price => throw new NotImplementedException();

        /// <summary>
        /// special instructions for the order
        /// </summary>
        public List<string> SpecialInstructions => throw new NotImplementedException();

        public void Add(IOrderItem item) { }

        public void Remove(IOrderItem item) { }
    }
}
