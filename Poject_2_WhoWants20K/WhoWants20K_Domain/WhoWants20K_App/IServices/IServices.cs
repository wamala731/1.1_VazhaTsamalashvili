using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Application.IServices
{
    public interface IServices <T> where T : class
    {
        public void Create(T entity);
        public void Read(int id);
        public void Update(int id, T entity);
        public void Delete(int id);
    }
}
