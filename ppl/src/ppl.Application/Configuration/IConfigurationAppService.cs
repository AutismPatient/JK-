using System.Threading.Tasks;
using ppl.Configuration.Dto;

namespace ppl.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
