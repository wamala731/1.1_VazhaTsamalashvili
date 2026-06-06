using System;
using System.Collections.Generic;
using System.Text;
using WinForms_QuizApp_Application.Interfaces;

namespace WinForms_QuizApp_Infrastructure.Services
{
    public class Services<T> : IService<T> where T : class
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
