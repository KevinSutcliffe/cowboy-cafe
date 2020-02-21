using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public new Size Size;

        /// <summary>
        /// Flavor of the drink
        /// </summary>
        public SodaFlavor SodaFlavor;

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
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
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
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the flavor of the drink
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                switch (SodaFlavor)
                {
                    case SodaFlavor.CreamSoda:
                        return SodaFlavor.CreamSoda;
                    case SodaFlavor.OrangeSoda:
                        return SodaFlavor.OrangeSoda;
                    case SodaFlavor.Sarsparilla:
                        return SodaFlavor.Sarsparilla;
                    case SodaFlavor.BirchBeer:
                        return SodaFlavor.BirchBeer;
                    case SodaFlavor.RootBeer:
                        return SodaFlavor.RootBeer;
                    default:
                        throw new NotImplementedException();
                }
            }
            set
            {
                SodaFlavor = value;
            }
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
        /// Special instructions for the preparation of the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!ice) { instructions.Add("Hold Ice"); }
                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing jerked soda</returns>
        public override string ToString()
        {
            if (SodaFlavor == SodaFlavor.CreamSoda)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Cream Soda Jerked Soda";
                    case Size.Medium:
                        return "Medium Cream Soda Jerked Soda";
                    case Size.Large:
                        return "Large Cream Soda Jerked Soda";
                    default:
                        throw new NotImplementedException();
                }
            }
            else if(SodaFlavor == SodaFlavor.OrangeSoda)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Orange Soda Jerked Soda";
                    case Size.Medium:
                        return "Medium Orange Soda Jerked Soda";
                    case Size.Large:
                        return "Large Orange Soda Jerked Soda";
                    default:
                        throw new NotImplementedException();
                }
            }
            else if(SodaFlavor == SodaFlavor.Sarsparilla)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Sarsparilla Jerked Soda";
                    case Size.Medium:
                        return "Medium Sarsparilla Jerked Soda";
                    case Size.Large:
                        return "Large Sarsparilla Jerked Soda";
                    default:
                        throw new NotImplementedException();
                }
            }
            else if(SodaFlavor == SodaFlavor.BirchBeer)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Birch Beer Jerked Soda";
                    case Size.Medium:
                        return "Medium Birch Beer Jerked Soda";
                    case Size.Large:
                        return "Large Birch Beer Jerked Soda";
                    default:
                        throw new NotImplementedException();
                }
            }
            else 
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Root Beer Jerked Soda";
                    case Size.Medium:
                        return "Medium Root Beer Jerked Soda";
                    case Size.Large:
                        return "Large Root Beer Jerked Soda";
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
