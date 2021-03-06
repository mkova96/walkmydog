﻿using System;
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
        bool DeleteUser(string Username);

        Walker GetWalker(int Id);
        Owner GetOwner(int Id);

        Walker GetWalker(string Username);
        Owner GetOwner(string Username);

        Walker GetWalker(string Username,string Password);
        Owner GetOwner(string Username, string Password);
        IList<Walker> GetAllWalkers();
        IList<Owner> GetAllOwners();
        bool UpdateUser(User User);
        bool UpdateWalker(Walker User);




    }
}
