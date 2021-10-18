using System.Threading.Tasks;
using Abp.Application.Services;
using Life.Sessions.Dto;

namespace Life.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
