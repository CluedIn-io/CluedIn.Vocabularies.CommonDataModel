using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMPaymentDeductionDenyReasonEntityVocabulary : SimpleVocabulary
    {
        public TAMPaymentDeductionDenyReasonEntityVocabulary()
        {
            VocabularyName = "TAM Payment Deduction Deny Reason Entity";
            KeyPrefix = "commonDataModel.tampaymentdeductiondenyreasonentity";
            KeySeparator = ".";
            Grouping = "/TAMPaymentDeductionDenyReasonEntity";

            AddGroup("TAMPaymentDeductionDenyReasonEntity Details", group =>
            {
                PaymentDeductionDenyReasonCode = group.Add(new VocabularyKey(nameof(PaymentDeductionDenyReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PaymentDeductionDenyReasonCode { get; private set; }
        public VocabularyKey ReasonDescription { get; private set; }
    }
}