using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Removes item from the Order Summary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    if(button.DataContext is IOrderItem item)
                    {
                        data.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// Swaps screen to the item clicked in the order summary control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OrderSummaryItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl == null) return;

            foreach (object i in e.AddedItems)
            {
                if(i is CowpokeChili)
                {
                    CustomizeCowpokeChili screen = new CustomizeCowpokeChili();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is RustlersRibs)
                {
                    CustomizeRustlersRibs screen = new CustomizeRustlersRibs();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is PecosPulledPork)
                {
                    CustomizePecosPulledPork screen = new CustomizePecosPulledPork();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is TrailBurger)
                {
                    CustomizeTrailBurger screen = new CustomizeTrailBurger();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is DakotaDoubleBurger)
                {
                    CustomizeDakotaDoubleBurger screen = new CustomizeDakotaDoubleBurger();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is TexasTripleBurger)
                {
                    CustomizeTexasTripleBurger screen = new CustomizeTexasTripleBurger();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if (i is AngryChicken)
                {
                    CustomizeAngryChicken screen = new CustomizeAngryChicken();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is ChiliCheeseFries)
                {
                    CustomizeChiliCheeseFries screen = new CustomizeChiliCheeseFries();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is CornDodgers)
                {
                    CustomizeCornDodgers screen = new CustomizeCornDodgers();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is PanDeCampo)
                {
                    CustomizePanDeCampo screen = new CustomizePanDeCampo();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is BakedBeans)
                {
                    CustomizeBakedBeans screen = new CustomizeBakedBeans();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is JerkedSoda)
                {
                    CustomizeJerkedSoda screen = new CustomizeJerkedSoda();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is TexasTea)
                {
                    CustomizeTexasTea screen = new CustomizeTexasTea();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is CowboyCoffee)
                {
                    CustomizeCowboyCoffee screen = new CustomizeCowboyCoffee();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
                else if(i is Water)
                {
                    CustomizeWater screen = new CustomizeWater();
                    screen.DataContext = i;
                    orderControl.SwapScreen(screen);
                }
            }
        }
    }
}
