using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class HealthcareServiceVocabulary : SimpleVocabulary
    {
        public HealthcareServiceVocabulary()
        {
            VocabularyName = "Healthcare Service";
            KeyPrefix = "commonDataModel.healthcareservice.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/HealthcareService";

            AddGroup("HealthcareService Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AppointmentRequired = group.Add(new VocabularyKey(nameof(AppointmentRequired), "Appointment Required", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AvailabilityExceptions = group.Add(new VocabularyKey(nameof(AvailabilityExceptions), "Availability Exceptions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Comment = group.Add(new VocabularyKey(nameof(Comment), "Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EligibilityNote = group.Add(new VocabularyKey(nameof(EligibilityNote), "Eligibility note", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExtraDetails = group.Add(new VocabularyKey(nameof(ExtraDetails), "Extra Details", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HealthcareService = group.Add(new VocabularyKey(nameof(HealthcareService), "Healthcare Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HealthcareServiceId = group.Add(new VocabularyKey(nameof(HealthcareServiceId), "Healthcare Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NotAvailableDescription = group.Add(new VocabularyKey(nameof(NotAvailableDescription), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NotAvailableDuringEndDateTime = group.Add(new VocabularyKey(nameof(NotAvailableDuringEndDateTime), "End Datetime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NotAvailableDuringStartDateTime = group.Add(new VocabularyKey(nameof(NotAvailableDuringStartDateTime), "Start Datetime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
        public VocabularyKey AppointmentRequired { get; private set; }
        public VocabularyKey AvailabilityExceptions { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey EligibilityNote { get; private set; }
        public VocabularyKey ExtraDetails { get; private set; }
        public VocabularyKey HealthcareService { get; private set; }
        public VocabularyKey HealthcareServiceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NotAvailableDescription { get; private set; }
        public VocabularyKey NotAvailableDuringEndDateTime { get; private set; }
        public VocabularyKey NotAvailableDuringStartDateTime { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}