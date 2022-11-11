using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DefaultSettingsVocabulary : SimpleVocabulary
    {
        public DefaultSettingsVocabulary()
        {
            VocabularyName = "Common Data Model DefaultSettings";
            KeyPrefix = "commonDataModel.defaultsettings";
            KeySeparator = ".";
            Grouping = "/DefaultSettings";

            AddGroup("Common Data Model DefaultSettings Details", group =>
            {
                @default = group.Add(new VocabularyKey(nameof(@default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                defaultmarketingsettingId = group.Add(new VocabularyKey(nameof(defaultmarketingsettingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                thankyoupagesource = group.Add(new VocabularyKey(nameof(thankyoupagesource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                defaultmarketingthankyouurldoi = group.Add(new VocabularyKey(nameof(defaultmarketingthankyouurldoi), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                defaultmarketingthankyouurl = group.Add(new VocabularyKey(nameof(defaultmarketingthankyouurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                defaultTimeZone = group.Add(new VocabularyKey(nameof(defaultTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                enableDoubleOptIn = group.Add(new VocabularyKey(nameof(enableDoubleOptIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                enableLitmusIntegration = group.Add(new VocabularyKey(nameof(enableLitmusIntegration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                bypassEmailDeduplication = group.Add(new VocabularyKey(nameof(bypassEmailDeduplication), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                defaultemailfromemail = group.Add(new VocabularyKey(nameof(defaultemailfromemail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                defaultemailfromName = group.Add(new VocabularyKey(nameof(defaultemailfromName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey @default { get; private set; }
        public VocabularyKey defaultmarketingsettingId { get; private set; }
        public VocabularyKey thankyoupagesource { get; private set; }
        public VocabularyKey defaultmarketingthankyouurldoi { get; private set; }
        public VocabularyKey defaultmarketingthankyouurl { get; private set; }
        public VocabularyKey defaultTimeZone { get; private set; }
        public VocabularyKey enableDoubleOptIn { get; private set; }
        public VocabularyKey enableLitmusIntegration { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey bypassEmailDeduplication { get; private set; }
        public VocabularyKey defaultemailfromemail { get; private set; }
        public VocabularyKey defaultemailfromName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}