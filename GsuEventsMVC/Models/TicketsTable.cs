namespace GsuEventsMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketsTable")]
    public partial class TicketsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TicketsTable()
        {
            PaymentHistoryTables = new HashSet<PaymentHistoryTable>();
        }

        [Key]
        public int TicketID { get; set; }

        public int TicketQuantity { get; set; }

        public int TicketPrice { get; set; }

        public int EventID { get; set; }

        public int UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ModfiedDate { get; set; }

        public int TicketsPurchased { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int TicketsRemining { get; set; }

        public int isDelete { get; set; }

        public virtual EventsTable EventsTable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistoryTable> PaymentHistoryTables { get; set; }
    }
}
