using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace External_OnlineSaling.Models.DAL
{
    public class AllRepository<T> : _IAllRepository<T> where T : class
    {
        private DataContextDataContext _context;

        public AllRepository() => _context = new DataContextDataContext();
        public void DeleteData(T data) {
           
            _context.GetTable<T>().DeleteOnSubmit(data);
        } /*=> _context.GetTable<T>().DeleteOnSubmit(id);*/

        public IEnumerable<T> GetData() => _context.GetTable<T>();

        public T GetDataById(Func<T,bool> exp)
        {
            //var table = _context.GetTable<T>();
            //MetaModel modelMap = table.Context.Mapping;
            //ReadOnlyCollection<MetaDataMember> dataMembers = modelMap.GetMetaType(typeof(T)).DataMembers;

            //string pk = dataMembers.Single<MetaDataMember>(m => m.IsPrimaryKey).Name;




            //return _context.GetTable<T>().SingleOrDefault<T>(delegate (T t){
            //    String memberId = t.GetType().GetProperty(pk).GetValue(t, null).ToString();
            //    return memberId.ToString() == id.ToString();


            //});
            return _context.GetTable<T>().Where(exp).FirstOrDefault();
        }

        public void InsertData(T Data) => _context.GetTable<T>().InsertOnSubmit(Data);

        public void save()=> _context.SubmitChanges();
       

        public void UpdateData(T Data) => _context.GetTable<T>().InsertOnSubmit(Data);
        
    }
}