using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class BudgetVocabulary : SimpleVocabulary
    {
        public BudgetVocabulary()
        {
            VocabularyName = "Budget";
            KeyPrefix = "commonDataModel.budget.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Budget";

            AddGroup("Budget Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    BudgetId = group.Add(new VocabularyKey(nameof(BudgetId), "Budget", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetName = group.Add(new VocabularyKey(nameof(BudgetName), "Budget Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalBudget = group.Add(new VocabularyKey(nameof(TotalBudget), "Total Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalBudgetBase = group.Add(new VocabularyKey(nameof(TotalBudgetBase), "Total Budget (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey BudgetId { get; private set; }
        public VocabularyKey BudgetName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey TotalBudget { get; private set; }
        public VocabularyKey TotalBudgetBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}