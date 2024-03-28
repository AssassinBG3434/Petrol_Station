using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Petrol_Station_Libary
{
    /// <summary>
    /// Interaction logic for GasColumns.xaml
    /// </summary>
    public partial class GasColumns : UserControl
    {
        public GasColumns()
        {
            InitializeComponent();
        }
        public bool inCard = false;

        private void GridProgress1_MouseEnter(object sender, MouseEventArgs e)
        {
            ProgressPercents1.Visibility= Visibility.Visible;
        }

        private void GridProgress1_MouseLeave(object sender, MouseEventArgs e)
        {
            ProgressPercents1.Visibility = Visibility.Collapsed;
        }

        private void GridProgress2_MouseEnter(object sender, MouseEventArgs e)
        {
            ProgressPercents2.Visibility= Visibility.Visible;
        }

        private void GridProgress2_MouseLeave(object sender, MouseEventArgs e)
        {
            ProgressPercents2.Visibility= Visibility.Collapsed;
        }

        private void GridProgress3_MouseEnter(object sender, MouseEventArgs e)
        {
            ProgressPercents3.Visibility= Visibility.Visible;
        }

        private void GridProgress3_MouseLeave(object sender, MouseEventArgs e)
        {
            ProgressPercents3.Visibility = Visibility.Collapsed;
        }

        private void CardButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SellingComp.Visibility = Visibility.Collapsed;
            BorderAfterCardClicked.Visibility = Visibility.Visible;
            inCard=true;
        }

        private void BackButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (inCard == true)
            {
                BorderAfterCardClicked.Visibility= Visibility.Collapsed;
                SellingComp.Visibility = Visibility.Visible;
                inCard = false;
            }else
            {
                AfterSellingPetrol.Visibility = Visibility.Collapsed;
                BeforeBuyingPetrol.Visibility= Visibility.Visible;
            }
        }

        private void Benzin4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GasTypeLabel.Text = "Бензин";
            BeforeBuyingPetrol.Visibility = Visibility.Collapsed;
            AfterSellingPetrol.Visibility = Visibility.Visible;
        }

        private void Diesel4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GasTypeLabel.Text = "Дизел";
            BeforeBuyingPetrol.Visibility = Visibility.Collapsed;
            AfterSellingPetrol.Visibility = Visibility.Visible;
        }

        private void Gas4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GasTypeLabel.Text = "Газ";
            BeforeBuyingPetrol.Visibility = Visibility.Collapsed;
            AfterSellingPetrol.Visibility = Visibility.Visible;
        }
    }
}
