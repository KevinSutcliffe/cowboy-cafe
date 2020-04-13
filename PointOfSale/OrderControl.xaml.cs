/*

* Author: Kevin Sutcliffe

* Class name: Order Control

* Purpose: Creates the Point of Sale user interface

*/

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
using CashRegister;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        CashDrawer cd;

        public OrderControl()
        {
            InitializeComponent();
            cancelOrder.Click += OnCancelOrder_Click;
            completeOrder.Click += OnCompleteOrder_Click;
            cd = new CashDrawer();
        }

        /// <summary>
        /// Cancels the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            ItemSelection_Click(sender, e);
        }

        /// <summary>
        /// Completes the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            //Container.Child = new TransactionControl();
            Order o = (Order)DataContext;
            IOrderItem[] io = (IOrderItem[])o.Items;

            /* Check to make sure there is a transaction available */
            if (io.Length != 0)
            {
                MainWindow mw = this.FindAncestor<MainWindow>();
                //Container.Child = new TestTransControl(cd, this);
                mw.Container.Child = new TestTransControl(cd, this);

                //DataContext = new Order();
            }
        }

        /// <summary>
        /// Swaps the to the elements screen
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }
        
        /// <summary>
        /// Updates display so user can add more items to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
            //SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Updates an item when it is changed
        /// </summary>
        public void ItemChanged()
        {
            if(DataContext is Order data)
            {
                data.OnItemPropertyChanged();
            }
        }
    }
}
