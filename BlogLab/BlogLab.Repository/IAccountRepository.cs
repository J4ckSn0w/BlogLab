using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

using BlogLabModels.Account;

namespace BlogLab.Repository
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> CreateAsync(ApplicationUserIdentity user,
            CancellationToken cancellationToken);

        public Task<ApplicationUserIdentity> GetByUsernameAsync(string normalizedUsername,
            CancellationToken cancellationToken);
    }
}
