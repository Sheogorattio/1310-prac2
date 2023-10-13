using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _1310_prac2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] culture = { "uk", "en" };
        bool state = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateUI()
        {
            lblName.Content = lang.lblName_text;
            lblSurname.Content = lang.lblSurname_text;
            lblPhone.Content = lang.lblPhone_text;
            CancelButton.Content = lang.CancelButton_text;
            ChangeLangButton.Content = lang.ChangeLangButton_text;
        }

        private void ChangeLangButton_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture[Convert.ToInt32(state)]);
            state = !state;
            UpdateUI();
        }
    }
}
