using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DataAccess
{
    public class MemberDAO
    {

        //Initialize member list 
        /*private static List<MemberObject> MemberList = new List<MemberObject>();
                {
                     new MemberObject{MemberId=1, CompanyName="Khai", Email="khaintse151228@fpt.edu.vn",City="Ho Chi Minh", Country="Viet Nam", Password="12345678" },
                     new MemberObject{MemberId=2, CompanyName="Dêm", Email="Dêm@gmail.com",City="Ho Chi Minh", Country="United State", Password="123456789" },
                     new MemberObject{MemberId=3, CompanyName="James", Email="James@gmail.com",City="Ho Chi Minh", Country="Viet Nam", Password="12345678911" },
                     new MemberObject{MemberId=4, CompanyName="Jamez", Email="Jamez@gmail.com",City="Ho Chi Minh", Country="United State", Password="12345678978" },

                 };*/
        //--------------------------------------------------------------
        //Using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        //----------------------------------------------------------------
        public List<MemberObject> GetMemberList()
        {
            List<MemberObject> memberObjects;
            try
            {
                using StoreContext mem = new StoreContext();
                memberObjects = mem.MemberObjects.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return memberObjects;

        }
        //----------------------------------------------------------------
        public MemberObject GetMemberByID(int memberID)
        {
            List<MemberObject> MemberList = GetMemberList();

            //using LINQ to Object
            MemberObject member = MemberList.SingleOrDefault(pro => pro.MemberId == memberID);
            return member;
        }


        public MemberObject GetMemberByName(string memberName)
        {
            List<MemberObject> MemberList = GetMemberList();


            //using LINQ to Object
            MemberObject member = MemberList.SingleOrDefault(pro => pro.CompanyName == memberName);
            return member;
        }
        //-----------------------------------------------------------------
        //Add a new member
        public void AddNew(MemberObject member)
        {
            try
            {
                using StoreContext mem = new StoreContext();
                mem.MemberObjects.Add(member);
                mem.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //Update a member
        public void Update(MemberObject member)
        {
            try
            {
                using StoreContext mem = new StoreContext();
                mem.Entry<MemberObject>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                mem.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //------------------------------------------------------------------
        //Remove a member
        public void Remove(int MemberID)
        {
            try
            {
                using StoreContext mem = new StoreContext();
                var e = mem.MemberObjects.SingleOrDefault(m => m.MemberId == MemberID);
                mem.MemberObjects.Remove(e);
                mem.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<MemberObject> GetMemberByCityAndCountry(string city, string country)
        {
            List<MemberObject> FList = new List<MemberObject>();
            List<MemberObject> MemberList = GetMemberList();
            for (int i = 1; i <= MemberList.Count; i++)
            {
                if (MemberList[i - 1].City == city && MemberList[i - 1].Country == country) { FList.Add(MemberList[i - 1]); }
            }
            return FList;
        }
    }
}
