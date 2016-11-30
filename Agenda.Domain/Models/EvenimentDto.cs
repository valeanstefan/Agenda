using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agenda.Domain.Models
{
    public class EvenimentDto
    {
        public int evt_id { get; set; }

        public string evt_name { get; set; }

        public DateTime? evt_date { get; set; }

        public int? pac_id { get; set; }
    }
}