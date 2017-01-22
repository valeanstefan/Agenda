using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agenda.Domain.Models
{
    public class PacientDto
    {
        
        public int pac_id { get; set; }
        [Display(Name ="Full Name")]
        public string pac_name { get; set; }
        [Display(Name ="E-mail")]
        public string pac_mail { get; set; }
    }
}