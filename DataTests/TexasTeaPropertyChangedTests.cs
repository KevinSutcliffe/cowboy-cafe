using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class TexasTeaPropertyChangedTests
    {
        // Test 1: Texas Tea should implement the INotifyPropertyChanged Interface
        [Fact]
        public void JerkedSodaShouldImplementNotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        // Test 2: Changing the "Size" property should invoke the PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Medium;
            });
        }

        // Test 3: Changing the "Size" property should invoke the PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Medium;
            });
        }

        // Test 4: Changing the "Size" property should invoke the PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Medium;
            });
        }

        // Test 5: Changing the "Ice" property should invoke the PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;
            });
        }

        // Test 6: Changing the "Ice" property should invoke the PropertyChanged for "SepcialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
            });
        }

        // Test 7: Changing the "Sweet" property should invoke the PropertyChanged for "Sweet"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForRoomForCream()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });
        }

        // Test 8: Changing the "Sweet" property should invoke the PropertyChanged for "SepcialInstructions"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Sweet = false;
            });
        }

        // Test 9: Changing the "Lemon" property should invoke the PropertyChanged for "Lemon"
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = true;
            });
        }

        // Test 10: Changing the "Lemon" property should invoke the PropertyChanged for "SepcialInstructions"
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = true;
            });
        }
    }
}
