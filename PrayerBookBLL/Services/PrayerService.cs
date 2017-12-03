using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrayerBookBLL.BusinessObjects;
using PrayerBookBLL.Converters;
using PrayerBookBLL.Interfaces;
using PrayerBookDAL.Entities;
using PrayerBookDAL.Interfaces;

namespace PrayerBookBLL.Services
{
    internal class PrayerService : IPrayerService
    {
        private readonly IDALFacade _facade;
        private readonly IConverter<PrayerBO, Prayer> _prayerConverter;
        private readonly IConverter<ResponseBO, Response> _reponseConverter;

        public PrayerService(IDALFacade facade)
        {
            _facade = facade;
            _prayerConverter = new PrayerConverter();
            _reponseConverter = new ResponseConverter();
        }

        public PrayerBO Create(PrayerBO businessObject)
        {
            if (businessObject == null) return null;
            using (var uow = _facade.UnitOfWork)
            {
                var createdPrayer = uow.PrayerRepository.Create(_prayerConverter.Convert(businessObject));
                uow.Complete();
                return _prayerConverter.Convert(createdPrayer);
            }
        }

        public IEnumerable<PrayerBO> GetAll()
        {
            using (var uow = _facade.UnitOfWork)
            {
                return uow.PrayerRepository.GetAll().Select(_prayerConverter.Convert).ToList();
            }
        }

        public PrayerBO Get(int id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var prayer = uow.PrayerRepository.Get(id);
                if (prayer == null) return null;
                var prayerBO = _prayerConverter.Convert(prayer);
                var responses = uow.ResponseRepository.GetAll().Where(r => r.PrayerId == prayerBO.Id)
                    .Select(_reponseConverter.Convert).ToList();
                prayerBO.Responses = responses;
                return prayerBO;
            }
        }

        public PrayerBO Update(PrayerBO businessObject)
        {
            if (businessObject == null) return null;
            using (var uow = _facade.UnitOfWork)
            {
                var prayer = uow.PrayerRepository.Get(businessObject.Id);
                if (prayer == null) return null;
                prayer.Subject = businessObject.Subject;
                uow.Complete();
                return _prayerConverter.Convert(prayer);
            }
        }

        public bool Delete(int id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var prayer = uow.PrayerRepository.Get(id);
                if (prayer == null) return false;
                var response = uow.PrayerRepository.Delete(id);
                uow.Complete();
                return response;
            }
        }
    }
}
