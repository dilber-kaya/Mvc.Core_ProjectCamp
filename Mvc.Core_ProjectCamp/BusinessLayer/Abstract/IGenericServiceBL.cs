using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericServiceBL<T>
    {
        void TAddBL(T t);
        void TDeleteBL(T t);
        void TUpdateBL(T t);
        List<T> ListBL();
        T GetByIdBL(int id);
    }
}
