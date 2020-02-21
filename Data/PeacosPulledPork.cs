/*

* Author: Kevin Sutcliffe

* Class name: Pecos Pulled Pork

* Purpose: Creates the pecos pulled pork entree object

*/

using System.Collections.Generic;

namespace CowboyCafe.Data
{
	public class PecosPulledPork : Entree
    {
		/// <summary>
		/// The price of the entree
		/// </summary>
		public override double Price
		{
			get
			{
				return 5.88;
			}
		}

		/// <summary>
		/// The calories of the entree
		/// </summary>
		public override uint Calories
		{
			get
			{
				return 528;
			}
		}

		/// <summary>
		/// If the entree should be served with a pickle
		/// </summary>
		private bool pickle = true;
		public bool Pickle
		{
			get { return pickle; }
			set { pickle = value; }
		}

		/// <summary>
		/// If the entree should be served with bread
		/// </summary>
		private bool bread = true;
		public bool Bread
		{
			get { return bread; }
			set { bread = value; }
		}

		/// <summary>
		/// List of instructions for the entree
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get
			{
				List<string> instructions = new List<string>();
				if (!Bread) { instructions.Add("hold bread"); }
				if (!Pickle) { instructions.Add("hold pickle"); }
				return instructions;
			}
		}

		/// <summary>
		/// Returns the string representation of this object
		/// </summary>
		/// <returns>The string describing the pecos pulled pork</returns>
		public override string ToString()
		{
			return "Pecos Pulled Pork";
		}
	}
}
