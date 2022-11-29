using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ContactLinkVocabulary : SimpleVocabulary
    {
        public ContactLinkVocabulary()
        {
            VocabularyName = "Contact Link";
            KeyPrefix = "commonDataModel.contactlink.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ContactLink";

            AddGroup("ContactLink Details for ElectronicMedicalRecords", group =>
            {
			    ContactLinkId = group.Add(new VocabularyKey(nameof(ContactLinkId), "Contact Link", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ContactLinkId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}