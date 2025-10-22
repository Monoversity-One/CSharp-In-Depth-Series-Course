using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace _08_3.EFExample.AutoLotDAL.Models
{
    public partial class AutoLotEntities : DbContext
    {
        public AutoLotEntities()
            : base("name=AutoLotConnection")
        {
            //DbInterception.Add(new ConsoleWriterInterceptor());



            //databaseLogger.StartLogging();
            //DbInterception.Add(databaseLogger);



            var context = (this as IObjectContextAdapter).ObjectContext;
            context.ObjectMaterialized += OnObjectMaterialized;
            context.SavingChanges += OnSavingChanges;
        }


        //static readonly DatabaseLogger databaseLogger = new DatabaseLogger("sqllog.txt", true);

        //protected override void Dispose(bool disposing)
        //{
        //    DbInterception.Remove(databaseLogger);
        //    databaseLogger.StopLogging();
        //    base.Dispose(disposing);
        //}




        //This permits you to write code that rejects any changes to a vehicle’s color if the color is red
        private void OnSavingChanges(object sender, EventArgs eventArgs)
        {
            var context = sender as ObjectContext;
            if (context == null)
            {
                return;
            }
            foreach (ObjectStateEntry item in context.ObjectStateManager.GetObjectStateEntries(EntityState.Modified | EntityState.Added))
            {
                if ((item.Entity as Inventory) != null)
                {
                    var entity = (Inventory)item.Entity;
                    if (entity.Color == "Red")
                    {
                        item.RejectPropertyChanges(nameof(entity.Color));
                    }
                }
            }
        }
        private void OnObjectMaterialized(object sender,
        System.Data.Entity.Core.Objects.ObjectMaterializedEventArgs e)
        { }



        public virtual DbSet<CreditRisk> CreditRisks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);
        }

        
    }
}
