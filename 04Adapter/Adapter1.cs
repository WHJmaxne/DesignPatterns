using System;
using System.Collections.Generic;
using System.Text;

namespace _04Adapter
{
    public class Adapter1 : IDAL
    {
        private readonly UserDAL _dal;
        public Adapter1()
        {
            _dal = new UserDAL();
        }
        public void Add(User user)
        {
            _dal.Save(user);
        }

        public void Delete(int id)
        {
            _dal.Remove(id);
        }

        public void Modify(User user)
        {
            _dal.Edit(user);
        }

        public List<User> Select()
        {
            return _dal.Get();
        }
    }
}
