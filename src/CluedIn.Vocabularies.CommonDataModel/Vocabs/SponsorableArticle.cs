using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SponsorableArticleVocabulary : SimpleVocabulary
    {
        public SponsorableArticleVocabulary()
        {
            VocabularyName = "Common Data Model SponsorableArticle";
            KeyPrefix = "commonDataModel.sponsorablearticle";
            KeySeparator = ".";
            Grouping = "/SponsorableArticle";

            AddGroup("Common Data Model SponsorableArticle Details", group =>
            {
                exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                costPerUnit = group.Add(new VocabularyKey(nameof(costPerUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                costPerUnitBase = group.Add(new VocabularyKey(nameof(costPerUnitBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                numberOfUnits = group.Add(new VocabularyKey(nameof(numberOfUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sponsorableArticleId = group.Add(new VocabularyKey(nameof(sponsorableArticleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                totalCost = group.Add(new VocabularyKey(nameof(totalCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                totalCostBase = group.Add(new VocabularyKey(nameof(totalCostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey exchangeRate { get; private set; }
        public VocabularyKey costPerUnit { get; private set; }
        public VocabularyKey costPerUnitBase { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey numberOfUnits { get; private set; }
        public VocabularyKey sponsorableArticleId { get; private set; }
        public VocabularyKey totalCost { get; private set; }
        public VocabularyKey totalCostBase { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}