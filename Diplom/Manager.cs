using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Diplom
{
    class Manager
    {
        public static Frame MainFrame { get; set; }

        public void AddPerson(string Name, string Familiya, string Vozrast)
        {
            using (TastyDinnerEntities reg = new TastyDinnerEntities())
            {
                reg.User.Add(new User
                {
                    Type = 1,
                    Name = Name,
                    Login = Familiya,
                    Password = Vozrast
                });
                reg.SaveChanges();
            }

        }
    }
}
