using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookBLL.Interfaces
{
    public interface IService<TBusinessObject>
    {
        TBusinessObject Create(TBusinessObject businessObject);
        IEnumerable<TBusinessObject> GetAll(); 
        TBusinessObject Get(int id);
        TBusinessObject Update(TBusinessObject businessObject);
        bool Delete(int id);
    }
}
