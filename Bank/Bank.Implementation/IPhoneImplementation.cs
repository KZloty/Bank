using Bank.Interface;
using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Implementation
{

    public class IPhoneImplementation : IPhone
    {

        private BankContext db = new BankContext();

        public void Insert(Phone model)
        {
            db.Phones.Add(model);
            db.SaveChanges();
        }

        public void Update(Phone model)
        {
            Phone foundModel =
                db.Phones
                .Where(a => a.PhoneID.Equals(model.PhoneID))
                .FirstOrDefault();

            if (foundModel == null)
                throw new Exception("Model not found");

            foundModel.PhoneID = model.PhoneID;
            foundModel.PhoneNumber = model.PhoneNumber;
            db.SaveChanges();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Phone> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Phone SelectOne(int ID)
        {
            throw new NotImplementedException();
        }

        
    }
}
