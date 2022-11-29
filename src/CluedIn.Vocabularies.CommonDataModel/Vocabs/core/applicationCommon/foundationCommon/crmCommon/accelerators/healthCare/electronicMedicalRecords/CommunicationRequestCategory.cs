using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CommunicationRequestCategoryVocabulary : SimpleVocabulary
    {
        public CommunicationRequestCategoryVocabulary()
        {
            VocabularyName = "Communication Request Category";
            KeyPrefix = "commonDataModel.communicationrequestcategory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestCategory";

            AddGroup("CommunicationRequestCategory Details for ElectronicMedicalRecords", group =>
            {
			    CommunicationRequestCategoryId = group.Add(new VocabularyKey(nameof(CommunicationRequestCategoryId), "Communication Request Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CommunicationRequestCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}