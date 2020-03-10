/*

* Author: Kevin Sutcliffe

* Class name: Angry Chicken

* Purpose: Creates the angry chicken entree object

*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken : Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// If the entree should be served with a pickle
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get { return pickle; }
            set 
            { 
                pickle = value;
                NotifyOfPropertyChange("Bread");
            }
        }

        /// <summary>
        /// If the entree should be served with bread
        /// </summary>
        private bool bread = true;
        public bool Bread
        {
            get { return bread; }
            set 
            { 
                bread = value;
                NotifyOfPropertyChange("Bread");
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if(!Bread) { instructions.Add("hold bread");  }
                if(!Pickle) { instructions.Add("hold pickle"); }
                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the angry chicken</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
