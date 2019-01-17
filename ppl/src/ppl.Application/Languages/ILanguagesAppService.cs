using Abp.Application.Services.Dto;
using ppl.Languages.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Languages
{
    public interface ILanguagesAppService
    {
        Task<LanguagesOutput> GetLanguagesAsync();
        Task<GetLanguageForEditOutput> GetLanguaesEditAsync(NullableIdDto input);
        Task CreateLanguage(LanguagesInput input);
        Task UpdateLanguage(LanguagesInput input);
        Task DeleteLanguage(EntityDto input);
        Task UpdateLanguageText(UpdateLanguageTextInput input);
    }
}
