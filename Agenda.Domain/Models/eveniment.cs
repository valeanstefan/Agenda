namespace Agenda.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("eveniment")]
    public partial class Eveniment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int evt_id { get; set; }

        public string evt_name { get; set; }

        public DateTime? evt_date { get; set; }

        public int? pac_id { get; set; }
    }
}
