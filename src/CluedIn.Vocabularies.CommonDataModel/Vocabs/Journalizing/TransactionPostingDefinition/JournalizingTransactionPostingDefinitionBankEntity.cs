using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JournalizingTransactionPostingDefinitionBankEntityVocabulary : SimpleVocabulary
    {
        public JournalizingTransactionPostingDefinitionBankEntityVocabulary()
        {
            VocabularyName = "JournalizingTransactionPostingDefinitionBankEntity";
            KeyPrefix = "commonDataModel.journalizingtransactionpostingdefinitionbankentity";
            KeySeparator = ".";
            Grouping = "/JournalizingTransactionPostingDefinitionBankEntity";

            AddGroup("JournalizingTransactionPostingDefinitionBankEntity Details", group =>
            {
                BankCodeTableGroupAll = group.Add(new VocabularyKey(nameof(BankCodeTableGroupAll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankRelationGroup = group.Add(new VocabularyKey(nameof(BankRelationGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankRelationTable = group.Add(new VocabularyKey(nameof(BankRelationTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankTransactionType = group.Add(new VocabularyKey(nameof(BankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDefinition = group.Add(new VocabularyKey(nameof(PostingDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodOfPaymentTableAll = group.Add(new VocabularyKey(nameof(MethodOfPaymentTableAll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodOfPayment = group.Add(new VocabularyKey(nameof(MethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDefinitionId = group.Add(new VocabularyKey(nameof(PostingDefinitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BankCodeTableGroupAll { get; private set; }
        public VocabularyKey BankRelationGroup { get; private set; }
        public VocabularyKey BankRelationTable { get; private set; }
        public VocabularyKey BankTransactionType { get; private set; }
        public VocabularyKey PostingDefinition { get; private set; }
        public VocabularyKey MethodOfPaymentTableAll { get; private set; }
        public VocabularyKey MethodOfPayment { get; private set; }
        public VocabularyKey PostingDefinitionId { get; private set; }


    }
}