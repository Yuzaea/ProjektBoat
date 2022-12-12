using ProjektBoat.Models;
namespace ProjektBoat.Services {
    public class LogInRepository {
        private User _UserLogIn;

        public void UserLogIn(User user) {
            _UserLogIn = user;
        }
        public void UserLogOut() {
            _UserLogIn = null;
        }
        public User GetLoggedUser() { 
            return _UserLogIn; 
        }
    }
}
