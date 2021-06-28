using BusinessObject;
using System.Collections.Generic;
namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public MemberObject GetMemberByID(int memId) => MemberDAO.Instance.GetMemberByID(memId);
        public MemberObject GetMemberByName(string memName) => MemberDAO.Instance.GetMemberByName(memName);

        public IEnumerable<MemberObject> GetMembers()
        {
            return MemberDAO.Instance.GetMemberList();
        }
        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int memId) => MemberDAO.Instance.Remove(memId);
        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);

        public List<MemberObject> GetMemberByCityAndCountry(string city, string country) => MemberDAO.Instance.GetMemberByCityAndCountry(city, country);

    }
}
