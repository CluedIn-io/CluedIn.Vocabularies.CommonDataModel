using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeFinancialTagEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeFinancialTagEntityVocabulary()
        {
            VocabularyName = "DimAttributeFinancialTagEntity";
            KeyPrefix = "commonDataModel.dimattributefinancialtagentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeFinancialTagEntity";

            AddGroup("DimAttributeFinancialTagEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName = group.Add(new VocabularyKey(nameof(DimensionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey DimensionName { get; private set; }


    }
}