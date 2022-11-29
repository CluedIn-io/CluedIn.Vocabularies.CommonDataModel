using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class HealthcareServiceTelecomVocabulary : SimpleVocabulary
    {
        public HealthcareServiceTelecomVocabulary()
        {
            VocabularyName = "Healthcare Service Telecom";
            KeyPrefix = "commonDataModel.healthcareservicetelecom.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/HealthcareServiceTelecom";

            AddGroup("HealthcareServiceTelecom Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HealthcareservicetelecommId = group.Add(new VocabularyKey(nameof(HealthcareservicetelecommId), "Healthcare Service Telecom", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodEndDatetime = group.Add(new VocabularyKey(nameof(PeriodEndDatetime), "Period End Datetime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodStartDatetime = group.Add(new VocabularyKey(nameof(PeriodStartDatetime), "Period Start Datetime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Rank = group.Add(new VocabularyKey(nameof(Rank), "Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    System = group.Add(new VocabularyKey(nameof(System), "System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Use = group.Add(new VocabularyKey(nameof(Use), "Use", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey HealthcareservicetelecommId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PeriodEndDatetime { get; private set; }
        public VocabularyKey PeriodStartDatetime { get; private set; }
        public VocabularyKey Rank { get; private set; }
        public VocabularyKey System { get; private set; }
        public VocabularyKey Use { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}