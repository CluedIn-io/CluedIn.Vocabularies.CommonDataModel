using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeSmmCampaignTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeSmmCampaignTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeSmmCampaignTableEntity";
            KeyPrefix = "commonDataModel.dimattributesmmcampaigntableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeSmmCampaignTableEntity";

            AddGroup("Common Data Model DimAttributeSmmCampaignTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}