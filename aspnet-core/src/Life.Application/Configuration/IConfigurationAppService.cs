using System.Threading.Tasks;
using Life.Configuration.Dto;

namespace Life.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
