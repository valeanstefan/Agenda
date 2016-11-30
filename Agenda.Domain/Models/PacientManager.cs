using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Omu.ValueInjecter;

namespace Agenda.Domain.Models
{
    public class PacientManager : IPacientManager
    {
        private IRepository<Pacient> _pacientRepository;

        public PacientManager(IRepository<Pacient> repository)
        {
            this._pacientRepository = repository;
        }
        public void Delete(int id)
        {
            Pacient model = _pacientRepository.Find(id);
            _pacientRepository.Delete(model);
            _pacientRepository.SaveChanges();
        }

        public void Dispose()
        {
            _pacientRepository.Dispose();
        }

        public PacientDto Find(int id)
        {
            PacientDto model = null;
            Pacient entity = _pacientRepository.Find(id);

            if (entity != null)
            {
                model = Mapper.Map<PacientDto>(entity);
            }
            return model;
        }

        public void Insert(PacientDto model)
        {
            if (model == null) return;
            var entity = Mapper.Map<Pacient>(model);

            _pacientRepository.Insert(entity);
            _pacientRepository.SaveChanges();
        }

        public void Update(PacientDto model)
        {
            if (model == null) return;

            var entity = Mapper.Map<Pacient>(model);

            _pacientRepository.Update(entity);
            _pacientRepository.SaveChanges();

        }
    }
}