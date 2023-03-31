using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_OnlineSaling.Models.DAL
{
   public interface _IAllRepository<T>where T:class
    {
        IEnumerable<T> GetData();
        T GetDataById(Func<T,bool> Exp);
        void InsertData(T Data);
        void DeleteData(T Data);
        void UpdateData(T Data);
        void save();
    }
}
