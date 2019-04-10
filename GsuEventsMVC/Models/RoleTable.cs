namespace GsuEventsMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleTable")]
    public partial class RoleTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoleTable()
        {
            UserTables = new HashSet<UserModel>();
        }

        [Key]
        public int UserTypeID { get; set; }

        [Required]
        [StringLength(3)]
        public string UsterTypeCode { get; set; }

        [Required]
        [StringLength(10)]
        public string UserTypeDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserModel> UserTables { get; set; }
    }
}
