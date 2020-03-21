using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// If the drink should be served with ice 
        /// </summary>
        private bool ice = true;
        public override bool Ice
        {
            get { return ice; }
            set 
            { 
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        /// <summary>
        /// If the drink should be served with lemon 
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set 
            { 
                lemon = value;
                NotifyOfPropertyChange("Lemon");
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!ice) { instructions.Add("Hold Ice"); }
                if (lemon) { instructions.Add("Add Lemon"); }
                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing texas tea</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Large:
                    return "Large Water";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
