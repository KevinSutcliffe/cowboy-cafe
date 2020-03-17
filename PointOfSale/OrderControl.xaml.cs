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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            this.DataContext = new Order();
            cancelOrder.Click += OnCancelOrder_Click;
            completeOrder.Click += OnCompleteOrder_Click;
        }

        void OnCancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            ItemSelection_Click(sender, e);
        }

        void OnCompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            ItemSelection_Click(sender, e);
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        public void OnMenuItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            SwapScreen(new MenuItemSelectionControl());
        }

        public void ItemChanged()
        {
            if(DataContext is Order data)
            {
                data.OnItemPropertyChanged();
            }
        }
    }
}
