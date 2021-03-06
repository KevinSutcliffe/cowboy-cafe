﻿using System;
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
            orderNumber += 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private static uint orderNumber = 0;
        /// <summary>
        /// Order number
        /// </summary>
        public uint OrderNumber 
        { get { return orderNumber; } private set { orderNumber = value;  } }

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
        /// Cost of the order including the sales tax
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal * 1.16;
            }
        }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
            OnItemPropertyChanged();
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item) 
        {
            
            items.Remove(item);
            OnItemPropertyChanged();
        }

        /// <summary>
        /// Updates the items and subtotal
        /// </summary>
        public void OnItemPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        }
    }
}
