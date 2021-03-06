﻿using System;
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
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeChiliCheeseFries.xaml
    /// </summary>
    public partial class CustomizeChiliCheeseFries : UserControl
    {
        public CustomizeChiliCheeseFries()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates order control summary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Finish_Button_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(orderControl is OrderControl)
            {
                orderControl.ItemChanged();
            }
        }
    }
}
