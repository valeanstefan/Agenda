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
        
        public int evt_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Event")]
        public string evt_name { get; set; }

        [Display(Name = "Date")]
        public DateTime? evt_date { get; set; }

        [Display(Name = "Pacient")]
        public int? pac_id { get; set; }
    }
}
