using StoreAppWPF.APIClients;
using StoreAppWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StoreAppWPF.View
{
    /// <summary>
    /// Interaction logic for GroupView.xaml
    /// </summary>
    public partial class GroupView : UserControl
    {
        public GroupView()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void Group_Loaded(object sender, RoutedEventArgs e)
        {
            //IEnumerable<Group> allGroups = await GroupClient.GetAllGroups();
            //DataGrid.ItemsSource = allGroups;
        }

        public void Add_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
