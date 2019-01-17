using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ppl.Localization
{
    /// <summary>
    /// 加载本地化资源
    /// </summary>
    public static class pplLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(JklConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(pplLocalizationConfigurer).GetAssembly(),
                        "ppl.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
