using System;
using System.Collections.Generic;
using System.Text;

namespace _04Adapter
{
    public interface IDAL
    {
        void Add(User user);
        void Modify(User user);
        void Delete(int id);
        List<User> Select();
    }
}
