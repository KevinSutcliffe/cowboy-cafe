/*

* Author: Kevin Sutcliffe

* Class name: Pecos Pulled Pork

* Purpose:

*/

using System.Collections.Generic;

namespace CowboyCafe.Data
{
	public class PecosPulledPork
    {
		/// <summary>
		/// The price of the entree
		/// </summary>
		public double Price
		{
			get
			{
				return 5.88;
			}
		}

		/// <summary>
		/// The calories of the entree
		/// </summary>
		public uint Calories
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
		public List<string> SpecialInstructions
		{
			get
			{
				List<string> instructions = new List<string>();
				if (!Bread) { instructions.Add("hold bread"); }
				if (!Pickle) { instructions.Add("hold pickle"); }
				return instructions;
			}
		}
	}
}
