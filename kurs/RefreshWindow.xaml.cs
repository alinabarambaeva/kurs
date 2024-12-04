using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;
using kurs.Properties;


namespace kurs
{
    public partial class RefreshWindow : Window
    {
        private Request _currentRequest;
        public RefreshWindow(Request request)
        {
            InitializeComponent();
            _currentRequest = request;

            ClientComboBox.ItemsSource = Service5Entities.GetContext().Clients.ToList();
            TypeComboBox.ItemsSource = Service5Entities.GetContext().Type_of_repair.ToList();
            TimeComboBox.ItemsSource = Service5Entities.GetContext().Times2.ToList();
            PriceComboBox.ItemsSource = Service5Entities.GetContext().Price.ToList();
            WorkerComboBox.ItemsSource = Service5Entities.GetContext().Workers.ToList();
            DeviceComboBox.ItemsSource = Service5Entities.GetContext().Devices.ToList();
            WarrantyComboBox.ItemsSource = Service5Entities.GetContext().Warranty.ToList();

            ClientComboBox.SelectedItem = request.Clients;
            TypeComboBox.SelectedItem = request.Type_of_repair;
            TimeComboBox.SelectedItem = request.Times2;
            PriceComboBox.SelectedItem = request.Price;
            WorkerComboBox.SelectedItem = request.Workers;
            DeviceComboBox.SelectedItem = request.Devices;
            WarrantyComboBox.SelectedItem = request.Warranty;
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Здесь код для обновления данных в базе
            var context = Service5Entities.GetContext();


            _currentRequest.id_client = ((Clients)ClientComboBox.SelectedItem).id_client;
            _currentRequest.id_type_of_repair = ((Type_of_repair)TypeComboBox.SelectedItem).id_type_of_repair;
            _currentRequest.id_time2 = ((Times2)TimeComboBox.SelectedItem).id_time2;
            _currentRequest.id_price = ((Price)PriceComboBox.SelectedItem).id_price;
            _currentRequest.id_worker = ((Workers)WorkerComboBox.SelectedItem).id_worker;
            _currentRequest.id_device = ((Devices)DeviceComboBox.SelectedItem).id_device;
            _currentRequest.id_warranty = ((Warranty)WarrantyComboBox.SelectedItem).id_warranty;
            context.SaveChanges();
            MessageBox.Show("Данные заявки обновлены");
            this.Close();
        }
    }
}




