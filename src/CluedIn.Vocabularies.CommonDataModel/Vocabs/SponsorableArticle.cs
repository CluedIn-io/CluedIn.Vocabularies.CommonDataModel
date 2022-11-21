using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SponsorableArticleVocabulary : SimpleVocabulary
    {
        public SponsorableArticleVocabulary()
        {
            VocabularyName = "Sponsorable Article";
            KeyPrefix = "commonDataModel.sponsorablearticle";
            KeySeparator = ".";
            Grouping = "/SponsorableArticle";

            AddGroup("SponsorableArticle Details", group =>
            {
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPerUnit = group.Add(new VocabularyKey(nameof(CostPerUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPerUnitBase = group.Add(new VocabularyKey(nameof(CostPerUnitBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfUnits = group.Add(new VocabularyKey(nameof(NumberOfUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SponsorableArticleId = group.Add(new VocabularyKey(nameof(SponsorableArticleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCost = group.Add(new VocabularyKey(nameof(TotalCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCostBase = group.Add(new VocabularyKey(nameof(TotalCostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CostPerUnit { get; private set; }
        public VocabularyKey CostPerUnitBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NumberOfUnits { get; private set; }
        public VocabularyKey SponsorableArticleId { get; private set; }
        public VocabularyKey TotalCost { get; private set; }
        public VocabularyKey TotalCostBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}