using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Data.Entity;
using kurs.Properties;

namespace kurs
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshServiceDataGrid();
            ComboStatus.ItemsSource = Service5Entities.GetContext().Type_of_repair.ToList();
            Vis();
        }
        private void RefreshServiceDataGrid()
        {
            var context = Service5Entities.GetContext();
            var requestsWithRelations = context.Request
                .Include(r => r.Times1)
                .Include(r => r.Times2)
                .Include(r => r.Clients)
                .Include(r => r.Type_of_repair)
                .Include(r => r.Price)
                .Include(r => r.Workers)
                .Include(r => r.Devices)
                .Include(r => r.Warranty)
            .ToList();
            Service.ItemsSource = requestsWithRelations;
        }
        private void Vis()
        {
            switch (Properties.Authorization.authorizationRole)
            {
                case "Admin":
                    Red.Visibility = Visibility.Collapsed;
                    BtnAdd.Visibility = Visibility.Collapsed;
                    break;
                case "Moder":
                    BtnDelet.Visibility = Visibility.Collapsed;
                    BtnAdd.Visibility = Visibility.Collapsed;
                    break;
                case "User":
                    BtnDelet.Visibility = Visibility.Collapsed;
                    Red.Visibility = Visibility.Collapsed;
                    break;
                default:
                    return;
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedRequest = (sender as Button)?.DataContext as Request;
            if (selectedRequest != null)
            {
                RefreshWindow addEditWindow = new RefreshWindow(selectedRequest);
                if (addEditWindow.ShowDialog() == true)
                {
                    RefreshServiceDataGrid();
                }
            }
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow addEditWindow = new AddEditWindow();
            if (addEditWindow.ShowDialog() == true)
                RefreshServiceDataGrid();

            }
        private void BtnDelet_Click(object sender, RoutedEventArgs e)
        {
            var servisForRemoving = Service.SelectedItems.Cast<Request>().ToList();
            if (servisForRemoving.Any() && MessageBox.Show($"Вы точно хотите удалить следующее {servisForRemoving.Count()}элемент ? ", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var context = Service5Entities.GetContext();
                context.Request.RemoveRange(servisForRemoving);
                context.SaveChanges();
                MessageBox.Show("Данные удалены");
                RefreshServiceDataGrid();
            }
        }
        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            Service.ItemsSource = Service5Entities.GetContext().Request.ToList();
            RefreshServiceDataGrid();
        }
        private void BtnOut_Click(object sender, RoutedEventArgs e)
        {
            if (ComboStatus.SelectedItem is Type_of_repair selectedStatus)
            {
                int selectedStatusId = selectedStatus.id_type_of_repair;
                var context = Service5Entities.GetContext();
                Service.ItemsSource = context.Request
                .Include(r => r.Times1)
                .Include(r => r.Times2)
                .Include(r => r.Clients)
                .Include(r => r.Type_of_repair)
                .Include(r => r.Price)
                .Include(r => r.Workers)
                .Include(r => r.Devices)
                .Include(r => r.Warranty)
                .Where(r => r.id_type_of_repair == selectedStatusId)
                .ToList();
            }

        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = SearchBox.Text.ToLower();
            var context = Service5Entities.GetContext();
            try
            {
                Service.ItemsSource = context.Request
                .Include(r => r.Times1)
                .Include(r => r.Times2)
                .Include(r => r.Clients)
                .Include(r => r.Type_of_repair)
                .Include(r => r.Price)
                .Include(r => r.Workers)
                .Include(r => r.Devices)
                .Include(r => r.Warranty)
                .Where(r =>
                r.Times1.name_time1.ToLower().Contains(searchText) ||
                r.Times2.name_time2.ToLower().Contains(searchText) ||
                r.Clients.client_name.ToLower().Contains(searchText) ||
                r.Type_of_repair.name_type_of_repair.ToLower().Contains(searchText) ||
                r.Price.name_price.ToLower().Contains(searchText) ||
                r.Workers.name_worker.ToLower().Contains(searchText) ||
                r.Devices.device_name.ToLower().Contains(searchText) ||
                r.Warranty.name_warranty.ToLower().Contains(searchText))
                .ToList();
            }
            catch (System.Data.Entity.Core.EntityCommandExecutionException ex)
            {
                // Логирование или отладка исключения
                Console.WriteLine(ex.InnerException?.Message);
            }
        }
       
        private void BtnAuthorization_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }

        private void ComboStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}



