using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;

namespace ModelsLib
{
    internal class DBHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        private static readonly DataContext DataContext = new DataContext(connectionString);

        internal static T SelectOne<T>(Expression<Func<T, bool>> filter) where T: class
        {
            return DataContext.GetTable<T>().Where(filter).FirstOrDefault();
        }

        internal static void Insert<T>(T obj) where T : class
        {
            DataContext.GetTable<T>().InsertOnSubmit(obj);
            DataContext.SubmitChanges();
        }

        internal static void Update<T>(Expression<Func<T, bool>> filter, T obj) where T : class
        {
            var matchedObj = SelectOne(filter); 
            Utils.CopyPropertiesTo(obj, matchedObj);
            DataContext.SubmitChanges();
        }

        internal static void Delete<T>(Expression<Func<T, bool>> filter) where T : class
        {
            DataContext.GetTable<T>().DeleteOnSubmit(SelectOne(filter));
            DataContext.SubmitChanges(); 
        }

        internal static List<T> SelectAll<T>(Expression<Func<T, bool>> filter) where T : class
        {
            return DataContext.GetTable<T>().Where(filter).ToList();
        }

    }
}
