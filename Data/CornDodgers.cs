﻿/*

* Author: Kevin Sutcliffe

* Class name: Corn Dodgers

* Purpose: Creates the corn dodgers side object

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CornDodgers : Side
    {
        /// <summary>
        /// Gets the price of the side
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
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the corn dodgers</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Corn Dodgers";
                case Size.Medium:
                    return "Medium Corn Dodgers";
                case Size.Large:
                    return "Large Corn Dodgers";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
