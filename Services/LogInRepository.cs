using ProjektBoat.Models;
namespace ProjektBoat.Services {
    public class LogInRepository {
        private Member _memberLogIn;

        public void MemberLogIn(Member member) {
            _memberLogIn = member;
        }
        public void MemberLogOut() {
            _memberLogIn = null;
        }
        public Member GetLoggedMember() { 
            return _memberLogIn; 
        }
    }
}
