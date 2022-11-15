using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicPaymentInstructionEntityVocabulary : SimpleVocabulary
    {
        public ElectronicPaymentInstructionEntityVocabulary()
        {
            VocabularyName = "Electronic Payment Instruction Entity";
            KeyPrefix = "commonDataModel.electronicpaymentinstructionentity";
            KeySeparator = ".";
            Grouping = "/ElectronicPaymentInstructionEntity";

            AddGroup("ElectronicPaymentInstructionEntity Details", group =>
            {
                LayoutGroupId = group.Add(new VocabularyKey(nameof(LayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Instruction = group.Add(new VocabularyKey(nameof(Instruction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LayoutGroupId { get; private set; }
        public VocabularyKey Instruction { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Quantity { get; private set; }
    }
}