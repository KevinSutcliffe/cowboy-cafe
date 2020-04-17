using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Gets all the entrees 
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees() 
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new CowpokeChili());
            entrees.Add(new RustlersRibs());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new TrailBurger());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new AngryChicken());
            return entrees;
        }

        /// <summary>
        /// Gets all the sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new PanDeCampo());
            sides.Add(new CornDodgers());
            return sides;
        }

        /// <summary>
        /// Gets all the drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new JerkedSoda());
            drinks.Add(new CowboyCoffee());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());
            return drinks;
        }

        /// <summary>
        /// Gets the whole menu
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> all = new List<IOrderItem>();
            foreach(IOrderItem i in Entrees())
            {
                all.Add(i);
            }
            foreach (IOrderItem i in Sides())
            {
                all.Add(i);
            }
            foreach (IOrderItem i in Drinks())
            {
                all.Add(i);
            }
            return all;
        }

        public static void sideIncrease(Side obj, Size s)
        {
            obj.Size = s;
        }

        public static void drinkIncrease(Drink obj, Size s)
        {
            obj.Size = s;
        }
    }
}
