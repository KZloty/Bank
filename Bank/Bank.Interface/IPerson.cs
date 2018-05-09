using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;

namespace Bank.Interface
{
    public interface IPerson
    {
        void Insert(Person model);
        void Update(Person model);
        void Delete(int ID);
        Person SelectOne(int ID);
        IEnumerable<Person> SelectAll();
    }
}
