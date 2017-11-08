using System;
using System.Collections.Generic;
using System.Text;
using PrayerBookDAL.Context;
using PrayerBookDAL.Entities;
using PrayerBookDAL.Interfaces;

namespace PrayerBookDAL.Repositories
{
    internal class ResponseRepository : IResponseRepository
    {
        private PrayerBookContext _context;

        public ResponseRepository(PrayerBookContext context)
        {
            _context = context;
        }
        public Response Create(Response entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Response> GetAll()
        {
            throw new NotImplementedException();
        }

        public Response Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
