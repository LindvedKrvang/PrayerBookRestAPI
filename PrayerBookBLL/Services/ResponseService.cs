using System;
using System.Collections.Generic;
using System.Text;
using PrayerBookBLL.BusinessObjects;
using PrayerBookBLL.Interfaces;
using PrayerBookDAL.Interfaces;

namespace PrayerBookBLL.Services
{
    internal class ResponseService : IResponseService
    {
        private IDALFacade _facade;

        public ResponseService(IDALFacade facade)
        {
            _facade = facade;
        }
        public ResponseBO Create(ResponseBO businessObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ResponseBO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseBO Get(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseBO Update(ResponseBO businessObject)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
