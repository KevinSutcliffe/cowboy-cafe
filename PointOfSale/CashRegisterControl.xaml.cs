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
        //static CashRegisterModelView register = new CashRegisterModelView();

        public CashRegisterControl()
        {
            InitializeComponent();
        }

        public double TotalPaid()
        {
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
            TotalAmmount.Text = string.Format("{0:C}", totalPaid);
            return totalPaid;
        }

        private void CompletePayment_Clicked(object sender, RoutedEventArgs e)
        {

            double paid = TotalPaid();
            while(paid > 0)
            {
                if(paid >= 100 && HundredControl.Quantity > 0)
                {
                    paid -= 100;

                }
                else if( paid >= 50 && FiftyControl.Quantity > 0)
                {
                    paid -= 50;
                }
                else if (paid >= 20 && TwentyControl.Quantity > 0)
                {
                    paid -= 100;
                }
                else if (paid >= 10 && TenControl.Quantity > 0)
                {
                    paid -= 100;
                }
                else if (paid >= 5 && FiveControl.Quantity > 0)
                {
                    paid -= 100;
                }
                else if (paid >= 2 && TwoControl.Quantity > 0)
                {
                    paid -= 100;
                }
                else if (paid >= 1 && OneControl.Quantity > 0)
                {
                    paid -= 100;
                }
                else if (paid >= 1 && DollarControl.Quantity > 0)
                {
                    paid -= 100;
                }
                else if (paid >= 0.5 && HalfDollarControl.Quantity > 0)
                {
                    paid -= 100;
                }
                else if (paid >= 0.25 && QuarterControl.Quantity > 0)
                {
                    paid -= 100;
                }
                else if (paid >= 0.1 && DimeControl.Quantity > 0)
                {
                    paid -= 100;
                }
                else if (paid >= .05 && NickelControl.Quantity > 0)
                {
                    paid -= 100;
                }
                else if (paid >= 0.01 && PennyControl.Quantity > 0)
                {
                    paid -= 100;
                }
            }
        }
    }
}
