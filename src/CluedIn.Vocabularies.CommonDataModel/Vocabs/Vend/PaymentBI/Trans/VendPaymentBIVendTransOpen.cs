using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIVendTransOpenVocabulary : SimpleVocabulary
    {
        public VendPaymentBIVendTransOpenVocabulary()
        {
            VocabularyName = "Vend Payment BI Vend Trans Open";
            KeyPrefix = "commonDataModel.vendpaymentbivendtransopen";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIVendTransOpen";

            AddGroup("VendPaymentBIVendTransOpen Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountCur = group.Add(new VocabularyKey(nameof(AmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountMST = group.Add(new VocabularyKey(nameof(AmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscAmountCur = group.Add(new VocabularyKey(nameof(CashDiscAmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscCalculationDate = group.Add(new VocabularyKey(nameof(CashDiscCalculationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscDate = group.Add(new VocabularyKey(nameof(CashDiscDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey AmountCur { get; private set; }
        public VocabularyKey AmountMST { get; private set; }
        public VocabularyKey CashDiscAmountCur { get; private set; }
        public VocabularyKey CashDiscCalculationDate { get; private set; }
        public VocabularyKey CashDiscDate { get; private set; }
        public VocabularyKey RefRecId { get; private set; }
    }
}