using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PositionVocabulary : SimpleVocabulary
    {
        public PositionVocabulary()
        {
            VocabularyName = "Position";
            KeyPrefix = "commonDataModel.position";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Position;

            AddGroup("Position Details for ApplicationCommon", group =>
            {
			    PositionId = group.Add(new VocabularyKey(nameof(PositionId), "Position", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ParentPositionId"/> to Vocab 'Position.cdm.json/Position' with Property 'PositionId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="PositionId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="PositionId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="PositionId"/> from Vocab 'Position.cdm.json/Position' with Property 'ParentPositionId'
            ///Property <see cref="PositionId"/> from Vocab 'User.cdm.json/User' with Property 'PositionId'
            ///Property <see cref="PositionId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'PositionId'
            ///Property <see cref="PositionId"/> from Vocab 'foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'PositionId'
            ///Property <see cref="PositionId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="PositionId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record1Id'
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}