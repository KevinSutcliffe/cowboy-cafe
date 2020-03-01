using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Constrcutor
        /// </summary>
        public Order()
        {
            lastOrderNumber += 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Order number
        /// </summary>
        private static uint lastOrderNumber = 0;

        /// <summary>
        /// list of items for the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// list of items for the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        /// <summary>
        /// Cost of the order
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
        /// Adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
