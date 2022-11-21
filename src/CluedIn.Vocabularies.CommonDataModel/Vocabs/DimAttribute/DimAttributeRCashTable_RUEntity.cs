using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeRCashTable_RUEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeRCashTable_RUEntityVocabulary()
        {
            VocabularyName = "Dim Attribute R Cash Table _RU Entity";
            KeyPrefix = "commonDataModel.dimattributercashtable_ruentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeRCashTable_RUEntity";

            AddGroup("DimAttributeRCashTable_RUEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}