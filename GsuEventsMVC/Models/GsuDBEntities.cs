namespace GsuEventsMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GsuDBEntities : DbContext
    {
        public GsuDBEntities()
            : base("name=GsuDBEntities")
        {
        }

        public virtual DbSet<EventDetail> EventDetails { get; set; }
        public virtual DbSet<EventsTable> EventsTables { get; set; }
        public virtual DbSet<PaymentHistoryTable> PaymentHistoryTables { get; set; }
        public virtual DbSet<PaymentTable> PaymentTables { get; set; }
        public virtual DbSet<RoleTable> RoleTables { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TicketsTable> TicketsTables { get; set; }
        public virtual DbSet<UserModel> UserTables { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentHistoryTable>()
                .Property(e => e.UserTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<UserModel>()
                .Property(e => e.isActive)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
