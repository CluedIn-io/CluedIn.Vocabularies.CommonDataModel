using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DefaultSettingsVocabulary : SimpleVocabulary
    {
        public DefaultSettingsVocabulary()
        {
            VocabularyName = "Default Settings";
            KeyPrefix = "commonDataModel.defaultsettings";
            KeySeparator = ".";
            Grouping = "/DefaultSettings";

            AddGroup("DefaultSettings Details", group =>
            {
                @Default = group.Add(new VocabularyKey(nameof(@Default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultmarketingsettingId = group.Add(new VocabularyKey(nameof(DefaultmarketingsettingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Thankyoupagesource = group.Add(new VocabularyKey(nameof(Thankyoupagesource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Defaultmarketingthankyouurldoi = group.Add(new VocabularyKey(nameof(Defaultmarketingthankyouurldoi), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Defaultmarketingthankyouurl = group.Add(new VocabularyKey(nameof(Defaultmarketingthankyouurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultTimeZone = group.Add(new VocabularyKey(nameof(DefaultTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableDoubleOptIn = group.Add(new VocabularyKey(nameof(EnableDoubleOptIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableLitmusIntegration = group.Add(new VocabularyKey(nameof(EnableLitmusIntegration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BypassEmailDeduplication = group.Add(new VocabularyKey(nameof(BypassEmailDeduplication), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Defaultemailfromemail = group.Add(new VocabularyKey(nameof(Defaultemailfromemail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultemailfromName = group.Add(new VocabularyKey(nameof(DefaultemailfromName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey @Default { get; private set; }
        public VocabularyKey DefaultmarketingsettingId { get; private set; }
        public VocabularyKey Thankyoupagesource { get; private set; }
        public VocabularyKey Defaultmarketingthankyouurldoi { get; private set; }
        public VocabularyKey Defaultmarketingthankyouurl { get; private set; }
        public VocabularyKey DefaultTimeZone { get; private set; }
        public VocabularyKey EnableDoubleOptIn { get; private set; }
        public VocabularyKey EnableLitmusIntegration { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BypassEmailDeduplication { get; private set; }
        public VocabularyKey Defaultemailfromemail { get; private set; }
        public VocabularyKey DefaultemailfromName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}