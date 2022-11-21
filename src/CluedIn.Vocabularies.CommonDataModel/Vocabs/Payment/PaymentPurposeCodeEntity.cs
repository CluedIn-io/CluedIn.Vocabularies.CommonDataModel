using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentPurposeCodeEntityVocabulary : SimpleVocabulary
    {
        public PaymentPurposeCodeEntityVocabulary()
        {
            VocabularyName = "Payment Purpose Code Entity";
            KeyPrefix = "commonDataModel.paymentpurposecodeentity";
            KeySeparator = ".";
            Grouping = "/PaymentPurposeCodeEntity";

            AddGroup("PaymentPurposeCodeEntity Details", group =>
            {
                CodeId = group.Add(new VocabularyKey(nameof(CodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescriptionText = group.Add(new VocabularyKey(nameof(DescriptionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CodeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey DescriptionText { get; private set; }
    }
}