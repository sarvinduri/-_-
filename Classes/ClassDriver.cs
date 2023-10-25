using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Глазкова_Труфанова.Classes
{
<<<<<<< HEAD
    public class ClassDriver
    {
        public int Id_driver { get; set; }
        public string Full_name { get; set; }
        public string Phone { get; set; }
        public int Id_car { get; set; }
=======
    public partial class ClassRepair
    {
        public List<ClassRepair> CurrentClassRepairList { get;set; }
        public ClassRepair() 
        {            
            //var client = new WebClient();
            //var response = WebClient.DownloadString("");
            //CurrentClassRepairList = JsonConvert.DeserializeObject<List<ClassRepair>>(response);
            //DataContext = this;
        }
>>>>>>> 8ecb1c703c3c9561bed8e605427ab774e861f13c
    }
}
