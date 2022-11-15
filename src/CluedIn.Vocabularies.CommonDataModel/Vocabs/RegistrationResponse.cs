using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RegistrationResponseVocabulary : SimpleVocabulary
    {
        public RegistrationResponseVocabulary()
        {
            VocabularyName = "Registration Response";
            KeyPrefix = "commonDataModel.registrationresponse";
            KeySeparator = ".";
            Grouping = "/RegistrationResponse";

            AddGroup("RegistrationResponse Details", group =>
            {
                CreatedFromApi = group.Add(new VocabularyKey(nameof(CreatedFromApi), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationResponseId = group.Add(new VocabularyKey(nameof(RegistrationResponseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Response = group.Add(new VocabularyKey(nameof(Response), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreatedFromApi { get; private set; }
        public VocabularyKey RegistrationResponseId { get; private set; }
        public VocabularyKey Response { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}