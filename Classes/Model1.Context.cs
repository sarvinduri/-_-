﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Auto_repair_shopsEntities : DbContext
    {
        private static Auto_repair_shopsEntities _context;

        public static Auto_repair_shopsEntities GetContext()
        {
            if (_context == null)
                _context = new Auto_repair_shopsEntities();
            return _context;
        }
        public Auto_repair_shopsEntities()
            : base("name=Auto_repair_shopsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<car> car { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Mechanic> Mechanic { get; set; }
        public virtual DbSet<repair> repair { get; set; }
        public object Payments { get; internal set; }
        public object Categories { get; internal set; }
    }
}
