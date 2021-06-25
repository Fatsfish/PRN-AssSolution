using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public MemberObject GetMemberByID(int memId) => MemberDAO.Instance.GetMemberByID(memId);
        public MemberObject GetMemberByName(string memName) => MemberDAO.Instance.GetMemberByName(memName);

        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList;
        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int memId) => MemberDAO.Instance.Remove(memId);
        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);

        public List<MemberObject> GetMemberByCityAndCountry(string city, string country) => MemberDAO.Instance.GetMemberByCityAndCountry(city,country);

    }
}
