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
    /// Логика взаимодействия для PageRepair.xaml
    /// </summary>
    public partial class PageRepair : Page
    {
        public PageRepair()
        {
            InitializeComponent();

            dtgRepair.ItemsSource = Auto_repair_shopsEntities.GetContext().repair.ToList();
            CmbPrice.ItemsSource = Auto_repair_shopsEntities.GetContext().repair.Select(x=>x.price).Distinct().ToList();
            CmbFullName.ItemsSource = Auto_repair_shopsEntities.GetContext().Driver.ToList();
            CmbFullName.SelectedValuePath = "id_driver";
            CmbFullName.DisplayMemberPath = "full_name";
        }

        private void BtnResetFiltr_Click(object sender, RoutedEventArgs e)
        {
            dtgRepair.ItemsSource = Auto_repair_shopsEntities.GetContext().repair.ToList();
        }

        private void CmbPrice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            decimal price = (decimal)(CmbPrice.SelectedValue);
            dtgRepair.ItemsSource = Auto_repair_shopsEntities.GetContext().repair.Where(x => x.price == price).ToList();
        }

        private void CmbFullName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int dr = int.Parse(CmbFullName.SelectedValue.ToString());
            dtgRepair.ItemsSource = Auto_repair_shopsEntities.GetContext().repair.Where(x => x.id_driver == dr).ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new PageAddEdit());
        }

        private void TxtSearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            int cn = int.Parse(CmbFullName.SelectedValue.ToString());
            dtgRepair.ItemsSource = Auto_repair_shopsEntities.GetContext().car.Where(x => x.id_car == cn).ToList();
            //string search = TxtSearchName.Text;
            //dtgRepair.ItemsSource = Auto_repair_shopsEntities.GetContext().car.Where(x => x.car_number.Contains(search)).ToList();
            /*Where(x => x.car_number.search).ToList();*/
        }
    }
}