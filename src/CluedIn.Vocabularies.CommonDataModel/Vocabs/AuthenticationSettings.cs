using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AuthenticationSettingsVocabulary : SimpleVocabulary
    {
        public AuthenticationSettingsVocabulary()
        {
            VocabularyName = "Authentication Settings";
            KeyPrefix = "commonDataModel.authenticationsettings";
            KeySeparator = ".";
            Grouping = "/AuthenticationSettings";

            AddGroup("AuthenticationSettings Details", group =>
            {
                AuthenticationSettingsId = group.Add(new VocabularyKey(nameof(AuthenticationSettingsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthenticationType = group.Add(new VocabularyKey(nameof(AuthenticationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AuthenticationSettingsId { get; private set; }
        public VocabularyKey AuthenticationType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}