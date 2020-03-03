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
            cancelOrder.Click += OnCancelOrder;
            completeOrder.Click += OnCompleteOrder;
        }

        void OnCancelOrder(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        void OnCompleteOrder(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
    }
}
