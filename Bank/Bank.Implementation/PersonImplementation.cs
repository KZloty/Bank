using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Interface;

namespace Bank.Implementation
{
    public class PersonImplementation : IPerson
    {
        private BankContext db = new BankContext();


        public void Insert(Person model)
        {
            db.People.Add(model);
            db.SaveChanges();
        }

        public void Update(Person model)
        {
            Person foundModel =
                db.People
                .Where(a => a.PersonID.Equals(model.PersonID))
                .FirstOrDefault();

            if (foundModel == null)
                throw new Exception("Model not found");

            foundModel.PersonID = model.PersonID;
            foundModel.LastName = model.LastName;
            foundModel.FirstName = model.FirstName;
            foundModel.MiddleName = model.MiddleName;
            foundModel.PESEL = model.PESEL;
            //foundModel.Addresses = model.Addresses;
            foundModel.Phones = model.Phones;
            //foundModel.Emails = model.Emails;
            db.SaveChanges();
        }


        public void Delete(int ID)
        {
            Person foundModel =
                db.People
                .Where(a => a.PersonID.Equals(ID))
                .FirstOrDefault();

            if (foundModel == null)
                throw new Exception("Model not found");

            db.People.Remove(foundModel);
            db.SaveChanges();
        }

        public Person SelectOne(int ID)
        {
            return db.People
                    .Where(a => a.PersonID.Equals(ID))
                    .FirstOrDefault();
        }

        public IEnumerable<Person> SelectAll()
        {
            return db.People.AsEnumerable();
        }
    }
}
