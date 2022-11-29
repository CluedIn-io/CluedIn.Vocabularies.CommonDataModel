using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RelatedPersonVocabulary : SimpleVocabulary
    {
        public RelatedPersonVocabulary()
        {
            VocabularyName = "Related Person";
            KeyPrefix = "commonDataModel.relatedperson.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RelatedPerson";

            AddGroup("RelatedPerson Details for ElectronicMedicalRecords", group =>
            {
			    Active = group.Add(new VocabularyKey(nameof(Active), "Active", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedPersonId = group.Add(new VocabularyKey(nameof(RelatedPersonId), "Related Person", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedPersonPeriodEndDate = group.Add(new VocabularyKey(nameof(RelatedPersonPeriodEndDate), "Related Person Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedPersonPeriodStartDate = group.Add(new VocabularyKey(nameof(RelatedPersonPeriodStartDate), "Related Person Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Active { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RelatedPersonId { get; private set; }
        public VocabularyKey RelatedPersonPeriodEndDate { get; private set; }
        public VocabularyKey RelatedPersonPeriodStartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}