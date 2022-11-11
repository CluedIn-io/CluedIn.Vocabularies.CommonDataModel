using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerRRGAccountInterval_RUEntityVocabulary : SimpleVocabulary
    {
        public LedgerRRGAccountInterval_RUEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerRRGAccountInterval_RUEntity";
            KeyPrefix = "commonDataModel.ledgerrrgaccountinterval_ruentity";
            KeySeparator = ".";
            Grouping = "/LedgerRRGAccountInterval_RUEntity";

            AddGroup("Common Data Model LedgerRRGAccountInterval_RUEntity Details", group =>
            {
                FromLedgerDimensionAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(FromLedgerDimensionAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToLedgerDimensionAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(ToLedgerDimensionAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationLineId = group.Add(new VocabularyKey(nameof(OperationLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FromLedgerDimensionAccountIdDisplayValue { get; private set; }
        public VocabularyKey ToLedgerDimensionAccountIdDisplayValue { get; private set; }
        public VocabularyKey OperationLineId { get; private set; }


    }
}