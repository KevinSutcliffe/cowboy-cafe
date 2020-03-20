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
                            var entree2 = new RustlersRibs();
                            var screen2 = new CustomizeRustlersRibs();
                            screen2.DataContext = entree2;
                            order.Add(entree2);
                            orderControl.SwapScreen(screen2);
                            break;
                        case "PecosPulledPork":
                            var entree3 = new PecosPulledPork();
                            var screen3 = new CustomizePecosPulledPork();
                            screen3.DataContext = entree3;
                            order.Add(entree3);
                            orderControl.SwapScreen(screen3);
                            break;
                        case "TrailBurger":
                            var entree4 = new TrailBurger();
                            var screen4 = new CustomizeTrailBurger();
                            screen4.DataContext = entree4;
                            order.Add(entree4);
                            orderControl.SwapScreen(screen4);
                            break;
                        case "DakotaDoubleBurger":
                            var entree5 = new DakotaDoubleBurger();
                            var screen5 = new CustomizeDakotaDoubleBurger();
                            screen5.DataContext = entree5;
                            order.Add(entree5);
                            orderControl.SwapScreen(screen5);
                            break;
                        case "TexasTripleBurger":
                            var entree6 = new TexasTripleBurger();
                            var screen6 = new CustomizeTexasTripleBurger();
                            screen6.DataContext = entree6;
                            order.Add(entree6);
                            orderControl.SwapScreen(screen6);
                            break;
                        case "AngryChicken":
                            var entree7 = new AngryChicken();
                            var screen7 = new CustomizeAngryChicken();
                            screen7.DataContext = entree7;
                            order.Add(entree7);
                            orderControl.SwapScreen(screen7);
                            break;
                        case "ChiliCheeseFries":
                            var entree8 = new ChiliCheeseFries();
                            var screen8 = new CustomizeChiliCheeseFries();
                            screen8.DataContext = entree8;
                            order.Add(entree8);
                            orderControl.SwapScreen(screen8);
                            break;
                        case "CornDodgers":
                            var entree9 = new CornDodgers();
                            var screen9 = new CustomizeCornDodgers();
                            screen9.DataContext = entree9;
                            order.Add(entree9);
                            orderControl.SwapScreen(screen9);
                            break;
                        case "PanDeCampo":
                            var entree10 = new PanDeCampo();
                            var screen10 = new CustomizePanDeCampo();
                            screen10.DataContext = entree10;
                            order.Add(entree10);
                            orderControl.SwapScreen(screen10);
                            break;
                        case "BakedBeans":
                            var entree11 = new BakedBeans();
                            var screen11 = new CustomizeBakedBeans();
                            screen11.DataContext = entree11;
                            order.Add(entree11);
                            orderControl.SwapScreen(screen11);
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
