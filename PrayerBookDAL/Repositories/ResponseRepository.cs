using System;
using System.Collections.Generic;
using System.Linq;
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
            return entity == null ? null : _context.Responses.Add(entity).Entity;
        }

        public IEnumerable<Response> GetAll()
        {
            return _context.Responses.ToList();
        }

        public Response Get(int id)
        {
            return _context.Responses.FirstOrDefault(r => r.Id == id);
        }

        public bool Delete(int id)
        {
            var responseToDelete = Get(id);
            if (responseToDelete == null) return false;
            var deletedResponse = _context.Responses.Remove(responseToDelete);
            if (deletedResponse == null) return false;
            return true;
        }
    }
}
