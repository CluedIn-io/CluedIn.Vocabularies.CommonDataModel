using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesCampaignMediaTypeEntityVocabulary : SimpleVocabulary
    {
        public SalesCampaignMediaTypeEntityVocabulary()
        {
            VocabularyName = "SalesCampaignMediaTypeEntity";
            KeyPrefix = "commonDataModel.salescampaignmediatypeentity";
            KeySeparator = ".";
            Grouping = "/SalesCampaignMediaTypeEntity";

            AddGroup("SalesCampaignMediaTypeEntity Details", group =>
            {
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey TypeId { get; private set; }


    }
}