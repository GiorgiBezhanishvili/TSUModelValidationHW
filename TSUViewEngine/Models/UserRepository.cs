using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSUViewEngine.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> Users();
        void Create(User user);

        bool ExistsEmail(string email);
        bool PasswordConfirmation(string pass1,string pass2);
    }

    public class UserRepository : IUserRepository
    {
        private List<User> Data = new List<User>()
        {
            new User(1,"giorgi","bezhanishvili","gio@gmail.com","123456789"),
            new User(2,"michael","scott","michael@dundermifflin.com","bestboss#1"),
            new User(3,"dwight","shrute","dwight@dundermifflin.com","bestemployee4ever"),
            new User(4,"jim","halpert","jim@dundermifflin.com","pampam12"),
        };

        public IEnumerable<User> Users()
        {
            return Data.AsEnumerable();
        }

        public void Create(User user)
        {
            var us = Data.OrderBy(x => x.Id).LastOrDefault();
            user.Id = us != null ? us.Id + 1 : 1;
            Data.Add(user);
        }

        public bool ExistsEmail(string email)
        {
            var em = Data.Find(e => e.Email == email);

            var res = em != null ? true : false;

            return res;
        }

        public bool PasswordConfirmation(string pass1, string pass2)
        {
            var ans = pass1 == pass2 ? true : false;
            return ans;
        }
    }
}
