using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
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
                if (sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        /// <summary>
        /// If the drink should be served with sweetener
        /// </summary>
        private bool sweet = true;
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        /// <summary>
        /// If the drink should be served with ice 
        /// </summary>
        private bool ice = true;
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// If the drink should be served with lemon 
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
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
    }
}
