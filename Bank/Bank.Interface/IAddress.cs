using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;

namespace Bank.Interface
{
    public interface IAddress
    {
        void Insert(Address model);
        void Update(Address model);
        void Delete(int ID);
        Address SelectOne(int ID);
        IEnumerable<Address> SelectAll();
    }
}
