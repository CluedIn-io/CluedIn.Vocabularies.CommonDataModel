using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RegistrationResponseVocabulary : SimpleVocabulary
    {
        public RegistrationResponseVocabulary()
        {
            VocabularyName = "Common Data Model RegistrationResponse";
            KeyPrefix = "commonDataModel.registrationresponse";
            KeySeparator = ".";
            Grouping = "/RegistrationResponse";

            AddGroup("Common Data Model RegistrationResponse Details", group =>
            {
                createdFromApi = group.Add(new VocabularyKey(nameof(createdFromApi), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                registrationResponseId = group.Add(new VocabularyKey(nameof(registrationResponseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                response = group.Add(new VocabularyKey(nameof(response), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey createdFromApi { get; private set; }
        public VocabularyKey registrationResponseId { get; private set; }
        public VocabularyKey response { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}