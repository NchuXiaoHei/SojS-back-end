using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SojS.BackEnd.Localization
{
    public static class BackEndLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BackEndConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BackEndLocalizationConfigurer).GetAssembly(),
                        "SojS.BackEnd.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
