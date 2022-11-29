using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class ExpenditureVocabulary : SimpleVocabulary
    {
        public ExpenditureVocabulary()
        {
            VocabularyName = "Expenditure";
            KeyPrefix = "commonDataModel.expenditure.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/Expenditure";

            AddGroup("Expenditure Details for NonProfitIati", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CurrencyValueDate = group.Add(new VocabularyKey(nameof(CurrencyValueDate), "Currency Value Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpenditureId = group.Add(new VocabularyKey(nameof(ExpenditureId), "Expenditure", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Humanitarian = group.Add(new VocabularyKey(nameof(Humanitarian), "Humanitarian", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProviderActivityIdentifierId = group.Add(new VocabularyKey(nameof(ProviderActivityIdentifierId), "Provider Activity Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientActivityIdentifier = group.Add(new VocabularyKey(nameof(RecipientActivityIdentifier), "Recipient Activity Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientCountryDescription = group.Add(new VocabularyKey(nameof(RecipientCountryDescription), "Recipient Country Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientRegionDescription = group.Add(new VocabularyKey(nameof(RecipientRegionDescription), "Recipient Region Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Reference = group.Add(new VocabularyKey(nameof(Reference), "Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedTo = group.Add(new VocabularyKey(nameof(RelatedTo), "Related To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalExpenditure = group.Add(new VocabularyKey(nameof(TotalExpenditure), "Total Expenditure", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Totalexpenditure_Base = group.Add(new VocabularyKey(nameof(Totalexpenditure_Base), "Total Expenditure (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), "Transaction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CurrencyValueDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ExpenditureId { get; private set; }
        public VocabularyKey Humanitarian { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProviderActivityIdentifierId { get; private set; }
        public VocabularyKey RecipientActivityIdentifier { get; private set; }
        public VocabularyKey RecipientCountryDescription { get; private set; }
        public VocabularyKey RecipientRegionDescription { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey RelatedTo { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey TotalExpenditure { get; private set; }
        public VocabularyKey Totalexpenditure_Base { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}