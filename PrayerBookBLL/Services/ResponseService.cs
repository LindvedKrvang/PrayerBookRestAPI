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
    internal class ResponseService : IResponseService
    {
        private IDALFacade _facade;
        private readonly IConverter<ResponseBO, Response> _responseConverter;

        public ResponseService(IDALFacade facade)
        {
            _facade = facade;
            _responseConverter = new ResponseConverter();

        }
        public ResponseBO Create(ResponseBO businessObject)
        {
            if (businessObject == null) return null;
            using (var uow = _facade.UnitOfWork)
            {
                var createdResponse = uow.ResponseRepository.Create(_responseConverter.Convert(businessObject));
                return _responseConverter.Convert(createdResponse);
            }
        }

        public IEnumerable<ResponseBO> GetAll()
        {
            using (var uow = _facade.UnitOfWork)
            {
                return uow.ResponseRepository.GetAll().Select(_responseConverter.Convert);
            }
        }

        public ResponseBO Get(int id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var response = _responseConverter.Convert(uow.ResponseRepository.Get(id));
                return response ?? null;
            }
        }

        public ResponseBO Update(ResponseBO businessObject)
        {
            if (businessObject == null) return null;
            using (var uow = _facade.UnitOfWork)
            {
                var responseToUpdate = uow.ResponseRepository.Get(businessObject.Id);
                if (responseToUpdate == null) return null;

                responseToUpdate.Answer = businessObject.Answer;
                responseToUpdate.PrayerId = businessObject.PrayerId;
                responseToUpdate.ResponseNumber = businessObject.ResponseNumber;

                uow.Complete();

                return _responseConverter.Convert(responseToUpdate);
            }
        }

        public bool Delete(int id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var responseDeleted = uow.ResponseRepository.Delete(id);
                uow.Complete();
                return responseDeleted;
            }
        }
    }
}
