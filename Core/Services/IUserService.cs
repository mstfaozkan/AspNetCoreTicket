using Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public interface IUserService
    {
        UserManager<AppUser> GetService();
    }
}
