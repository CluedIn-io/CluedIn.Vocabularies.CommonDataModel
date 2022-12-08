using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Automotive
{
    public class SalesContractVocabulary : SimpleVocabulary
    {
        public SalesContractVocabulary()
        {
            VocabularyName = "Sales Contract";
            KeyPrefix = "commonDataModel.salescontract.automotive";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SalesContract;

            AddGroup("SalesContract Details for Automotive", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ContractDate = group.Add(new VocabularyKey(nameof(ContractDate), "Contract Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FinalBalloonPayment = group.Add(new VocabularyKey(nameof(FinalBalloonPayment), "Final Balloon Payment", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    FinalBalloonPaymentBase = group.Add(new VocabularyKey(nameof(FinalBalloonPaymentBase), "Final Balloon Payment (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OriginationCommission = group.Add(new VocabularyKey(nameof(OriginationCommission), "Origination Commission", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OriginationCommissionBase = group.Add(new VocabularyKey(nameof(OriginationCommissionBase), "Origination Commission (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesContractId = group.Add(new VocabularyKey(nameof(SalesContractId), "Sales Contract", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SellingPrice = group.Add(new VocabularyKey(nameof(SellingPrice), "Selling Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SellingPriceBase = group.Add(new VocabularyKey(nameof(SellingPriceBase), "Selling Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalAdd = group.Add(new VocabularyKey(nameof(TotalAdd), "Total Add Ons Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalAddBase = group.Add(new VocabularyKey(nameof(TotalAddBase), "Total Add Ons Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalAddOnsCost = group.Add(new VocabularyKey(nameof(TotalAddOnsCost), "Total Add Ons Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalAddOnsCostBase = group.Add(new VocabularyKey(nameof(TotalAddOnsCostBase), "Total Add Ons Cost (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalDownpayment = group.Add(new VocabularyKey(nameof(TotalDownpayment), "Total Downpayment", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalDownpaymentBase = group.Add(new VocabularyKey(nameof(TotalDownpaymentBase), "Total Downpayment (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalMonthlyPayment = group.Add(new VocabularyKey(nameof(TotalMonthlyPayment), "Total Monthly Payment", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalMonthlyPaymentBase = group.Add(new VocabularyKey(nameof(TotalMonthlyPaymentBase), "Total Monthly Payment (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalServiceContractCost = group.Add(new VocabularyKey(nameof(TotalServiceContractCost), "Total Service Contract Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalServiceContractCostBase = group.Add(new VocabularyKey(nameof(TotalServiceContractCostBase), "Total Service Contract Cost (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalServiceContractsPrice = group.Add(new VocabularyKey(nameof(TotalServiceContractsPrice), "Total Service Contracts Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalServiceContractsPriceBase = group.Add(new VocabularyKey(nameof(TotalServiceContractsPriceBase), "Total Service Contracts Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalTaxesAndFees = group.Add(new VocabularyKey(nameof(TotalTaxesAndFees), "Total Taxes and Fees", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalTaxesAndFeesBase = group.Add(new VocabularyKey(nameof(TotalTaxesAndFeesBase), "Total Taxes and Fees (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalTradeIn = group.Add(new VocabularyKey(nameof(TotalTradeIn), "Total Trade In", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalTradeInBase = group.Add(new VocabularyKey(nameof(TotalTradeInBase), "Total Trade In (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="DealId"/> to Vocab 'Deal.cdm.json/Deal' with Property 'DealId'
            ///Property <see cref="DeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
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
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="SalesContractTypeId"/> to Vocab 'SalesContractType.cdm.json/SalesContractType' with Property 'SalesContractTypeId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SalesContractId"/> to Vocab 'SalesContract.cdm.json/SalesContract' with Property 'SalesContractId'
            ///Property <see cref="SalesContractId"/> to Vocab 'SalesContract.cdm.json/SalesContract' with Property 'SalesContractId'
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
            ///Property <see cref="ProviderAccountId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
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
            ///Property <see cref="SalesContractTypeId"/> to Vocab 'SalesContractType.cdm.json/SalesContractType' with Property 'SalesContractTypeId'
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
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="SalesContractTypeId"/> from Vocab 'SalesContract.cdm.json/SalesContract' with Property 'SalesContractTypeId'
            ///Property <see cref="SalesContractId"/> from Vocab 'SalesContractDetail.cdm.json/SalesContractDetail' with Property 'SalesContractId'
            ///Property <see cref="SalesContractId"/> from Vocab 'SalesContractPayment.cdm.json/SalesContractPayment' with Property 'SalesContractId'
            ///Property <see cref="SalesContractTypeId"/> from Vocab 'SalesContractTerm.cdm.json/SalesContractTerm' with Property 'SalesContractTypeId'
            #endregion
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ContractDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey FinalBalloonPayment { get; private set; }
        public VocabularyKey FinalBalloonPaymentBase { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OriginationCommission { get; private set; }
        public VocabularyKey OriginationCommissionBase { get; private set; }
        public VocabularyKey SalesContractId { get; private set; }
        public VocabularyKey SellingPrice { get; private set; }
        public VocabularyKey SellingPriceBase { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey TotalAdd { get; private set; }
        public VocabularyKey TotalAddBase { get; private set; }
        public VocabularyKey TotalAddOnsCost { get; private set; }
        public VocabularyKey TotalAddOnsCostBase { get; private set; }
        public VocabularyKey TotalDownpayment { get; private set; }
        public VocabularyKey TotalDownpaymentBase { get; private set; }
        public VocabularyKey TotalMonthlyPayment { get; private set; }
        public VocabularyKey TotalMonthlyPaymentBase { get; private set; }
        public VocabularyKey TotalServiceContractCost { get; private set; }
        public VocabularyKey TotalServiceContractCostBase { get; private set; }
        public VocabularyKey TotalServiceContractsPrice { get; private set; }
        public VocabularyKey TotalServiceContractsPriceBase { get; private set; }
        public VocabularyKey TotalTaxesAndFees { get; private set; }
        public VocabularyKey TotalTaxesAndFeesBase { get; private set; }
        public VocabularyKey TotalTradeIn { get; private set; }
        public VocabularyKey TotalTradeInBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}