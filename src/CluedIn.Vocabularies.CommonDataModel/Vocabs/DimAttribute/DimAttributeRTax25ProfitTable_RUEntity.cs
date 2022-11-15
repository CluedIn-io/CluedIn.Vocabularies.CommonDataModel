using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeRTax25ProfitTable_RUEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeRTax25ProfitTable_RUEntityVocabulary()
        {
            VocabularyName = "Dim Attribute R Tax 25 Profit Table _RU Entity";
            KeyPrefix = "commonDataModel.dimattributertax25profittable_ruentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeRTax25ProfitTable_RUEntity";

            AddGroup("DimAttributeRTax25ProfitTable_RUEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}