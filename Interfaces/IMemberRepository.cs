using ProjektBoat.Models;
using Microsoft.Extensions.Logging;

namespace ProjektBoat.Interfaces
{
    public interface IMemberRepository
    {
        List<Member> GetAllMembers();

        Member GetMember(int id);

        Member GetMember(string name);
       
        void AddMember(Member mb);
        
        void UpdateMember(Member mb);

        void DeleteMember(Member mb);

        List<Member> FilterMembers(string name);
    }
}

