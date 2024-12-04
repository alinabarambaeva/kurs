using System;
using System.IO;
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
using System.Windows.Shapes;



namespace kurs
{
    public partial class AddEditWindow : Window
    {
        private Request request = new Request();
        private Clients clients = new Clients();
        private Devices devices = new Devices();
        private Times1 times1 = new Times1();
        public AddEditWindow()
        {
            InitializeComponent();
            DataContext = request;
            TypeComboBox.ItemsSource = Service5Entities.GetContext().Type_of_repair.ToList();
            DeviceComboBox.ItemsSource = Service5Entities.GetContext().Devices.ToList();

        }

        private void BtnSave_Click(Object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (TypeComboBox.SelectedItem != null && TypeComboBox.SelectedItem is Type_of_repair type_Of_repair)
                request.id_type_of_repair = type_Of_repair.id_type_of_repair;
            else error.AppendLine("Выберите тип ремонта");

      
            if (DeviceComboBox.SelectedItem != null && DeviceComboBox.SelectedItem is Devices device)
                request.id_device= device.id_device;
            else error.AppendLine("Выберите тип ремонта");


            if (string.IsNullOrWhiteSpace(ClientTextBox.Text))
                error.AppendLine("Укажите клиента");

            if (string.IsNullOrWhiteSpace(DataTextBox.Text))
                error.AppendLine("Укажите дату сдачи");

            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Предупреждение!", MessageBoxButton.OK,
                MessageBoxImage.Information);
                return;

            }

            try
            {
                var context = Service5Entities.GetContext();
                clients.client_name = ClientTextBox.Text;
                times1.name_time1 = DataTextBox.Text;
 


                context.Clients.Add(clients);
                context.Times1.Add(times1);
   
                context.SaveChanges();

                var clientId = clients.id_client;
                var time1Id = times1.id_time1;
            


                request.id_client = clientId;
                request.id_time1 = time1Id;
 
                context.Request.Add(request);
                context.SaveChanges();
                MessageBox.Show("Информация сохранена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

