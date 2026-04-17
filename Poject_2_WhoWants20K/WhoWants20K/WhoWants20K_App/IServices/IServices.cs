using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Application.IServices
{
    public interface IServices <T> where T : class
    {
        public List<T> GetAll();
        public T GetById(int id);
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(int id);
    }
}
