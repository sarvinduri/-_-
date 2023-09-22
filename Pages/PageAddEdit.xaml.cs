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
using Глазкова_Труфанова.Classes;

namespace Глазкова_Труфанова.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddEdit.xaml
    /// </summary>
    public partial class PageAddEdit : Page
    {
        public PageAddEdit()
        {
            InitializeComponent();

           
            CmbCar.ItemsSource = Auto_repair_shopsEntities.GetContext().car.ToList();
            CmbCar.SelectedValuePath = "id_car";
            CmbCar.DisplayMemberPath = "car_number";

            CmbDriver.ItemsSource = Auto_repair_shopsEntities.GetContext().Driver.ToList();
            CmbDriver.SelectedValuePath = "id_driver";
            CmbDriver.DisplayMemberPath = "full_name";

            CmbMechanic.ItemsSource = Auto_repair_shopsEntities.GetContext().Mechanic.ToList();
            CmbMechanic.SelectedValuePath = "id_mechanic";
            CmbMechanic.DisplayMemberPath = "full_name";
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            repair rep = new repair()
            {
                id_car = int.Parse(CmbCar.SelectedValue.ToString()),
                id_driver = int.Parse(CmbDriver.SelectedValue.ToString()),
                id_mechanic = int.Parse(CmbMechanic.SelectedValue.ToString()),
                price = int.Parse(TxtPrice.Text)
            };
            Auto_repair_shopsEntities.GetContext().repair.Add(rep);
            Auto_repair_shopsEntities.GetContext().SaveChanges();

            MessageBoxResult boxResult = MessageBox.Show("Данные добавлены. Добавить еще?",
                "Сообщение", MessageBoxButton.YesNo);
            if (boxResult == MessageBoxResult.Yes)
            {
                //int.Parse(CmbCar.Clear)();
                //int.Parse(CmbDriver.Clear)();
                //CmbCar.Focus();
            }
            else
                Classes.ClassFrame.frmObj.Navigate(new Pages.PageRepair());
        }
    }
}