//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Глазкова_Труфанова.Classes
{
    using System;
    using System.Collections.Generic;
    
    public partial class repair
    {
        public int id_repair { get; set; }
        public decimal price { get; set; }
        public System.DateTime date { get; set; }
        public int id_driver { get; set; }
        public int id_mechanic { get; set; }
        public int id_car { get; set; }
    
        public virtual car car { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Mechanic Mechanic { get; set; }
    }
}
