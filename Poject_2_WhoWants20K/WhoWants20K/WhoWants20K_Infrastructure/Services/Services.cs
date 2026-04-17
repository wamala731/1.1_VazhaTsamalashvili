using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Application.IServices;

namespace WhoWants20K_Infrastructure.Services
{
    public class Services<T> : IServices<T> where T : class
    {
        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }
        public T GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }
        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
