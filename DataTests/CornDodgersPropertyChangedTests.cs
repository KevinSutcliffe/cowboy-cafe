using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CornDodgersPropertyChangedTests
    {
        // Test 1: Corn Dodgers should implement the INotifyPropertyChanged Interface
        [Fact]
        public void CornDodgersShouldImplementNotifyPropertyChanged()
        {
            var corn = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(corn);
        }

        // Test 2: Changing the "Size" property should invoke the PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () =>
            {
                corn.Size = Size.Medium;
            });
        }

        // Test 3: Changing the "Size" property should invoke the PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Price", () =>
            {
                corn.Size = Size.Medium;
            });
        }

        // Test 4: Changing the "Size" property should invoke the PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Calories", () =>
            {
                corn.Size = Size.Medium;
            });
        }
    }
}
