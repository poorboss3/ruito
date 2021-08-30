using System.Threading.Tasks;
using ruito.Configuration.Dto;

namespace ruito.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
