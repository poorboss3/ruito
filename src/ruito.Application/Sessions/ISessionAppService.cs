using System.Threading.Tasks;
using Abp.Application.Services;
using ruito.Sessions.Dto;

namespace ruito.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
