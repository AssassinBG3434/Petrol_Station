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
    /// Interaction logic for DeliveryModule.xaml
    /// </summary>
    public partial class DeliveryModule : UserControl
    {

        List<string> listOfTypeGas = new List<string>();
        List<string> leftWords = new List<string>();
        public DeliveryModule()
        {
            InitializeComponent();

            for (int i = 0; i < TypeGasInputComboBox.Items.Count; i++)
            {
                string[] res = TypeGasInputComboBox.Items[i].ToString().Split(':');
                listOfTypeGas.Add(res[1].Trim());

            }
        }
        string typeGas;
        private void DeliveryButtonAdd_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            typeGas = TypeGasInput.Text;
        }

        private void deliverButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            DeliveryModule1.Visibility = Visibility.Hidden;
            DeliverModule.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;

        }
        public void MakeItVisible()
        {
            DeliveryModule1.Visibility = Visibility.Visible;
        }

        private void BackButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MakeItVisible();
            DeliverModule.Visibility=Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;
        }

        private void TypeGasInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            string input = TypeGasInput.Text;
            leftWords.Clear();
            if (!string.IsNullOrEmpty(input)) 
            {
                for (int i = 0;i<input.Length;i++)
                {
                    for (int y = 0; y < listOfTypeGas.Count;y++)
                    {
                        for (int j = 0;j< listOfTypeGas[y].Length;j++)
                        {
                            if (input[i].ToString().ToLower() == listOfTypeGas[y][j].ToString().ToLower())
                            {
                                if (!leftWords.Contains(listOfTypeGas[y]))
                                {
                                    leftWords.Add(listOfTypeGas[y]);
                                }
                                break;
                            }
                        }
                    }
                }
                TypeGasInputComboBox.Items.Clear();
                for (int i = 0; i< leftWords.Count;i++)
                {
                    TypeGasInputComboBox.Items.Add(leftWords[i]);
                }
                TypeGasInputComboBox.IsDropDownOpen= true;

            }
            
        }

        private void TypeGasInputComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)TypeGasInputComboBox.SelectedItem;
            TypeGasInput.Text = selectedItem;
            TypeGasInput.Text = selectedItem;
        }

    }
}
