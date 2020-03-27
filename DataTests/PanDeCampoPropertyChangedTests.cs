using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class PanDeCampoPropertyChangedTests
    {
        // Test 1: Pan De Campo should implement the INotifyPropertyChanged Interface
        [Fact]
        public void PanDeCampoShouldImplementNotifyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
        }

        // Test 2: Changing the "Size" property should invoke the PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () =>
            {
                pan.Size = Size.Medium;
            });
        }

        // Test 3: Changing the "Size" property should invoke the PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Price", () =>
            {
                pan.Size = Size.Medium;
            });
        }

        // Test 4: Changing the "Size" property should invoke the PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Calories", () =>
            {
                pan.Size = Size.Medium;
            });
        }
    }
}
