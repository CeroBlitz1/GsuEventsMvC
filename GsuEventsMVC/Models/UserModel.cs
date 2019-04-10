namespace GsuEventsMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTable")]
    public partial class UserModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserModel()
        {
            EventDetails = new HashSet<EventDetail>();
            EventsTables = new HashSet<EventsTable>();
            PaymentHistoryTables = new HashSet<PaymentHistoryTable>();
            PaymentTables = new HashSet<PaymentTable>();
        }

        [Key]
        public int UserID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string UserPassword { get; set; }
        [Required]
        [Display(Name = "User name")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string UserEmail { get; set; }
        [DisplayName("Phone Number")]
        public string UserPhoneNumber { get; set; }

        [StringLength(1)]
        public string isActive { get; set; }

        public int UserTypeID { get; set; }

        


        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ModifiedDate { get; set; }

        public int isDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventDetail> EventDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventsTable> EventsTables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistoryTable> PaymentHistoryTables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentTable> PaymentTables { get; set; }

        public virtual RoleTable RoleTable { get; set; }
       
    }
}
