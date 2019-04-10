namespace GsuEventsMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventsTable")]
    public partial class EventsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventsTable()
        {
            EventDetails = new HashSet<EventDetail>();
            PaymentHistoryTables = new HashSet<PaymentHistoryTable>();
            TicketsTables = new HashSet<TicketsTable>();
        }

        [Key]
        public int EventID { get; set; }

        [Required]
        public string EventLocation { get; set; }

        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }

        [Required]
        [StringLength(50)]
        public string EventType { get; set; }

        [Required]
        public string EventImage { get; set; }

        public string EventTitle { get; set; }

        public int UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ModifiedDate { get; set; }

        public int isDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventDetail> EventDetails { get; set; }

        public virtual UserModel UserTable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistoryTable> PaymentHistoryTables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketsTable> TicketsTables { get; set; }
    }
}
