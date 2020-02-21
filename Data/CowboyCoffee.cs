using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public new Size Size;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// If the drink should be served with ice 
        /// </summary>
        private bool ice = false;
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// If the drink should be served with cream
        /// </summary>
        private bool cream = false;
        public bool RoomForCream
        {
            get { return cream; }
            set { cream = value; }
        }

        private bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (ice) { instructions.Add("Add Ice"); }
                if (cream) { instructions.Add("Room for Cream"); }
                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing cowboy coffee</returns>
        public override string ToString()
        {
            if (decaf)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Decaf Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Decaf Cowboy Coffee";
                    case Size.Large:
                        return "Large Decaf Cowboy Coffee";
                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Cowboy Coffee";
                    case Size.Large:
                        return "Large Cowboy Coffee";
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
