using System.Collections.Generic;
using System.Linq;
using LibrariesProblem.Data;
using LibrariesProblem.Entities;

namespace LibrariesProblem.Repositories
{
    public class MemberRepositories
    {
        public GenericResponse<List<Members>> GetAllMembers()
        {
            var Member = DataStore.Member;
            return new GenericResponse<List<Members>>
            {
                Success = true,
                Data = Member,
            };
        }
        public GenericResponse<Members> GetMembersByNameAndEmail(string Name, string email)
        {
            var Memberbyname = DataStore.Member.FirstOrDefault(x => x.Name == Name);
            var Memberbyemail = DataStore.Member.FirstOrDefault(x => x.Email == email);
            if (Memberbyname == null && Memberbyemail == null)
            {
                return new GenericResponse<Members>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }

            return new GenericResponse<Members>
            {
                Success = true,
                Data = Memberbyname

            };
        }
    }
}
