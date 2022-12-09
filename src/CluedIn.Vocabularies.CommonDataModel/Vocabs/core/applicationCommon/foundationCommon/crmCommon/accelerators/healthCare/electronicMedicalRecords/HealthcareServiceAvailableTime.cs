using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class HealthcareServiceAvailableTimeVocabulary : SimpleVocabulary
    {
        public HealthcareServiceAvailableTimeVocabulary()
        {
            VocabularyName = "Healthcare Service Available Time";
            KeyPrefix = "commonDataModel.healthcareserviceavailabletime";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.HealthcareServiceAvailableTime;

            AddGroup("HealthcareServiceAvailableTime Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllDay = group.Add(new VocabularyKey(nameof(AllDay), "All day", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AvailableEndTime = group.Add(new VocabularyKey(nameof(AvailableEndTime), "End Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AvailableStartTime = group.Add(new VocabularyKey(nameof(AvailableStartTime), "Start Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DayOfWeek = group.Add(new VocabularyKey(nameof(DayOfWeek), "Day of Week", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HealthcareServiceAvailableTimeId = group.Add(new VocabularyKey(nameof(HealthcareServiceAvailableTimeId), "Healthcare Service Available Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="HealthcareServiceId"/> to Vocab 'HealthcareService.cdm.json/HealthcareService' with Property 'HealthcareServiceId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey AllDay { get; private set; }
        public VocabularyKey AvailableEndTime { get; private set; }
        public VocabularyKey AvailableStartTime { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey DayOfWeek { get; private set; }
        public VocabularyKey HealthcareServiceAvailableTimeId { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}