using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvValidatePaymentEntityVocabulary : SimpleVocabulary
    {
        public TrvValidatePaymentEntityVocabulary()
        {
            VocabularyName = "Trv Validate Payment Entity";
            KeyPrefix = "commonDataModel.trvvalidatepaymententity";
            KeySeparator = ".";
            Grouping = "/TrvValidatePaymentEntity";

            AddGroup("TrvValidatePaymentEntity Details", group =>
            {
                ExpenseCategory = group.Add(new VocabularyKey(nameof(ExpenseCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMethod = group.Add(new VocabularyKey(nameof(PaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ExpenseCategory { get; private set; }
        public VocabularyKey PaymentMethod { get; private set; }
    }
}