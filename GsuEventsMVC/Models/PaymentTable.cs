namespace GsuEventsMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentTable")]
    public partial class PaymentTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentTable()
        {
            PaymentHistoryTables = new HashSet<PaymentHistoryTable>();
        }

        [Key]
        public int PaymentID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public string UserEmail { get; set; }

        public string UserPhoneNumber { get; set; }

        public string UserCardNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime UserCardExpiration { get; set; }

        public int UserCardCVV { get; set; }

        public string UserAddress { get; set; }

        public string UserZipCode { get; set; }

        [StringLength(50)]
        public string UserState { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifiedDate { get; set; }

        public int UserID { get; set; }

        public int isDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistoryTable> PaymentHistoryTables { get; set; }

        public virtual UserModel UserTable { get; set; }
    }
}
