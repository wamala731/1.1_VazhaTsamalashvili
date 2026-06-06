using System;
using System.Collections.Generic;
using System.Text;

namespace WinForms_QuizApp_Application.Interfaces
{
    public interface IService<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
