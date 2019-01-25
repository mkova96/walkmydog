using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkMyDog.Model;
using WalkMyDog.Model.Repositories;

namespace WalkMyDog.MemoryBasedDAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {

        }
        public bool AddUser(User User)
        {
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {

                        session.Save(User);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();
                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return false;
                }

            }
            return true;
        }
        public bool DeleteUser(User User)
        {
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {

                        session.Delete(User);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return false;
                }

            }
            return true;
        }
        public bool DeleteUser(int Id)
        {
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        User user = session.Get<User>(Id);
                        session.Delete(user);

                        transaction.Commit();
                    }
                    session.Clear();
                    // session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return false;
                }

            }
            return true;

        }

        public bool DeleteUser(string Username)
        {
            User User = GetUser<User>(Username);
            return DeleteUser(User);

        }

        public Walker GetWalker(int Id)
        {
            return GetUser<Walker>(Id);
        }
        public Owner GetOwner(int Id)
        {
            return GetUser<Owner>(Id);
        }
        private T GetUser<T>(int Id) where T : User
        {
            T User = default(T);
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        // User = session.QueryOver<User>().Where(c => c.Id == Id)
                        //    .And(c => c is T).SingleOrDefault();
                        User = (T)session.Get(typeof(T), Id);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return User;
                }
            }
            return User;
        }

        private T GetUser<T>(string Username, string Password) where T : User

        {
            T User = default(T);
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {


                        User = session.QueryOver<T>().Where(c => c.Username == Username)
                            .And(c => c.Password == Password).SingleOrDefault();
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return null;
                }
            }
            return User;
        }





        public Walker GetWalker(string Username)
        {
            return (Walker)GetUser<Walker>(Username);
        }
        public Owner GetOwner(string Username)
        {
            return (Owner)GetUser<Owner>(Username);
        }

        public Walker GetWalker(string Username,string Password)
        {
            return (Walker)GetUser<Walker>(Username,Password);
        }
        public Owner GetOwner(string Username, string Password)
        {
            return (Owner)GetUser<Owner>(Username,Password);
        }

        private T GetUser<T>(string Username) where T : User

        {
            T User = default(T);
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {


                        User = session.QueryOver<T>().Where(c => c.Username == Username).SingleOrDefault();
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return null;
                }
            }
            return User;
        }

        private IList<T> GetAllUsers<T>() where T : User
        {
            IList<T> Users = null;
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        Users = session.QueryOver<T>().List();
                        transaction.Commit();
                    }
                    session.Clear();
                    // session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return null;
                }
            }
            return Users;

        }
        public IList<Owner> GetAllOwners()
        {
            return GetAllUsers<Owner>();
        }
        public IList<Walker> GetAllWalkers()
        {
            return GetAllUsers<Walker>();
        }
        public bool UpdateUser(User User)
        {
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {

                        session.Update(User);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return false;
                }

            }
            return true;
        }

        public bool UpdateWalker(Walker User)
        {
            using (var session = NHibernateService.OpenSession())
            {
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {

                        session.Update(User);
                        transaction.Commit();
                    }
                    session.Clear();
                    //session.Close();

                }
                catch (Exception e)
                {
                    Logger.Log(e);
                    return false;
                }

            }
            return true;
        }
    }
}
