using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class SponsorableArticleVocabulary : SimpleVocabulary
    {
        public SponsorableArticleVocabulary()
        {
            VocabularyName = "Sponsorable Article";
            KeyPrefix = "commonDataModel.sponsorablearticle.eventmanagement";
            KeySeparator = ".";
            Grouping = "/SponsorableArticle";

            AddGroup("SponsorableArticle Details for EventManagement", group =>
            {
			    SponsorableArticleId = group.Add(new VocabularyKey(nameof(SponsorableArticleId), "Sponsorable Article", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostPerUnit = group.Add(new VocabularyKey(nameof(CostPerUnit), "Cost per unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostPerUnitBase = group.Add(new VocabularyKey(nameof(CostPerUnitBase), "Cost per unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfUnits = group.Add(new VocabularyKey(nameof(NumberOfUnits), "Number of units", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), "Currency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalCost = group.Add(new VocabularyKey(nameof(TotalCost), "Total cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalcostBase = group.Add(new VocabularyKey(nameof(TotalcostBase), "Total cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SponsorableArticleId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CostPerUnit { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CostPerUnitBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey NumberOfUnits { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey TotalCost { get; private set; }
        public VocabularyKey TotalcostBase { get; private set; }
    }
}