using System;
using System.Collections.Generic;
using System.Linq;
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
            BakedBeans bMed = new BakedBeans();
            sideIncrease(bMed, Size.Medium);
            sides.Add(bMed);
            BakedBeans bLarge = new BakedBeans();
            sideIncrease(bLarge, Size.Large);
            sides.Add(bLarge);

            sides.Add(new ChiliCheeseFries());
            ChiliCheeseFries cMed = new ChiliCheeseFries();
            sideIncrease(cMed, Size.Medium);
            sides.Add(cMed);
            ChiliCheeseFries cLarge = new ChiliCheeseFries();
            sideIncrease(cLarge, Size.Large);
            sides.Add(cLarge);

            sides.Add(new PanDeCampo());
            PanDeCampo dMed = new PanDeCampo();
            sideIncrease(dMed, Size.Medium);
            sides.Add(dMed);
            PanDeCampo dLarge = new PanDeCampo();
            sideIncrease(dLarge, Size.Large);
            sides.Add(dLarge);

            sides.Add(new CornDodgers());
            CornDodgers cdMed = new CornDodgers();
            sideIncrease(cdMed, Size.Medium);
            sides.Add(cdMed);
            CornDodgers cdLarge = new CornDodgers();
            sideIncrease(cdLarge, Size.Large);
            sides.Add(cdLarge);
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
            JerkedSoda jMed = new JerkedSoda();
            drinkIncrease(jMed, Size.Medium);
            drinks.Add(jMed);
            JerkedSoda jLarge = new JerkedSoda();
            drinkIncrease(jLarge, Size.Large);
            drinks.Add(jLarge);

            drinks.Add(new CowboyCoffee());
            CowboyCoffee cMed = new CowboyCoffee();
            drinkIncrease(cMed, Size.Medium);
            drinks.Add(cMed);
            CowboyCoffee cLarge = new CowboyCoffee();
            drinkIncrease(cLarge, Size.Large);
            drinks.Add(cLarge);

            drinks.Add(new TexasTea());
            TexasTea tMed = new TexasTea();
            drinkIncrease(tMed, Size.Medium);
            drinks.Add(tMed);
            TexasTea tLarge = new TexasTea();
            drinkIncrease(tLarge, Size.Large);
            drinks.Add(tLarge);

            drinks.Add(new Water());
            Water wMed = new Water();
            drinkIncrease(wMed, Size.Medium);
            drinks.Add(wMed);
            Water wLarge = new Water();
            drinkIncrease(wLarge, Size.Large);
            drinks.Add(wLarge);

            return drinks;
        }

        /// <summary>
        /// Gets the whole menu
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> All()
        {
            List<IOrderItem> all = new List<IOrderItem>();
            foreach(IOrderItem i in Entrees())
            {
                all.Add(i);
            }
            foreach (IOrderItem s in Sides())
            {
                all.Add(s);
            }
            foreach (IOrderItem d in Drinks())
            {
                all.Add(d);
            }
            return all;
        }

        /// <summary>
        /// Changes the size of the side
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="s"></param>
        public static void sideIncrease(Side obj, Size s)
        {
            obj.Size = s;
        }

        /// <summary>
        /// Changes the size of the drink
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="s"></param>
        public static void drinkIncrease(Drink obj, Size s)
        {
            obj.Size = s;
        }

        /// <summary>
        /// Searches the menu
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of movies</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> all, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return all; //return All;
            foreach (IOrderItem item in all)
            {
                if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the possible Category
        /// </summary>
        public static string[] Category
        {
            get => new string[]
            {
            "Entrees",
            "Sides",
            "Drinks"
            };
        }

        /// <summary>
        /// Gets the items within the category selected
        /// </summary>
        /// <param name="all"></param>
        /// <param name="categories"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> all, IEnumerable<string> categories) 
        {
            if (categories == null || categories.Count() == 0) return all;
            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (String s in categories)
            {
                if (s.Equals("Entrees"))
                {
                    foreach (IOrderItem i in Entrees())
                    {
                        results.Add(i);
                    }
                }
                else if (s.Equals("Sides"))
                {
                    foreach (IOrderItem side in Sides())
                    {
                        results.Add(side);
                    }
                }
                else if (s.Equals("Drinks"))
                {
                    foreach (IOrderItem d in Drinks())
                    {
                        results.Add(d);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the items inbetween the calories filters
        /// </summary>
        /// <param name="all"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> all, int? min, int? max)
        {
            // TODO: Filter movies
            if (min == null && max == null) return all;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in all)
                {
                    if (i.Calories <= max) results.Add(i);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem i in all)
                {
                    if (i.Calories >= min) results.Add(i);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem i in all)
            {
                if (i.Calories >= min && i.Calories <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the items inbetween the price filters
        /// </summary>
        /// <param name="all"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> all, double? min, double? max)
        {
            // TODO: Filter movies
            if (min == null && max == null) return all;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in all)
                {
                    if (i.Price <= max) results.Add(i);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem i in all)
                {
                    if (i.Price >= min) results.Add(i);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem i in all)
            {
                if (i.Price >= min && i.Price <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }
    }
}
