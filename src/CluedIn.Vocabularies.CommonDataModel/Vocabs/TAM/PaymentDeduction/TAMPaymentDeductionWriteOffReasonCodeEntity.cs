using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMPaymentDeductionWriteOffReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public TAMPaymentDeductionWriteOffReasonCodeEntityVocabulary()
        {
            VocabularyName = "TAM Payment Deduction Write Off Reason Code Entity";
            KeyPrefix = "commonDataModel.tampaymentdeductionwriteoffreasoncodeentity";
            KeySeparator = ".";
            Grouping = "/TAMPaymentDeductionWriteOffReasonCodeEntity";

            AddGroup("TAMPaymentDeductionWriteOffReasonCodeEntity Details", group =>
            {
                WriteOffMainAccountId = group.Add(new VocabularyKey(nameof(WriteOffMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWriteOffAmount = group.Add(new VocabularyKey(nameof(MaximumWriteOffAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(WriteOffMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WriteOffMainAccountId { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ReasonDescription { get; private set; }
        public VocabularyKey MaximumWriteOffAmount { get; private set; }
        public VocabularyKey WriteOffMainAccountIdDisplayValue { get; private set; }
    }
}