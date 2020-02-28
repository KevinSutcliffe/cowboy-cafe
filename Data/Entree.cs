/*

* Author: Nathan Bean

* Edited by: Kevin Sutcliffe

* Class name: Entree

* Purpose: Abstract class that will be used in each entree class

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a entree
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the preparation of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
