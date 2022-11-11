using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIUtilizedCashDiscVocabulary : SimpleVocabulary
    {
        public VendPaymentBIUtilizedCashDiscVocabulary()
        {
            VocabularyName = "Common Data Model VendPaymentBIUtilizedCashDisc";
            KeyPrefix = "commonDataModel.vendpaymentbiutilizedcashdisc";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIUtilizedCashDisc";

            AddGroup("Common Data Model VendPaymentBIUtilizedCashDisc Details", group =>
            {
                TransRecId = group.Add(new VocabularyKey(nameof(TransRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UtilizedCashDisc = group.Add(new VocabularyKey(nameof(UtilizedCashDisc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TransRecId { get; private set; }
        public VocabularyKey UtilizedCashDisc { get; private set; }


    }
}