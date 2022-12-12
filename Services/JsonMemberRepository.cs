using ProjektBoat.Helpers;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using Microsoft.Extensions.Logging;

namespace ProjektBoat.Services
{
    public class JsonMemberRepository : IMemberRepository
    {
        string JsonFileName = @"Data\jsonMemberInfo.json";

        public void AddMember(Member aMember)
        {
            List<Member> members = GetAllMembers();
            List<int> memberIDs = new List<int>();

            foreach (var mb in members)
            {
                memberIDs.Add(mb.ID);
            }
            if (memberIDs.Count != 0)
            {
                int start = memberIDs.Max();
                aMember.ID = start + 1;
            }
            else
            {
                aMember.ID = 1;
            }
            members.Add(aMember);
            JsonFileWriter.WritetoJsonMember(members, JsonFileName);
        }

        public List<Member> GetAllMembers()
        {
            return JsonFileReader.ReadJsonMember(JsonFileName);
        }

        public Member GetMember(int id)
        {
            foreach (var mb in GetAllMembers())
            {
                if (mb.ID == id)
                    return mb;
            }
            return new Member();
        }

        public Member GetMember(string name)
        {
            foreach (var mb in GetAllMembers())
            {
                if (mb.Name == name)
                    return mb;
            }
            return new Member();
        }

        public void UpdateMember(Member mb)
        {
            if (mb != null)
            {
                List<Member> members = GetAllMembers();
                foreach (Member m in members)
                {
                    if (m.ID == mb.ID)
                    {
                        m.ID = mb.ID;
                        m.Name = mb.Name;
                        m.Age = mb.Age;
                        m.PhoneNo = mb.PhoneNo;
                        m.Mail = mb.Mail;
                        m.Certificate = mb.Certificate;
                        m.Admin = mb.Admin;
                    }
                }
                JsonFileWriter.WritetoJsonMember(members, JsonFileName);
            }
        }

        public void DeleteMember(Member mb)
        {
            Member m = GetMember(mb.ID);
            List<Member> members = GetAllMembers();
            members.Remove(m);
            JsonFileWriter.WritetoJsonMember(members, JsonFileName);
        }

        public List<Member> FilterMembers(string filter)
        {
            List<Member> filteredList = new List<Member>();

            foreach (var m in GetAllMembers())
            {
                if (m.Name.Contains(filter))
                {
                    filteredList.Add(m);
                }
            }
            return filteredList;
        }
    }
}
