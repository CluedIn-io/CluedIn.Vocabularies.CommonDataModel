using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class EndpointContactVocabulary : SimpleVocabulary
    {
        public EndpointContactVocabulary()
        {
            VocabularyName = "Endpoint Contact";
            KeyPrefix = "commonDataModel.endpointcontact";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.EndpointContact;

            AddGroup("EndpointContact Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactSystem = group.Add(new VocabularyKey(nameof(ContactSystem), "Contact System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Contactvalue = group.Add(new VocabularyKey(nameof(Contactvalue), "Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndpointContactId = group.Add(new VocabularyKey(nameof(EndpointContactId), "Endpoint Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodEndDate = group.Add(new VocabularyKey(nameof(PeriodEndDate), "Contact End date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodStartDate = group.Add(new VocabularyKey(nameof(PeriodStartDate), "Contact Start date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Rank = group.Add(new VocabularyKey(nameof(Rank), "Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Use = group.Add(new VocabularyKey(nameof(Use), "Use", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="EndpointId"/> to Vocab 'Endpoint.cdm.json/Endpoint' with Property 'EndpointId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ContactSystem { get; private set; }
        public VocabularyKey Contactvalue { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey EndpointContactId { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey PeriodEndDate { get; private set; }
        public VocabularyKey PeriodStartDate { get; private set; }
        public VocabularyKey Rank { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey Use { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}