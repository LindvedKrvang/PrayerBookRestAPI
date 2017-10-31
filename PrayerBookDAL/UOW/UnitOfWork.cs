using System;
using System.Collections.Generic;
using System.Text;
using PrayerBookDAL.Context;
using PrayerBookDAL.Interfaces;
using PrayerBookDAL.Repositories;

namespace PrayerBookDAL.UOW
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly PrayerBookContext _context;

        public UnitOfWork(PrayerBookContext context)
        {
            _context = context;

            PrayerRepository = new PrayerRepository();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IPrayerRepository PrayerRepository { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
