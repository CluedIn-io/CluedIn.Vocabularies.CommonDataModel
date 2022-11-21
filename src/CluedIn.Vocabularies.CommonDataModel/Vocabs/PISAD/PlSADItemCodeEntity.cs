using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PlSADItemCodeEntityVocabulary : SimpleVocabulary
    {
        public PlSADItemCodeEntityVocabulary()
        {
            VocabularyName = "Pl SAD Item Code Entity";
            KeyPrefix = "commonDataModel.plsaditemcodeentity";
            KeySeparator = ".";
            Grouping = "/PlSADItemCodeEntity";

            AddGroup("PlSADItemCodeEntity Details", group =>
            {
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCommodityCode = group.Add(new VocabularyKey(nameof(ItemCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey ItemCommodityCode { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey MainAccountDisplayValue { get; private set; }
    }
}