using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookBLL.Interfaces
{
    public interface IConverter<TBusinessObject, TEntity>
    {
        TBusinessObject Convert(TEntity entity);
        TEntity Convert(TBusinessObject bo);
    }
}
