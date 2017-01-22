using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agenda.Domain.Models
{
    public class EvenimentDto
    {

        [Display(Name = "Event Name: ")]
        public string evt_name { get; set; }

        [Display(Name = "Event Date: ")]
        public DateTime? evt_date { get; set; }

        [Display(Name = "Pacient Id: ")]
        public int? pac_id { get; set; }
    }
}