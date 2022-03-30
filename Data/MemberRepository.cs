using Data.DB;
using Data.Entities;

namespace Data
{
    public class MemberRepository
    {
        public MemberRepository()
        {
            this.GenerateFakeData();
        }

        private void GenerateFakeData()
        {
            LocalMemoryDB.MembersContext.Add(new Member() { ID = 0000, FirstName = "no", SecondName = "no" });
            LocalMemoryDB.MembersContext.Add(new Member() { ID = 5000, FirstName = "Juan", SecondName = "Perez" });
            LocalMemoryDB.MembersContext.Add(new Member() { ID = 5001, FirstName = "Pedro", SecondName = "Flores" });
        }

        public Member GetMember(int id)
        {

            foreach(Member item in LocalMemoryDB.MembersContext)
            {
                if (item.ID != id)
                {
                    id = 0000;
                }

                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
