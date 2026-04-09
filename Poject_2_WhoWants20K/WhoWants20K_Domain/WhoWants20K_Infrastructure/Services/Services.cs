using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Application.IServices;

namespace WhoWants20K_Infrastructure.Services
{
    internal class Services<T> : IServices<T> where T : class
    {
        public void Create(T entity)
        {
            T newEntity = entity;
        }
        public void Read(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
