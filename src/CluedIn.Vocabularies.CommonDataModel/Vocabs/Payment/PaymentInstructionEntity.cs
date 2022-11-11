using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentInstructionEntityVocabulary : SimpleVocabulary
    {
        public PaymentInstructionEntityVocabulary()
        {
            VocabularyName = "PaymentInstructionEntity";
            KeyPrefix = "commonDataModel.paymentinstructionentity";
            KeySeparator = ".";
            Grouping = "/PaymentInstructionEntity";

            AddGroup("PaymentInstructionEntity Details", group =>
            {
                PaymentInstructionCode = group.Add(new VocabularyKey(nameof(PaymentInstructionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PaymentInstructionCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}