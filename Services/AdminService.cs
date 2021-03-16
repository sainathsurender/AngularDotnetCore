using System.Collections.Generic;
using System.Linq;
using Adminer.Context;
using Adminer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Adminer.Services
{
    public class AdminService : IAdminService
    {
        public List<ApplicationDTO> GetApplicationsDB()
        {
            using(AdminContext adminContext = new AdminContext())
            {
                return adminContext.tblApplication.ToList();
            }
        }

        public List<EnvironmentDTO> GetEnvironmentsDB()
        {
            using(AdminContext adminContext = new AdminContext())
            {
                return adminContext.tblEnvironment.ToList();
            }
        }
    }
}
