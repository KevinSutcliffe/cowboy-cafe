using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.DataTests
{
    public class MenuTests
    {
        [Fact]
        public void EntreesContainAllEntreeItems()
        {
            var entrees = Menu.Entrees();
            foreach(IOrderItem i in entrees)
            {
                Assert.Contains(i, entrees);
            }
        }

        [Fact]
        public void SidesContainAllSideItems()
        {
            var sides = Menu.Sides();
            foreach (IOrderItem i in sides)
            {
                Assert.Contains(i, sides);
            }
        }

        [Fact]
        public void DrinksContainAllDrinkItems()
        {
            var drinks = Menu.Drinks();
            foreach (IOrderItem i in drinks)
            {
                Assert.Contains(i, drinks);
            }
        }

        [Fact]
        public void AllContainAllIOrderItems()
        {
            var all = Menu.All();
            foreach (IOrderItem i in all)
            {
                Assert.Contains(i, all);
            }
        }
        
        [Fact]
        public void SearchFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.Search(Menu.All(), "cowpoke");
            IEnumerable<IOrderItem> all = Menu.All();
            bool contains = false;
            foreach(IOrderItem i in test)
            {
                if(i.ToString().Contains("cowpoke", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
            }
            Assert.True(contains);
        }

        [Fact]
        public void SearchFilterTestNull()
        {
            IEnumerable<IOrderItem> test = Menu.Search(Menu.All(), "");
            IEnumerable<IOrderItem> all = Menu.All();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void CategoryFilterTestNull()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByCategory(Menu.All(), null);
            IEnumerable<IOrderItem> all = Menu.All();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void PriceFilterTestNull()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByPrice(Menu.All(), null, null);
            IEnumerable<IOrderItem> all = Menu.All();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void CalorieFilterTestNull()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByCalories(Menu.All(), null, null);
            IEnumerable<IOrderItem> all = Menu.All();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void CategoryFilterTest()
        {
            string[] category = new string[] { "Entrees" };
            IEnumerable<IOrderItem> test = Menu.FilterByCategory(Menu.All(), category);
            Assert.Equal<int>(7, test.Count());
        }

        [Fact]
        public void PriceMinFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByPrice(Menu.All(), 0, null);
            IEnumerable<IOrderItem> all = Menu.All();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void PriceMaxFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByPrice(Menu.All(), null, 0);
            Assert.Empty(test);
        }

        [Fact]
        public void CalorieMinFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByCalories(Menu.All(), 0, null);
            IEnumerable<IOrderItem> all = Menu.All();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void CalorieMaxFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByCalories(Menu.All(), null, 0);
            IEnumerable<IOrderItem> all = Menu.All();
            bool contains = false;
            foreach(IOrderItem i in test)
            {
                if(i.ToString().Contains("water", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
            }
            Assert.True(contains);
        }
    }
}
