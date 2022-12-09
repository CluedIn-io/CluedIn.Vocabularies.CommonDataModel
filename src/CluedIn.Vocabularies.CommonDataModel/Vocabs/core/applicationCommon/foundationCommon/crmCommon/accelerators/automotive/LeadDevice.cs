using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class LeadDeviceVocabulary : SimpleVocabulary
    {
        public LeadDeviceVocabulary()
        {
            VocabularyName = "Lead Device";
            KeyPrefix = "commonDataModel.leaddevice";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.LeadDevice;

            AddGroup("LeadDevice Details for Automotive", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceYear = group.Add(new VocabularyKey(nameof(DeviceYear), "Device Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LeadDeviceId = group.Add(new VocabularyKey(nameof(LeadDeviceId), "Lead Device", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceComments = group.Add(new VocabularyKey(nameof(PriceComments), "Price Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    State = group.Add(new VocabularyKey(nameof(State), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    URL = group.Add(new VocabularyKey(nameof(URL), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="DeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="DeviceBrandId"/> to Vocab 'DeviceBrand.cdm.json/DeviceBrand' with Property 'DeviceBrandId'
            ///Property <see cref="DeviceClassId"/> to Vocab 'DeviceClass.cdm.json/DeviceClass' with Property 'DeviceClassId'
            ///Property <see cref="DeviceGenerationId"/> to Vocab 'DeviceGeneration.cdm.json/DeviceGeneration' with Property 'DeviceGenerationId'
            ///Property <see cref="DeviceModelId"/> to Vocab 'DeviceModel.cdm.json/DeviceModel' with Property 'DeviceModelId'
            ///Property <see cref="DeviceModelCodeId"/> to Vocab 'DeviceModelCode.cdm.json/DeviceModelCode' with Property 'DeviceModelCodeId'
            ///Property <see cref="DeviceStyleId"/> to Vocab 'DeviceStyle.cdm.json/DeviceStyle' with Property 'DeviceStyleId'
            ///Property <see cref="DeviceTypeId"/> to Vocab 'DeviceType.cdm.json/DeviceType' with Property 'DeviceTypeId'
            ///Property <see cref="DeviceVariantId"/> to Vocab 'DeviceVariant.cdm.json/DeviceVariant' with Property 'DeviceVariantId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PriceTypeId"/> to Vocab 'LeadPriceType.cdm.json/LeadPriceType' with Property 'LeadPriceTypeId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="SpecificationTypeId"/> to Vocab 'LeadSpecificationType.cdm.json/LeadSpecificationType' with Property 'LeadSpecificationTypeId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="LeadDeviceId"/> from Vocab 'FinancingOpportunity.cdm.json/FinancingOpportunity' with Property 'LeadDeviceId'
            #endregion
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey DeviceYear { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey LeadDeviceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey PriceComments { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey URL { get; private set; }
    }
}