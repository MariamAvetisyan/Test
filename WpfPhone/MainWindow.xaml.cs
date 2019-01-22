using PhoneBusinessLayer;
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

namespace WpfPhone
{
    public partial class MainWindow : Window
    {
        static List<Phone> phoneList = null;
        static List<BrandInfo> brandInfoList = null;

        static MainWindow()
        {
            phoneList = Phones.GetAllPhones();
            brandInfoList = Brands.GetBrandInfos();
        }

        public MainWindow()
        {
            InitializeComponent();

            PhoneComboBox.ItemsSource = phoneList.Select(pb => pb.Brand).Distinct().ToList();
        }

        private void CarComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PhoneListView.ItemsSource = phoneList.Where(p => p.Brand == PhoneComboBox.SelectedItem.ToString());
            PhoneBrandInfo.ItemsSource = brandInfoList.Where(p => p.Brand == PhoneComboBox.SelectedItem.ToString());
        }

        private void PhoneListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone phone = PhoneListView.SelectedItem as Phone;

            PhoneInfoView.ItemsSource = new List<Phone>() {phone};
        }        
    }
}
