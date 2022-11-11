using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsItemBatchAttributeEntityVocabulary : SimpleVocabulary
    {
        public PdsItemBatchAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model PdsItemBatchAttributeEntity";
            KeyPrefix = "commonDataModel.pdsitembatchattributeentity";
            KeySeparator = ".";
            Grouping = "/PdsItemBatchAttributeEntity";

            AddGroup("Common Data Model PdsItemBatchAttributeEntity Details", group =>
            {
                AttributeId = group.Add(new VocabularyKey(nameof(AttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeType = group.Add(new VocabularyKey(nameof(AttributeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OptimalText = group.Add(new VocabularyKey(nameof(OptimalText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OptimalDate = group.Add(new VocabularyKey(nameof(OptimalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToleranceFailingAction = group.Add(new VocabularyKey(nameof(ToleranceFailingAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumIntegerTolerance = group.Add(new VocabularyKey(nameof(MinimumIntegerTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumIntegerTolerance = group.Add(new VocabularyKey(nameof(MaximumIntegerTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegerToleranceIncrement = group.Add(new VocabularyKey(nameof(IntegerToleranceIncrement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OptimalInteger = group.Add(new VocabularyKey(nameof(OptimalInteger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumDecimalTolerance = group.Add(new VocabularyKey(nameof(MinimumDecimalTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumDecimalTolerance = group.Add(new VocabularyKey(nameof(MaximumDecimalTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecimalToleranceIncrement = group.Add(new VocabularyKey(nameof(DecimalToleranceIncrement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OptimalDecimal = group.Add(new VocabularyKey(nameof(OptimalDecimal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AttributeId { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }
        public VocabularyKey AttributeType { get; private set; }
        public VocabularyKey OptimalText { get; private set; }
        public VocabularyKey OptimalDate { get; private set; }
        public VocabularyKey ToleranceFailingAction { get; private set; }
        public VocabularyKey MinimumIntegerTolerance { get; private set; }
        public VocabularyKey MaximumIntegerTolerance { get; private set; }
        public VocabularyKey IntegerToleranceIncrement { get; private set; }
        public VocabularyKey OptimalInteger { get; private set; }
        public VocabularyKey MinimumDecimalTolerance { get; private set; }
        public VocabularyKey MaximumDecimalTolerance { get; private set; }
        public VocabularyKey DecimalToleranceIncrement { get; private set; }
        public VocabularyKey OptimalDecimal { get; private set; }


    }
}