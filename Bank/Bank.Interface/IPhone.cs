using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;

namespace Bank.Interface
{
    public interface IPhone
    {
        void Insert(Phone model);
        void Update(Phone model);
        void Delete(int ID);
        Phone SelectOne(int ID);
        IEnumerable<Phone> SelectAll();
    }
}
