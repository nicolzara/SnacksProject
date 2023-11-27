using Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ServiceModel
{
    public class ServiceSnack : IServiceSnack
    {
        public CityList GetAllCites()
        {
            CityDB db = new CityDB();
            CityList list = db.SelectAll();
            return list;
        }

        public SnacksList GetAllSnack()
        {
            SnacksDB db = new SnacksDB();
            SnacksList list = db.SelectAll();
            return list;
        }

        public UserList GetAllUsers()
        {
            UserDB db = new UserDB();
            UserList list = db.SelectAll();
            return list;
        }

        public SnacksList GetSnackByUser(User user)
        {
            SnacksDB db = new SnacksDB();
            SnacksList list = db.SelectbyUser(user);
            return list;
        }

        public UserList GetUserBysnack(Snacks snack)
        {
            UserDB db = new UserDB();
            UserList list = db.SelectbySnacks(snack);
            return list;
        }

        public User Login(User user)
        {
            UserDB db = new UserDB();
            return db.Login(user);
        }
    }
}
