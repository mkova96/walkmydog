using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkMyDog.Model.Repositories
{
    public interface IUserRepository
    {
        bool AddUser(User User);
        bool DeleteUser(User User);
        bool DeleteUser(int Id);
        bool DeleteUser(string Username, string Password);
        Admin GetAdmin(int Id);

        Walker GetWalker(int Id);
        Owner GetOwner(int Id);

        Admin GetAdmin(string Username, string Password);
        Walker GetWalker(string Username, string Password);
        Owner GetOwner(string Username, string Password);
        IList<Walker> GetAllWalkers();
        IList<Owner> GetAllOwners();
        bool UpdateUser(User User);



    }
}
