using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class ContractVocabulary : SimpleVocabulary
    {
        public ContractVocabulary()
        {
            VocabularyName = "Contract";
            KeyPrefix = "commonDataModel.contract.service";
            KeySeparator = ".";
            Grouping = "/Contract";

            AddGroup("Contract Details for Service", group =>
            {
			    ContractId = group.Add(new VocabularyKey(nameof(ContractId), "Contract", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Email Address", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Contract Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActiveOn = group.Add(new VocabularyKey(nameof(ActiveOn), "Contract Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllotmentTypeCode = group.Add(new VocabularyKey(nameof(AllotmentTypeCode), "Allotment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingEndOn = group.Add(new VocabularyKey(nameof(BillingEndOn), "Billing End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingFrequencyCode = group.Add(new VocabularyKey(nameof(BillingFrequencyCode), "Billing Frequency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingStartOn = group.Add(new VocabularyKey(nameof(BillingStartOn), "Billing Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CancelOn = group.Add(new VocabularyKey(nameof(CancelOn), "Cancellation Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLanguage = group.Add(new VocabularyKey(nameof(ContractLanguage), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractNumber = group.Add(new VocabularyKey(nameof(ContractNumber), "Contract ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractServiceLevelCode = group.Add(new VocabularyKey(nameof(ContractServiceLevelCode), "Service Level", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractTemplateAbbreviation = group.Add(new VocabularyKey(nameof(ContractTemplateAbbreviation), "Template Abbreviation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractTemplateId = group.Add(new VocabularyKey(nameof(ContractTemplateId), "Contract Template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EffectivityCalendar = group.Add(new VocabularyKey(nameof(EffectivityCalendar), "Support Calendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpiresOn = group.Add(new VocabularyKey(nameof(ExpiresOn), "Contract End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NetPrice = group.Add(new VocabularyKey(nameof(NetPrice), "Net Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    NetPriceBase = group.Add(new VocabularyKey(nameof(NetPriceBase), "Net Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalDiscount = group.Add(new VocabularyKey(nameof(TotalDiscount), "Total Discount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalDiscountBase = group.Add(new VocabularyKey(nameof(TotalDiscountBase), "Total Discount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalPrice = group.Add(new VocabularyKey(nameof(TotalPrice), "Total Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalPriceBase = group.Add(new VocabularyKey(nameof(TotalPriceBase), "Total Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UseDiscountAsPercentage = group.Add(new VocabularyKey(nameof(UseDiscountAsPercentage), "Discount", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingAccountId = group.Add(new VocabularyKey(nameof(BillingAccountId), "Billing Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingContactId = group.Add(new VocabularyKey(nameof(BillingContactId), "Billing Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ContractId { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey ActiveOn { get; private set; }
        public VocabularyKey AllotmentTypeCode { get; private set; }
        public VocabularyKey BillingEndOn { get; private set; }
        public VocabularyKey BillingFrequencyCode { get; private set; }
        public VocabularyKey BillingStartOn { get; private set; }
        public VocabularyKey CancelOn { get; private set; }
        public VocabularyKey ContractLanguage { get; private set; }
        public VocabularyKey ContractNumber { get; private set; }
        public VocabularyKey ContractServiceLevelCode { get; private set; }
        public VocabularyKey ContractTemplateAbbreviation { get; private set; }
        public VocabularyKey ContractTemplateId { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey EffectivityCalendar { get; private set; }
        public VocabularyKey ExpiresOn { get; private set; }
        public VocabularyKey NetPrice { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey NetPriceBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TotalDiscount { get; private set; }
        public VocabularyKey TotalDiscountBase { get; private set; }
        public VocabularyKey TotalPrice { get; private set; }
        public VocabularyKey TotalPriceBase { get; private set; }
        public VocabularyKey UseDiscountAsPercentage { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey BillingAccountId { get; private set; }
        public VocabularyKey BillingContactId { get; private set; }
        public VocabularyKey ContactId { get; private set; }
    }
}