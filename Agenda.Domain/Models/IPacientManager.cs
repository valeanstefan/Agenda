using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Domain.Models
{
    public interface IPacientManager: IBaseManager
    {
        PacientDto Find(int id);
        void Insert(PacientDto model);
        void Update(PacientDto model);
        void Delete(int id);
    }
}
