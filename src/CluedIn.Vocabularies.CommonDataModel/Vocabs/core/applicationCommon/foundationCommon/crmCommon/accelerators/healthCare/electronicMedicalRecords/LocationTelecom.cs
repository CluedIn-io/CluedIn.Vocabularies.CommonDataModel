using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class LocationTelecomVocabulary : SimpleVocabulary
    {
        public LocationTelecomVocabulary()
        {
            VocabularyName = "Location Telecom";
            KeyPrefix = "commonDataModel.locationtelecom.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.LocationTelecom;

            AddGroup("LocationTelecom Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationTelecomId = group.Add(new VocabularyKey(nameof(LocationTelecomId), "Location Telecom", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationTelecomPeriodEndDate = group.Add(new VocabularyKey(nameof(LocationTelecomPeriodEndDate), "Telecom Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationTelecomPeriodStartDate = group.Add(new VocabularyKey(nameof(LocationTelecomPeriodStartDate), "Telecom Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationTelecomRank = group.Add(new VocabularyKey(nameof(LocationTelecomRank), "Telecom Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LocationTelecomSystem = group.Add(new VocabularyKey(nameof(LocationTelecomSystem), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationTelecomUse = group.Add(new VocabularyKey(nameof(LocationTelecomUse), "Telecom Use", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocationTelecomValue = group.Add(new VocabularyKey(nameof(LocationTelecomValue), "Telecom Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="LocationId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey LocationTelecomId { get; private set; }
        public VocabularyKey LocationTelecomPeriodEndDate { get; private set; }
        public VocabularyKey LocationTelecomPeriodStartDate { get; private set; }
        public VocabularyKey LocationTelecomRank { get; private set; }
        public VocabularyKey LocationTelecomSystem { get; private set; }
        public VocabularyKey LocationTelecomUse { get; private set; }
        public VocabularyKey LocationTelecomValue { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}