using AutoMapper;
using DocumentManagementSystem.Business.Mappings.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Business.Helpers
{
    public class ProfileHelper
    {
        public static List<Profile> GetProfiles()
        {
            return new List<Profile>
            {
                new DocumentProfile(),
                new AppUserProfile(),
                new DepartmentProfile(),
                new AppRoleProfile(),
            };

        }
    }
}
