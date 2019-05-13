using Core.Entities.Authentication;
using Core.Entities.Login;
using Core.Services;
using Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Application.Authentication
{
    public class AuthenticationHandler : IAuthorizationHandler, IAuthentication
    {

        private readonly AppDbContext appDbContext;

        public AuthenticationHandler()
        {

        }

        public AuthenticationHandler(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        async Task<TeacherAccount> IAuthentication.FindTeacherAccount(string userName, string password)
        {
            return await appDbContext.Set<TeacherAccount>()
                                      .FirstOrDefaultAsync(f => f.TeacherAccountName == userName && f.Password == password);
        }

        async Task<User> IAuthentication.FindUserAccount(string userName, string password)
        {
            return await appDbContext.Set<User>()
                                      .FirstOrDefaultAsync(f => f.UserName == userName && f.Password == password);
        }

        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}
