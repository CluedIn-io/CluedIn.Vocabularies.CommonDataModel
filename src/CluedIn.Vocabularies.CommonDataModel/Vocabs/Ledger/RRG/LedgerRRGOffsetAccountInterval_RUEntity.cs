using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerRRGOffsetAccountInterval_RUEntityVocabulary : SimpleVocabulary
    {
        public LedgerRRGOffsetAccountInterval_RUEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerRRGOffsetAccountInterval_RUEntity";
            KeyPrefix = "commonDataModel.ledgerrrgoffsetaccountinterval_ruentity";
            KeySeparator = ".";
            Grouping = "/LedgerRRGOffsetAccountInterval_RUEntity";

            AddGroup("Common Data Model LedgerRRGOffsetAccountInterval_RUEntity Details", group =>
            {
                FromLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(FromLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(ToLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationLineId = group.Add(new VocabularyKey(nameof(OperationLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FromLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ToLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey OperationLineId { get; private set; }


    }
}