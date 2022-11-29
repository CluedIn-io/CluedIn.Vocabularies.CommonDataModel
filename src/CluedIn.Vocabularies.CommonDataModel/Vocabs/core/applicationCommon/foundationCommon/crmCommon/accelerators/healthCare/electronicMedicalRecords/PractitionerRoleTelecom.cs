using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class PractitionerRoleTelecomVocabulary : SimpleVocabulary
    {
        public PractitionerRoleTelecomVocabulary()
        {
            VocabularyName = "Practitioner Role Telecom";
            KeyPrefix = "commonDataModel.practitionerroletelecom.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/PractitionerRoleTelecom";

            AddGroup("PractitionerRoleTelecom Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodEndDatetime = group.Add(new VocabularyKey(nameof(PeriodEndDatetime), "Period End Datetime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodStartDatetime = group.Add(new VocabularyKey(nameof(PeriodStartDatetime), "Period Start Datetime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PractitionerRoleTelecomId = group.Add(new VocabularyKey(nameof(PractitionerRoleTelecomId), "Practitioner Role Telecom", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Rank = group.Add(new VocabularyKey(nameof(Rank), "Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    System = group.Add(new VocabularyKey(nameof(System), "System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Use = group.Add(new VocabularyKey(nameof(Use), "Use", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PeriodEndDatetime { get; private set; }
        public VocabularyKey PeriodStartDatetime { get; private set; }
        public VocabularyKey PractitionerRoleTelecomId { get; private set; }
        public VocabularyKey Rank { get; private set; }
        public VocabularyKey System { get; private set; }
        public VocabularyKey Use { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}