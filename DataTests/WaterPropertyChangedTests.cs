using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class WaterPropertyChangedTests
    {
        // Test 1: Water should implement the INotifyPropertyChanged Interface
        [Fact]
        public void JerkedSodaShouldImplementNotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        // Test 2: Changing the "Size" property should invoke the PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Medium;
            });
        }

        // Test 3: Changing the "Size" property should invoke the PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Price", () =>
            {
                water.Size = Size.Medium;
            });
        }

        // Test 4: Changing the "Size" property should invoke the PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Calories", () =>
            {
                water.Size = Size.Medium;
            });
        }

        // Test 5: Changing the "Ice" property should invoke the PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });
        }

        // Test 6: Changing the "Ice" property should invoke the PropertyChanged for "SepcialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }
    }
}
