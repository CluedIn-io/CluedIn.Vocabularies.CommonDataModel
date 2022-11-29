using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class JournalLineVocabulary : SimpleVocabulary
    {
        public JournalLineVocabulary()
        {
            VocabularyName = "Journal Line";
            KeyPrefix = "commonDataModel.journalline.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/JournalLine";

            AddGroup("JournalLine Details for ProjectServiceAutomation", group =>
            {
			    JournalLineId = group.Add(new VocabularyKey(nameof(JournalLineId), "Journal Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), "Accounting Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AmountMethod = group.Add(new VocabularyKey(nameof(AmountMethod), "Amount Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BasisAmount = group.Add(new VocabularyKey(nameof(BasisAmount), "Basis Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BasisAmountBase = group.Add(new VocabularyKey(nameof(BasisAmountBase), "Basis Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BasisPrice = group.Add(new VocabularyKey(nameof(BasisPrice), "Basis Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BasisPriceBase = group.Add(new VocabularyKey(nameof(BasisPriceBase), "Basis Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BasisQuantity = group.Add(new VocabularyKey(nameof(BasisQuantity), "Basis Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    BillingStatus = group.Add(new VocabularyKey(nameof(BillingStatus), "Billing Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerType = group.Add(new VocabularyKey(nameof(CustomerType), "Customer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), "Document Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), "End Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRateDate = group.Add(new VocabularyKey(nameof(ExchangeRateDate), "Exchange Rate Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalDescription = group.Add(new VocabularyKey(nameof(ExternalDescription), "External Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), "Is Posted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Percent = group.Add(new VocabularyKey(nameof(Percent), "Percent", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SalesContractLine = group.Add(new VocabularyKey(nameof(SalesContractLine), "(Deprecated) Project Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), "Start Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionTypeCode = group.Add(new VocabularyKey(nameof(TransactionTypeCode), "Transaction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VendorType = group.Add(new VocabularyKey(nameof(VendorType), "Vendor Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey JournalLineId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey AmountMethod { get; private set; }
        public VocabularyKey BasisAmount { get; private set; }
        public VocabularyKey BasisAmountBase { get; private set; }
        public VocabularyKey BasisPrice { get; private set; }
        public VocabularyKey BasisPriceBase { get; private set; }
        public VocabularyKey BasisQuantity { get; private set; }
        public VocabularyKey BillingStatus { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey CustomerType { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey ExchangeRateDate { get; private set; }
        public VocabularyKey ExternalDescription { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey Percent { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey SalesContractLine { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
        public VocabularyKey TransactionTypeCode { get; private set; }
        public VocabularyKey VendorType { get; private set; }
    }
}