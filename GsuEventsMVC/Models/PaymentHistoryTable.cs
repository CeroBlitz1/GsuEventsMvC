namespace GsuEventsMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentHistoryTable")]
    public partial class PaymentHistoryTable
    {
        [Key]
        public int PaymentHistoryID { get; set; }

        [Required]
        [StringLength(3)]
        public string UserTypeID { get; set; }

        public int UserID { get; set; }

        public int PaymentID { get; set; }

        public int TicketsPurchased { get; set; }

        public string UserPaymentPaid { get; set; }

        public int TicketID { get; set; }

        public int EventID { get; set; }

        public int isDelete { get; set; }

        public virtual EventsTable EventsTable { get; set; }

        public virtual PaymentTable PaymentTable { get; set; }

        public virtual TicketsTable TicketsTable { get; set; }

        public virtual UserModel UserTable { get; set; }
    }
}
