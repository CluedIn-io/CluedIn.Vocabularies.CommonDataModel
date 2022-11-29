using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class RegistrationResponseVocabulary : SimpleVocabulary
    {
        public RegistrationResponseVocabulary()
        {
            VocabularyName = "Registration Response";
            KeyPrefix = "commonDataModel.registrationresponse.eventmanagement";
            KeySeparator = ".";
            Grouping = "/RegistrationResponse";

            AddGroup("RegistrationResponse Details for EventManagement", group =>
            {
			    RegistrationResponseId = group.Add(new VocabularyKey(nameof(RegistrationResponseId), "Registration Response", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Response = group.Add(new VocabularyKey(nameof(Response), "Response", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RegistrationResponseId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Response { get; private set; }
    }
}