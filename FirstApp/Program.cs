using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            IUpdater<User> updater = new UserService();

            //контравариантность
            IUpdater<Account> updater1 = new UserService();

            Console.ReadKey();
        }
    }

    public class User
    {

    }

    public class Account : User
    {

    }

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    public class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
