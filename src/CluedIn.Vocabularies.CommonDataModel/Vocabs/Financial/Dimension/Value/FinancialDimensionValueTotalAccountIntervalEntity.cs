using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FinancialDimensionValueTotalAccountIntervalEntityVocabulary : SimpleVocabulary
    {
        public FinancialDimensionValueTotalAccountIntervalEntityVocabulary()
        {
            VocabularyName = "Common Data Model FinancialDimensionValueTotalAccountIntervalEntity";
            KeyPrefix = "commonDataModel.financialdimensionvaluetotalaccountintervalentity";
            KeySeparator = ".";
            Grouping = "/FinancialDimensionValueTotalAccountIntervalEntity";

            AddGroup("Common Data Model FinancialDimensionValueTotalAccountIntervalEntity Details", group =>
            {
                FinancialDimension = group.Add(new VocabularyKey(nameof(FinancialDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue = group.Add(new VocabularyKey(nameof(DimensionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromValue = group.Add(new VocabularyKey(nameof(FromValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToValue = group.Add(new VocabularyKey(nameof(ToValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvertTotalSign = group.Add(new VocabularyKey(nameof(InvertTotalSign), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FinancialDimension { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey DimensionValue { get; private set; }
        public VocabularyKey FromValue { get; private set; }
        public VocabularyKey ToValue { get; private set; }
        public VocabularyKey InvertTotalSign { get; private set; }


    }
}