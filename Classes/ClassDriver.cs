using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Глазкова_Труфанова.Classes
{
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
    }
}
