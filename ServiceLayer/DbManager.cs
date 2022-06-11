using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class DbManager<T, K>
    {
        IDB<T, K> context;

        public DbManager(IDB<T, K> context)
        {
            this.context = context;
        }

        public void Create(T item)
        {
            try
            {
                context.Create(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T Read(K key)
        {
            try
            {
                return context.Read(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<T> ReadAll()
        {
            try
            {
                return context.ReadAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(T item)
        {
            try
            {
                context.Update(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(K key)
        {
            try
            {
                context.Delete(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
