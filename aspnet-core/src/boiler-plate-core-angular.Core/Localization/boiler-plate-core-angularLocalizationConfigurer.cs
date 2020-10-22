using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace boiler-plate-core-angular.Localization
{
    public static class boiler-plate-core-angularLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(boiler-plate-core-angularConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(boiler-plate-core-angularLocalizationConfigurer).GetAssembly(),
                        "boiler-plate-core-angular.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
