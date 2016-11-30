using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.Domain.Models
{
    public class ConnectionFactory : IConnectionFactory
    {
        public string ConnectionString
        {
            get { return "Agenda"; }
        }
    }
}