using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JournalizingTransactionPostingDefinitionPayableEntityVocabulary : SimpleVocabulary
    {
        public JournalizingTransactionPostingDefinitionPayableEntityVocabulary()
        {
            VocabularyName = "JournalizingTransactionPostingDefinitionPayableEntity";
            KeyPrefix = "commonDataModel.journalizingtransactionpostingdefinitionpayableentity";
            KeySeparator = ".";
            Grouping = "/JournalizingTransactionPostingDefinitionPayableEntity";

            AddGroup("JournalizingTransactionPostingDefinitionPayableEntity Details", group =>
            {
                AccountsPayableTransactionType = group.Add(new VocabularyKey(nameof(AccountsPayableTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryRelationRecId = group.Add(new VocabularyKey(nameof(CategoryRelationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCodeTableGroupCategoryAll = group.Add(new VocabularyKey(nameof(ItemCodeTableGroupCategoryAll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelationGroup = group.Add(new VocabularyKey(nameof(ItemRelationGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelationNumber = group.Add(new VocabularyKey(nameof(ItemRelationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDefinition = group.Add(new VocabularyKey(nameof(PostingDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelationVendorAccount = group.Add(new VocabularyKey(nameof(AccountRelationVendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCodeTableGroupAll = group.Add(new VocabularyKey(nameof(AccountCodeTableGroupAll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelationVendorGroup = group.Add(new VocabularyKey(nameof(AccountRelationVendorGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDefinitionId = group.Add(new VocabularyKey(nameof(PostingDefinitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryRelation = group.Add(new VocabularyKey(nameof(CategoryRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountsPayableTransactionType { get; private set; }
        public VocabularyKey CategoryRelationRecId { get; private set; }
        public VocabularyKey ItemCodeTableGroupCategoryAll { get; private set; }
        public VocabularyKey ItemRelationGroup { get; private set; }
        public VocabularyKey ItemRelationNumber { get; private set; }
        public VocabularyKey PostingDefinition { get; private set; }
        public VocabularyKey AccountRelationVendorAccount { get; private set; }
        public VocabularyKey AccountCodeTableGroupAll { get; private set; }
        public VocabularyKey AccountRelationVendorGroup { get; private set; }
        public VocabularyKey PostingDefinitionId { get; private set; }
        public VocabularyKey CategoryRelation { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }


    }
}