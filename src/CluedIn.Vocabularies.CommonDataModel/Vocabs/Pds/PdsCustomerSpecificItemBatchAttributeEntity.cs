using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsCustomerSpecificItemBatchAttributeEntityVocabulary : SimpleVocabulary
    {
        public PdsCustomerSpecificItemBatchAttributeEntityVocabulary()
        {
            VocabularyName = "PdsCustomerSpecificItemBatchAttributeEntity";
            KeyPrefix = "commonDataModel.pdscustomerspecificitembatchattributeentity";
            KeySeparator = ".";
            Grouping = "/PdsCustomerSpecificItemBatchAttributeEntity";

            AddGroup("PdsCustomerSpecificItemBatchAttributeEntity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchAttributeAccountCode = group.Add(new VocabularyKey(nameof(BatchAttributeAccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchAttributeAccountRelation = group.Add(new VocabularyKey(nameof(BatchAttributeAccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerGroupId = group.Add(new VocabularyKey(nameof(CustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchAttributeCode = group.Add(new VocabularyKey(nameof(BatchAttributeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchAttributeRelation = group.Add(new VocabularyKey(nameof(BatchAttributeRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchAttributeId = group.Add(new VocabularyKey(nameof(ItemBatchAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchAttributeGroupId = group.Add(new VocabularyKey(nameof(ItemBatchAttributeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumTolerance = group.Add(new VocabularyKey(nameof(MinimumTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumTolerance = group.Add(new VocabularyKey(nameof(MaximumTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumIntegerTolerance = group.Add(new VocabularyKey(nameof(MinimumIntegerTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumIntegerTolerance = group.Add(new VocabularyKey(nameof(MaximumIntegerTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumDecimalTolerance = group.Add(new VocabularyKey(nameof(MinimumDecimalTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumDecimalTolerance = group.Add(new VocabularyKey(nameof(MaximumDecimalTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey BatchAttributeAccountCode { get; private set; }
        public VocabularyKey BatchAttributeAccountRelation { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey CustomerGroupId { get; private set; }
        public VocabularyKey BatchAttributeCode { get; private set; }
        public VocabularyKey BatchAttributeRelation { get; private set; }
        public VocabularyKey ItemBatchAttributeId { get; private set; }
        public VocabularyKey ItemBatchAttributeGroupId { get; private set; }
        public VocabularyKey MinimumTolerance { get; private set; }
        public VocabularyKey MaximumTolerance { get; private set; }
        public VocabularyKey MinimumIntegerTolerance { get; private set; }
        public VocabularyKey MaximumIntegerTolerance { get; private set; }
        public VocabularyKey MinimumDecimalTolerance { get; private set; }
        public VocabularyKey MaximumDecimalTolerance { get; private set; }


    }
}