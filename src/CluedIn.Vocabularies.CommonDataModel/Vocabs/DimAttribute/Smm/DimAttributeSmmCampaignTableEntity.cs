using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeSmmCampaignTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeSmmCampaignTableEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Smm Campaign Table Entity";
            KeyPrefix = "commonDataModel.dimattributesmmcampaigntableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeSmmCampaignTableEntity";

            AddGroup("DimAttributeSmmCampaignTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}