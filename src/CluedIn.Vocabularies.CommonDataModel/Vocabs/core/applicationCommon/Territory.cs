using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ApplicationCommon
{
    public class TerritoryVocabulary : SimpleVocabulary
    {
        public TerritoryVocabulary()
        {
            VocabularyName = "Territory";
            KeyPrefix = "commonDataModel.territory.applicationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Territory;

            AddGroup("Territory Details for ApplicationCommon", group =>
            {
			    TerritoryId = group.Add(new VocabularyKey(nameof(TerritoryId), "Territory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Territory Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ManagerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="Territory"/> to Vocab 'Territory.cdm.json/Territory' with Property 'TerritoryId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="TerritoryId"/> from Vocab 'User.cdm.json/User' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> from Vocab 'foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> from Vocab 'foundationCommon/crmCommon/accelerators/financialServices/banking/Account.cdm.json/Account' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Account.cdm.json/Account' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/scheduling/ResourceRequirement.cdm.json/ResourceRequirement' with Property 'Territory'
            ///Property <see cref="TerritoryId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/scheduling/ResourceTerritory.cdm.json/ResourceTerritory' with Property 'Territory'
            ///Property <see cref="TerritoryId"/> from Vocab 'foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/eventManagement/Account.cdm.json/Account' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Account.cdm.json/Account' with Property 'TerritoryId'
            #endregion
        }

        public VocabularyKey TerritoryId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}