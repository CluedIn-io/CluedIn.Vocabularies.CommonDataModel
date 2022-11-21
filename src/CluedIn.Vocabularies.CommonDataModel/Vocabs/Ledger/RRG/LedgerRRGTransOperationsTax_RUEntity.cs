using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerRRGTransOperationsTax_RUEntityVocabulary : SimpleVocabulary
    {
        public LedgerRRGTransOperationsTax_RUEntityVocabulary()
        {
            VocabularyName = "Ledger RRG Trans Operations Tax _RU Entity";
            KeyPrefix = "commonDataModel.ledgerrrgtransoperationstax_ruentity";
            KeySeparator = ".";
            Grouping = "/LedgerRRGTransOperationsTax_RUEntity";

            AddGroup("LedgerRRGTransOperationsTax_RUEntity Details", group =>
            {
                OperationsTax = group.Add(new VocabularyKey(nameof(OperationsTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefTableName = group.Add(new VocabularyKey(nameof(RefTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefLineId = group.Add(new VocabularyKey(nameof(RefLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpTaxRecId = group.Add(new VocabularyKey(nameof(OpTaxRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpTaxTableId = group.Add(new VocabularyKey(nameof(OpTaxTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey OperationsTax { get; private set; }
        public VocabularyKey RefTableName { get; private set; }
        public VocabularyKey RefLineId { get; private set; }
        public VocabularyKey OpTaxRecId { get; private set; }
        public VocabularyKey OpTaxTableId { get; private set; }
    }
}