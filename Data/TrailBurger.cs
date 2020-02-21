/*

* Author: Kevin Sutcliffe

* Class name: Trail Burger

* Purpose: Creates the trail burger entree object

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger : Entree
    {
		/// <summary>
		/// The price of the entree
		/// </summary>
		public override double Price
		{
			get
			{
				return 4.50;
			}
		}

		/// <summary>
		/// The calories of the entree
		/// </summary>
		public override uint Calories
		{
			get
			{
				return 288;
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
				return instructions;
			}
		}

		/// <summary>
		/// Returns the string representation of this object
		/// </summary>
		/// <returns>The string describing the trail burger</returns>
		public override string ToString()
		{
			return "Trail Burger";
		}
	}
}
