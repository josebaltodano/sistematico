using domain.Activo;
using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Interfaces
{
   public   interface IModel<T>
    {
        void Create( T t);
        void Add(T t);
        T[] FindAll();

       
    }
}
