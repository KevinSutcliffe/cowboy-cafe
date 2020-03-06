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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            AddCowpokeChili.Click += OnItemAddButtonClicked;
            AddRustlersRibs.Click += OnItemAddButtonClicked;
            AddPecosPulledPork.Click += OnItemAddButtonClicked;
            AddTrailBurger.Click += OnItemAddButtonClicked;
            AddDakotaDoubleBurger.Click += OnItemAddButtonClicked;
            AddTexasTripleBurger.Click += OnItemAddButtonClicked;
            AddAngryChicken.Click += OnItemAddButtonClicked;
            AddChiliCheeseFries.Click += OnItemAddButtonClicked;
            AddCornDodgers.Click += OnItemAddButtonClicked;
            AddPanDeCampo.Click += OnItemAddButtonClicked;
            AddBakedBeans.Click += OnItemAddButtonClicked;
            AddJerkedSoda.Click += OnItemAddButtonClicked;
            AddTexasTea.Click += OnItemAddButtonClicked;
            AddCowboyCoffee.Click += OnItemAddButtonClicked;
            AddWater.Click += OnItemAddButtonClicked;

        }
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            var entree = new CowpokeChili();
                            var screen = new CustomizeCowpokeChili();
                            screen.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen);
                            break;
                        case "RustlersRibs":
                            /*
                            var entree = new RustlersRibs();
                            var screen = new CustomizeRustlersRibs();
                            screen.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(new CustomizeRustlersRibs());
                            */
                            break;
                        case "PecosPulledPork":
                            order.Add(new PecosPulledPork());
                            break;
                        case "TrailBurger":
                            order.Add(new TrailBurger());
                            break;
                        case "DakotaDoubleBurger":
                            order.Add(new DakotaDoubleBurger());
                            break;
                        case "TexasTripleBurger":
                            order.Add(new TexasTripleBurger());
                            break;
                        case "AngryChicken":
                            order.Add(new AngryChicken());
                            break;
                        case "ChiliCheeseFries":
                            order.Add(new ChiliCheeseFries());
                            break;
                        case "CornDodgers":
                            order.Add(new CornDodgers());
                            break;
                        case "PanDeCampo":
                            order.Add(new PanDeCampo());
                            break;
                        case "BakedBeans":
                            order.Add(new BakedBeans());
                            break;
                        case "JerkedSoda":
                            order.Add(new JerkedSoda());
                            break;
                        case "TexasTea":
                            order.Add(new TexasTea());
                            break;
                        case "CowboyCoffee":
                            order.Add(new CowboyCoffee());
                            break;
                        case "Water":
                            order.Add(new Water());
                            break;

                    }
                }
            }            
        }

        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            // We need to have an Order to add this item to
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext expected to be an order instantiated");

            // Not all OrderItems need to be customized
            if(screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception();

                //Add the item to the customization screen and launch it
                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }

            order.Add(item);
        }
    }    
}
