namespace Agenda.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pacient")]
    public partial class Pacient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pac_id { get; set; }

        [StringLength(100)]
        public string pac_name { get; set; }

        [StringLength(100)]
        public string pac_mail { get; set; }
    }
}
