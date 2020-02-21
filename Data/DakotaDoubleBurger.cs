/*

* Author: Kevin Sutcliffe

* Class name: Dakota Double Burger

* Purpose: Creates the dakota double burger entree object

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger: Entree
	{
		/// <summary>
		/// The price of the entree
		/// </summary>
		public override double Price
		{
			get
			{
				return 5.20;
			}
		}

		/// <summary>
		/// The calories of the entree
		/// </summary>
		public override uint Calories
		{
			get
			{
				return 464;
			}
		}

		/// <summary>
		/// If the entree should be served with a bun
		/// </summary>
		private bool bun = true;
		public bool Bun
		{
			get { return bun; }
			set { bun = value; }
		}

		/// <summary>
		/// If the entree should be served with ketchup
		/// </summary>
		private bool ketchup = true;
		public bool Ketchup
		{
			get { return ketchup; }
			set { ketchup = value; }
		}

		/// <summary>
		/// If the entree should be served with mustard
		/// </summary>
		private bool mustard = true;
		public bool Mustard
		{
			get { return mustard; }
			set { mustard = value; }
		}

		/// <summary>
		/// If the entree should be served with pickle
		/// </summary>
		private bool pickle = true;
		public bool Pickle
		{
			get { return pickle; }
			set { pickle = value; }
		}

		/// <summary>
		/// If the entree should be served with ketchup
		/// </summary>
		private bool cheese = true;
		public bool Cheese
		{
			get { return cheese; }
			set { cheese = value; }
		}

		/// <summary>
		/// If the entree should be served with tomato
		/// </summary>
		private bool tomato = true;
		public bool Tomato
		{
			get { return tomato; }
			set { tomato = value; }
		}

		/// <summary>
		/// If the entree should be served with tomato
		/// </summary>
		private bool lettuce = true;
		public bool Lettuce
		{
			get { return lettuce; }
			set { lettuce = value; }
		}

		/// <summary>
		/// If the entree should be served with tomato
		/// </summary>
		private bool mayo = true;
		public bool Mayo
		{
			get { return mayo; }
			set { mayo = value; }
		}

		/// <summary>
		/// List of instructions for the entree
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get
			{
				List<string> instructions = new List<string>();
				if (!Bun) { instructions.Add("hold bun"); }
				if (!Pickle) { instructions.Add("hold pickle"); }
				if (!Ketchup) { instructions.Add("hold ketchup"); }
				if (!Mustard) { instructions.Add("hold mustard"); }
				if (!Cheese) { instructions.Add("hold cheese"); }
				if (!Tomato) { instructions.Add("hold tomato"); }
				if (!Lettuce) { instructions.Add("hold lettuce"); }
				if (!Mayo) { instructions.Add("hold mayo"); }
				return instructions;
			}
		}

		/// <summary>
		/// Returns the string representation of this object
		/// </summary>
		/// <returns>The string describing the dakota double burger</returns>
		public override string ToString()
		{
			return "Dakota Double Burger";
		}
	}
}
