/*

* Author: Kevin Sutcliffe

* Class name: Drink

* Purpose: Abstract class that will be used in each drink class

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets if the drink should have ice
        /// </summary>
        public virtual bool Ice { get; set; }
    }
}
