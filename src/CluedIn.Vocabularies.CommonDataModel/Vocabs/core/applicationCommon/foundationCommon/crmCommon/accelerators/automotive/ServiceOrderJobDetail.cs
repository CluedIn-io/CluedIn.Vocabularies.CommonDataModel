using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ServiceOrderJobDetailVocabulary : SimpleVocabulary
    {
        public ServiceOrderJobDetailVocabulary()
        {
            VocabularyName = "Service Order Job Detail";
            KeyPrefix = "commonDataModel.serviceorderjobdetail";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ServiceOrderJobDetail;

            AddGroup("ServiceOrderJobDetail Details for Automotive", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActualQuantity = group.Add(new VocabularyKey(nameof(ActualQuantity), "Actual Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Discount = group.Add(new VocabularyKey(nameof(Discount), "Discount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DiscountBase = group.Add(new VocabularyKey(nameof(DiscountBase), "Discount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedAmount = group.Add(new VocabularyKey(nameof(EstimatedAmount), "Estimated Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedAmountBase = group.Add(new VocabularyKey(nameof(EstimatedAmountBase), "Estimated Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExpectedQuantity = group.Add(new VocabularyKey(nameof(ExpectedQuantity), "Expected Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ItemName = group.Add(new VocabularyKey(nameof(ItemName), "Item Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaySubtype = group.Add(new VocabularyKey(nameof(PaySubtype), "Pay Subtype", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PayType = group.Add(new VocabularyKey(nameof(PayType), "Pay Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProjectName = group.Add(new VocabularyKey(nameof(ProjectName), "Project Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), "Sales Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesPriceBase = group.Add(new VocabularyKey(nameof(SalesPriceBase), "Sales Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ServiceOrderJobDetailId = group.Add(new VocabularyKey(nameof(ServiceOrderJobDetailId), "Service Order Job Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubcontractorPurchaseOrder = group.Add(new VocabularyKey(nameof(SubcontractorPurchaseOrder), "Subcontractor Purchase Order", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="BusinessOperationId"/> to Vocab 'BusinessOperation.cdm.json/BusinessOperation' with Property 'BusinessOperationId'
            ///Property <see cref="DeviceWarrantyId"/> to Vocab 'DeviceWarranty.cdm.json/DeviceWarranty' with Property 'DeviceWarrantyId'
            ///Property <see cref="OperationCodeId"/> to Vocab 'OperationCode.cdm.json/OperationCode' with Property 'OperationCodeId'
            ///Property <see cref="ServiceContractId"/> to Vocab 'ServiceContract.cdm.json/ServiceContract' with Property 'ServiceContractId'
            ///Property <see cref="ServiceOrderId"/> to Vocab 'ServiceOrder.cdm.json/ServiceOrder' with Property 'ServiceOrderId'
            ///Property <see cref="ServiceOrderJobId"/> to Vocab 'ServiceOrderJob.cdm.json/ServiceOrderJob' with Property 'ServiceOrderJobId'
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
            ///Property <see cref="SubcontractorAccountId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TechnicianId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ActualQuantity { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Discount { get; private set; }
        public VocabularyKey DiscountBase { get; private set; }
        public VocabularyKey EstimatedAmount { get; private set; }
        public VocabularyKey EstimatedAmountBase { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExpectedQuantity { get; private set; }
        public VocabularyKey ItemName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PaySubtype { get; private set; }
        public VocabularyKey PayType { get; private set; }
        public VocabularyKey ProjectName { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesPriceBase { get; private set; }
        public VocabularyKey ServiceOrderJobDetailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubcontractorPurchaseOrder { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}