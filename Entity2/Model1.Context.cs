﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PRAKT4Entities : DbContext
    {
        public PRAKT4Entities()
            : base("name=PRAKT4Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<INGREDIENTS> INGREDIENTS { get; set; }
        public virtual DbSet<SUSHI> SUSHI { get; set; }
        public virtual DbSet<SUSHI_STORE> SUSHI_STORE { get; set; }
    }
}
