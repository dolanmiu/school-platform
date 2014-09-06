using Nancy.Security;
using Backend.Repositories;
using System.Linq;

namespace Backend
{
    public interface IUserValidator
    {
        IUserIdentity ValidateUser(string username, string password);
    }

    public class UserValidator : IUserValidator
    {
        private IUserRepository _userRepository;

        public UserValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IUserIdentity ValidateUser(string username, string password)
        {
            return new UserIdentity { UserName = username, Claims = Enumerable.Empty<string>() };
        }
    }
}