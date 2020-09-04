using System;
using System.Collections.Generic;
using System.Text;

namespace _04Adapter
{
    public class Adapter2 : UserDAL, IDAL
    {
        public void Add(User user)
        {
            base.Save(user);
        }

        public void Delete(int id)
        {
            base.Remove(id);
        }

        public void Modify(User user)
        {
            base.Edit(user);
        }

        public List<User> Select()
        {
            return base.Get();
        }
    }
}
