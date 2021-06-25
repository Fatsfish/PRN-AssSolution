using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberByID(int memId);
        MemberObject GetMemberByName(string memName);
        void InsertMember(MemberObject member);
        void DeleteMember(int memId);
        void UpdateMember(MemberObject member);
        List<MemberObject> GetMemberByCityAndCountry(string text1, string text2);
    }
}
