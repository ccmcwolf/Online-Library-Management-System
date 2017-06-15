using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace OnlineLibraryManagementSystem.DAO
{
    public class MemberDAO
    {
        public Boolean addMember(Member member)
        {
            Boolean status = false;
            try
            {
                using (var db = new LibraryDB())
                {

                    db.Members.Add(member);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return status;
        }

        public Boolean updateItem(Member member)
        {
            Boolean status = false;
            try
            {
                using (var db = new LibraryDB())
                {
                    Console.WriteLine("Member detail updated");
                    db.Members.AddOrUpdate(member);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update member problem " + ex.InnerException);
            }
            return status;
        }

        public List<Member> loadAllMembers()
        {
            List<Member> members = null;

            try
            {
                using (var db = new LibraryDB())
                {

                    members = db.Set<Member>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return members;
        }

        public Member findMemberByID(int memberID)
        {
            Member member = null;
            try
            {
                using (var db = new LibraryDB())
                {

                    member = db.Members.Find(memberID);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find member by id " + ex.InnerException);
            }
            return member;
        }

    }
}