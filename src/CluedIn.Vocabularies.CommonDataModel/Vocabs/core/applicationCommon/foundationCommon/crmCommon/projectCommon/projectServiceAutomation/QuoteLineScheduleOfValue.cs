using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class QuoteLineScheduleOfValueVocabulary : SimpleVocabulary
    {
        public QuoteLineScheduleOfValueVocabulary()
        {
            VocabularyName = "Quote Line Schedule Of Value";
            KeyPrefix = "commonDataModel.quotelinescheduleofvalue.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/QuoteLineScheduleOfValue";

            AddGroup("QuoteLineScheduleOfValue Details for ProjectServiceAutomation", group =>
            {
			    QuoteLineScheduleOfValueId = group.Add(new VocabularyKey(nameof(QuoteLineScheduleOfValueId), "Quote Line Schedule Of Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Line Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MilestoneDate = group.Add(new VocabularyKey(nameof(MilestoneDate), "Milestone Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvoiceStatus = group.Add(new VocabularyKey(nameof(InvoiceStatus), "Invoice Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDataImport = group.Add(new VocabularyKey(nameof(IsDataImport), "isdataimport", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    QuoteLine = group.Add(new VocabularyKey(nameof(QuoteLine), "(Deprecated) Quote Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Tax = group.Add(new VocabularyKey(nameof(Tax), "tax", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TaxBase = group.Add(new VocabularyKey(nameof(TaxBase), "tax (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AmountAfterTax = group.Add(new VocabularyKey(nameof(AmountAfterTax), "Milestone Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountAfterTaxBase = group.Add(new VocabularyKey(nameof(AmountAfterTaxBase), "amount_after_tax (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey QuoteLineScheduleOfValueId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey MilestoneDate { get; private set; }
        public VocabularyKey InvoiceStatus { get; private set; }
        public VocabularyKey IsDataImport { get; private set; }
        public VocabularyKey QuoteLine { get; private set; }
        public VocabularyKey Tax { get; private set; }
        public VocabularyKey TaxBase { get; private set; }
        public VocabularyKey AmountAfterTax { get; private set; }
        public VocabularyKey AmountAfterTaxBase { get; private set; }
    }
}