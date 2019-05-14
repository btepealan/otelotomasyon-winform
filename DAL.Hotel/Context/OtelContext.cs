using DAL.Hotel.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Context
{
    public class  OtelResContext: DbContext
    {

        public OtelResContext() : base("OtelResContext")
        {
            //Migration işlemleri için DbContext (PIContext) ile Migration eşleştirilmelidir.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OtelResContext, Configuration>("OtelResContext"));
            this.Configuration.LazyLoadingEnabled = false; //İlişkili tablolara (Urunler gibi) sorgu çekmiyor, EagerLoading çalışıyor.
        }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<GuestTransaction> GuestTransactions { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomType { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ExtraType> ExtraTypes { get; set; }
        public virtual DbSet<ExtraTransactions> ExtraTransactions { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }



        //protected override void OnModelCreating(DbModelBuilder modelBuilder)

        //{

        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        //}
    }
}
