using System.Collections.Generic;
using Adminer.Models;

namespace Adminer.Services
{
    public interface IAdminService
    {
        List<ApplicationDTO> GetApplicationsDB();
        List<EnvironmentDTO> GetEnvironmentsDB();
    }
}