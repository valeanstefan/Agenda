using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Omu.ValueInjecter;
namespace Agenda.Domain.Models
{
    public class EvenimentManager : IEvenimentManager
    {
        private IRepository<Eveniment> _evenimentRepository;

        public EvenimentManager(IRepository<Eveniment> repository)
        {
            this._evenimentRepository = repository;
        }
        public void Delete(int id)
        {
            Eveniment model = _evenimentRepository.Find(id);
            _evenimentRepository.Delete(model);
            _evenimentRepository.SaveChanges();
        }

        public void Dispose()
        {
            _evenimentRepository.Dispose();
        }

        public EvenimentDto Find(int id)
        {
            EvenimentDto model = null;
            Eveniment entity = _evenimentRepository.Find(id);

            if (entity != null)
            {
                model = Mapper.Map<EvenimentDto>(entity);
            }
            return model;

        }

        public void Insert(EvenimentDto model)
        {
            if (model == null) return;
            var entity = Mapper.Map<Eveniment>(model);

            _evenimentRepository.Insert(entity);
            _evenimentRepository.SaveChanges();
        }

        public void Update(EvenimentDto model)
        {
            if (model == null) return;

            var entity = Mapper.Map<Eveniment>(model);

            _evenimentRepository.Update(entity);
            _evenimentRepository.SaveChanges();

        }
        public List<Eveniment> All()
        {
            return _evenimentRepository.All().ToList();
        } 
    }
}