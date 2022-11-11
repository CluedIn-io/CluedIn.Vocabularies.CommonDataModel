using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AuthenticationSettingsVocabulary : SimpleVocabulary
    {
        public AuthenticationSettingsVocabulary()
        {
            VocabularyName = "AuthenticationSettings";
            KeyPrefix = "commonDataModel.authenticationsettings";
            KeySeparator = ".";
            Grouping = "/AuthenticationSettings";

            AddGroup("AuthenticationSettings Details", group =>
            {
                authenticationSettingsId = group.Add(new VocabularyKey(nameof(authenticationSettingsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                authenticationType = group.Add(new VocabularyKey(nameof(authenticationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey authenticationSettingsId { get; private set; }
        public VocabularyKey authenticationType { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}