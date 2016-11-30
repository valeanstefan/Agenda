using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Domain.Models
{
    public interface IEvenimentManager:IBaseManager
    {
        EvenimentDto Find(int id);
        void Insert(EvenimentDto model);
        void Update(EvenimentDto model);
        void Delete(int id);
        List<Eveniment> All();        

    }
}
