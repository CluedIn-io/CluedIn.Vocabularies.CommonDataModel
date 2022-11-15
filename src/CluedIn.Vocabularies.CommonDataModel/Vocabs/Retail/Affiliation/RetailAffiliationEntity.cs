using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAffiliationEntityVocabulary : SimpleVocabulary
    {
        public RetailAffiliationEntityVocabulary()
        {
            VocabularyName = "Retail Affiliation Entity";
            KeyPrefix = "commonDataModel.retailaffiliationentity";
            KeySeparator = ".";
            Grouping = "/RetailAffiliationEntity";

            AddGroup("RetailAffiliationEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HideInChannels = group.Add(new VocabularyKey(nameof(HideInChannels), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey HideInChannels { get; private set; }
    }
}