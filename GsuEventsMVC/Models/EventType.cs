namespace GsuEventsMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventType")]
    public partial class EventType
    {
        [Key]
        public int EventTypeID { get; set; }

        public string EventTypes { get; set; }
    }
}
