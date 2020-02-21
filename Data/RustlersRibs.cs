/*

* Author: Kevin Sutcliffe

* Class name: Rustlers Ribs 

* Purpose: Creates the rustlers ribs entree object

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs : Entree
    {
		/// <summary>
		/// The price of the entree
		/// </summary>
		public override double Price
		{
			get
			{
				return 7.50;
			}
		}

		/// <summary>
		/// The calories of the entree
		/// </summary>
		public override uint Calories
		{
			get
			{
				return 894;
			}
		}

		/// <summary>
		/// List of instructions for the entree
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get
			{
				List<string> instructions = new List<string>();
				return instructions;
			}
		}

		/// <summary>
		/// Returns the string representation of this object
		/// </summary>
		/// <returns>The string describing the rustlers ribs</returns>
		public override string ToString()
		{
			return "Rustler's Ribs";
		}
	}
}
