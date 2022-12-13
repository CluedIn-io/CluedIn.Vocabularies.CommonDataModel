using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DealDeviceVocabulary : SimpleVocabulary
    {
        public DealDeviceVocabulary()
        {
            VocabularyName = "Deal Device";
            KeyPrefix = "commonDataModel.dealdevice";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DealDevice;

            AddGroup("DealDevice Details for Automotive", group =>
            {
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ActualCost = group.Add(new VocabularyKey(nameof(ActualCost), "Actual Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ActualCostBase = group.Add(new VocabularyKey(nameof(ActualCostBase), "Actual Cost (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ActualRevenue = group.Add(new VocabularyKey(nameof(ActualRevenue), "Actual Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ActualRevenueBase = group.Add(new VocabularyKey(nameof(ActualRevenueBase), "Actual Revenue (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                CustomerPrice = group.Add(new VocabularyKey(nameof(CustomerPrice), "Customer Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                CustomerPriceBase = group.Add(new VocabularyKey(nameof(CustomerPriceBase), "Customer Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                DealDeviceId = group.Add(new VocabularyKey(nameof(DealDeviceId), "Deal Device", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCost = group.Add(new VocabularyKey(nameof(EstimatedCost), "Estimated Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                EstimatedCostBase = group.Add(new VocabularyKey(nameof(EstimatedCostBase), "Estimated Cost (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                EstimatedRevenue = group.Add(new VocabularyKey(nameof(EstimatedRevenue), "Estimated Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                EstimatedRevenueBase = group.Add(new VocabularyKey(nameof(EstimatedRevenueBase), "Estimated Revenue (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPrice = group.Add(new VocabularyKey(nameof(RetailPrice), "Retail Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                RetailPriceBase = group.Add(new VocabularyKey(nameof(RetailPriceBase), "Retail Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="DealId"/> to Vocab 'Deal.cdm.json/Deal' with Property 'DealId'
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
            ///Property <see cref="DeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
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
            ///Property <see cref="DealDeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey ActualCost { get; private set; }
        public VocabularyKey ActualCostBase { get; private set; }
        public VocabularyKey ActualRevenue { get; private set; }
        public VocabularyKey ActualRevenueBase { get; private set; }
        public VocabularyKey CustomerPrice { get; private set; }
        public VocabularyKey CustomerPriceBase { get; private set; }
        public VocabularyKey DealDeviceId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EstimatedCost { get; private set; }
        public VocabularyKey EstimatedCostBase { get; private set; }
        public VocabularyKey EstimatedRevenue { get; private set; }
        public VocabularyKey EstimatedRevenueBase { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RetailPrice { get; private set; }
        public VocabularyKey RetailPriceBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}