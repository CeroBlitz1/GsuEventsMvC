namespace GsuEventsMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EventDetail
    {
        [Key]
        public int EventDetailsID { get; set; }

        [Required]
        public string EventsDescription { get; set; }

        public int UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ModifiedDate { get; set; }

        public int EventID { get; set; }

        public int isDelete { get; set; }

        public virtual EventsTable EventsTable { get; set; }

        public virtual UserModel UserTable { get; set; }
    }
}
