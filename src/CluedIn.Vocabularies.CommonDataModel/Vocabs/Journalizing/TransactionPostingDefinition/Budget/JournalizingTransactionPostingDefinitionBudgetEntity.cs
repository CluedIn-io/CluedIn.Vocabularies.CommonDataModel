using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JournalizingTransactionPostingDefinitionBudgetEntityVocabulary : SimpleVocabulary
    {
        public JournalizingTransactionPostingDefinitionBudgetEntityVocabulary()
        {
            VocabularyName = "JournalizingTransactionPostingDefinitionBudgetEntity";
            KeyPrefix = "commonDataModel.journalizingtransactionpostingdefinitionbudgetentity";
            KeySeparator = ".";
            Grouping = "/JournalizingTransactionPostingDefinitionBudgetEntity";

            AddGroup("JournalizingTransactionPostingDefinitionBudgetEntity Details", group =>
            {
                BudgetTransactionCode = group.Add(new VocabularyKey(nameof(BudgetTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetType = group.Add(new VocabularyKey(nameof(BudgetType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetCodeTableAll = group.Add(new VocabularyKey(nameof(BudgetCodeTableAll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDefinition = group.Add(new VocabularyKey(nameof(PostingDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetCodeRelationName = group.Add(new VocabularyKey(nameof(BudgetCodeRelationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDefinitionId = group.Add(new VocabularyKey(nameof(PostingDefinitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BudgetTransactionCode { get; private set; }
        public VocabularyKey BudgetType { get; private set; }
        public VocabularyKey BudgetCodeTableAll { get; private set; }
        public VocabularyKey PostingDefinition { get; private set; }
        public VocabularyKey BudgetCodeRelationName { get; private set; }
        public VocabularyKey PostingDefinitionId { get; private set; }


    }
}