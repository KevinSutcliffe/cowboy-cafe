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
using CowboyCafe.Data;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();
        }

        private void PaymentByCredit_Clicked(object sender, RoutedEventArgs e)
        {
            CardTerminal terminal = new CardTerminal();
            Order currentOrder = (Order)this.DataContext;
            CashRegister.ResultCode result = terminal.ProcessTransaction(currentOrder.Total);
            if(result == CashRegister.ResultCode.Success)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Error " + result);
            }
        }

        private void PrintReceipt()
        {
            ReceiptPrinter receiptPrinter = new ReceiptPrinter();
        }
    }
}