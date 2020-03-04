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
        private OrderControl orderControl;

        public MenuItemSelectionControl()
        {
            InitializeComponent();

            AddCowpokeChili.Click += OnAddCowpokeChiliButtonClicked;
            AddRustlersRibs.Click += OnAddRustlersRibsButtonClicked;
            AddPecosPulledPork.Click += OnAddPecosPulledPorkButtonClicked;
            AddTrailBurger.Click += OnAddTrailBurgerClicked;
            AddDakotaDoubleBurger.Click += OnAddDakotaDoubleBurgerClicked;
            AddTexasTripleBurger.Click += OnAddTexasTripleBurgerClicked;
            AddAngryChicken.Click += OnAddAngryChickenClicked;
            AddChiliCheeseFries.Click += OnAddChiliCheeseFriesClicked;
            AddCornDodgers.Click += OnAddCornDodgersClicked;
            AddPanDeCampo.Click += OnAddPanDeCampoClicked;
            AddBakedBeans.Click += OnAddBakedBeansClicked;
            AddJerkedSoda.Click += OnAddJerkedSodaClicked;
            AddTexasTea.Click += OnAddTexasTeaClicked;
            AddCowboyCoffee.Click += OnAddCowboyCoffeeClicked;
            AddWater.Click += OnAddWaterClicked;

        }
        /*
         * One click event that could hanfle al the burrons
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            order.Add(new CowpokeChili());
                            break;

                    }
                }
            }
            
        }
        */

        /// <summary>
        /// Adds Cowpoke Chili to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new CowpokeChili();
                var screen = new CustomizeCowpokeChili();
                screen.DataContext = entree;
                data.Add(entree);
                orderControl.SwapScreen(new CustomizeCowpokeChili());
            }
        }

        /// <summary>
        /// Adds Rustlers Ribs to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// Adds Pecos Pulled Pork to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// Adds Trail Burger to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TrailBurger());
            }
        }

        /// <summary>
        /// Adds Dakota Double Burger to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// Adds Texas Triple Burger to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// Adds Angry Chicken to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// Adds Chili Cheese Fries to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// Adds Corn Dodgers to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// Adds Pan De Campo to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPanDeCampoClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// Adds Baked Beans to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// Adds Jerked Soda to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// Adds Texas Tea to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());
            }
        }

        /// <summary>
        /// Adds Cowboy Coffee to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// Adds Water to the Order List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new Water());
            }
        }
    }    
}
