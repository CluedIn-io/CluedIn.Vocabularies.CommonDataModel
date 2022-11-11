using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatTransactionCodeEntityVocabulary : SimpleVocabulary
    {
        public IntrastatTransactionCodeEntityVocabulary()
        {
            VocabularyName = "IntrastatTransactionCodeEntity";
            KeyPrefix = "commonDataModel.intrastattransactioncodeentity";
            KeySeparator = ".";
            Grouping = "/IntrastatTransactionCodeEntity";

            AddGroup("IntrastatTransactionCodeEntity Details", group =>
            {
                TransactionCode = group.Add(new VocabularyKey(nameof(TransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderAmountValueType = group.Add(new VocabularyKey(nameof(TransferOrderAmountValueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StaticalValue = group.Add(new VocabularyKey(nameof(StaticalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAmountCalcMethod = group.Add(new VocabularyKey(nameof(InvoiceAmountCalcMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalAmountCalcMethod = group.Add(new VocabularyKey(nameof(StatisticalAmountCalcMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalAmount = group.Add(new VocabularyKey(nameof(StatisticalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectTrade = group.Add(new VocabularyKey(nameof(IndirectTrade), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TransactionCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TransferOrderAmountValueType { get; private set; }
        public VocabularyKey StaticalValue { get; private set; }
        public VocabularyKey InvoiceAmountCalcMethod { get; private set; }
        public VocabularyKey StatisticalAmountCalcMethod { get; private set; }
        public VocabularyKey StatisticalAmount { get; private set; }
        public VocabularyKey IndirectTrade { get; private set; }


    }
}