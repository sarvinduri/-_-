using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Net;
=======
>>>>>>> 8ecb1c703c3c9561bed8e605427ab774e861f13c
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
<<<<<<< HEAD
using Глазкова_Труфанова.Classes;
=======
>>>>>>> 8ecb1c703c3c9561bed8e605427ab774e861f13c

namespace Глазкова_Труфанова.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageClassDriver.xaml
    /// </summary>
    public partial class PageClassDriver : Page
    {
<<<<<<< HEAD
        public List<ClassDriver> CurrentClassDriverList { get; set; }
        public PageClassDriver()
        {
            InitializeComponent();
            dtgDriver.ItemsSource = Auto_repair_shopsEntities.GetContext().Driver.ToList();
=======
        public PageClassDriver()
        {
            InitializeComponent();
>>>>>>> 8ecb1c703c3c9561bed8e605427ab774e861f13c
        }
    }
}
