using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class BudgetVocabulary : SimpleVocabulary
    {
        public BudgetVocabulary()
        {
            VocabularyName = "Budget";
            KeyPrefix = "commonDataModel.budget.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/Budget";

            AddGroup("Budget Details for NonProfitIati", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetStatus = group.Add(new VocabularyKey(nameof(BudgetStatus), "Budget Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetType = group.Add(new VocabularyKey(nameof(BudgetType), "Organization Budget Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CurrencyValueDate = group.Add(new VocabularyKey(nameof(CurrencyValueDate), "Currency Value Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Percentage = group.Add(new VocabularyKey(nameof(Percentage), "Percentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProviderActivityIdentifier = group.Add(new VocabularyKey(nameof(ProviderActivityIdentifier), "Provider Activity Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientActivityIdentifier = group.Add(new VocabularyKey(nameof(RecipientActivityIdentifier), "Recipient Activity Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientCountryDescription = group.Add(new VocabularyKey(nameof(RecipientCountryDescription), "Recipient Country Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientRegionDescription = group.Add(new VocabularyKey(nameof(RecipientRegionDescription), "Recipient Region Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Reference = group.Add(new VocabularyKey(nameof(Reference), "Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedTo = group.Add(new VocabularyKey(nameof(RelatedTo), "Related To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetId = group.Add(new VocabularyKey(nameof(BudgetId), "Budget", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetName = group.Add(new VocabularyKey(nameof(BudgetName), "Budget Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalBudget = group.Add(new VocabularyKey(nameof(TotalBudget), "Total Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Totalbudget_Base = group.Add(new VocabularyKey(nameof(Totalbudget_Base), "Total Budget (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey BudgetStatus { get; private set; }
        public VocabularyKey BudgetType { get; private set; }
        public VocabularyKey CurrencyValueDate { get; private set; }
        public VocabularyKey Percentage { get; private set; }
        public VocabularyKey ProviderActivityIdentifier { get; private set; }
        public VocabularyKey RecipientActivityIdentifier { get; private set; }
        public VocabularyKey RecipientCountryDescription { get; private set; }
        public VocabularyKey RecipientRegionDescription { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey RelatedTo { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey BudgetId { get; private set; }
        public VocabularyKey BudgetName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey TotalBudget { get; private set; }
        public VocabularyKey Totalbudget_Base { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}