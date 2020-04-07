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
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        public CashRegisterControl()
        {
            InitializeComponent();
        }

        public double TotalPaid()
        {
            CashRegisterModelView register = new CashRegisterModelView();
            double totalPaid = 0;
            totalPaid += PennyControl.Quantity * 0.01;
            totalPaid += NickelControl.Quantity * 0.05;
            totalPaid += DimeControl.Quantity * 0.1;
            totalPaid += QuarterControl.Quantity * 0.25;
            totalPaid += HalfDollarControl.Quantity * 0.5;
            totalPaid += DollarControl.Quantity * 1;
            totalPaid += OneControl.Quantity * 1;
            totalPaid += TwoControl.Quantity * 2;
            totalPaid += FiveControl.Quantity * 5;
            totalPaid += TenControl.Quantity * 10;
            totalPaid += TwentyControl.Quantity * 20;
            totalPaid += FiftyControl.Quantity * 50;
            totalPaid += HundredControl.Quantity * 100;
            //TotalAmmount.Text = string.Format("{0:C}", totalPaid);
            return totalPaid;
        }
    }
}
