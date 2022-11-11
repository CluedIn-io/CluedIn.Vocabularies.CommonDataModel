using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JournalizingTransactionPostingDefinitionReceivableEntityVocabulary : SimpleVocabulary
    {
        public JournalizingTransactionPostingDefinitionReceivableEntityVocabulary()
        {
            VocabularyName = "JournalizingTransactionPostingDefinitionReceivableEntity";
            KeyPrefix = "commonDataModel.journalizingtransactionpostingdefinitionreceivableentity";
            KeySeparator = ".";
            Grouping = "/JournalizingTransactionPostingDefinitionReceivableEntity";

            AddGroup("JournalizingTransactionPostingDefinitionReceivableEntity Details", group =>
            {
                CustBillingClassificationRecId = group.Add(new VocabularyKey(nameof(CustBillingClassificationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustBillingCodeRecId = group.Add(new VocabularyKey(nameof(CustBillingCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerTransactionType = group.Add(new VocabularyKey(nameof(CustomerTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDefinitionRecId = group.Add(new VocabularyKey(nameof(PostingDefinitionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeTypeBillingClassificationBillingCodeAll = group.Add(new VocabularyKey(nameof(AttributeTypeBillingClassificationBillingCodeAll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDefinition = group.Add(new VocabularyKey(nameof(PostingDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingClassification = group.Add(new VocabularyKey(nameof(BillingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingCode = group.Add(new VocabularyKey(nameof(BillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustBillingClassificationRecId { get; private set; }
        public VocabularyKey CustBillingCodeRecId { get; private set; }
        public VocabularyKey CustomerTransactionType { get; private set; }
        public VocabularyKey PostingDefinitionRecId { get; private set; }
        public VocabularyKey AttributeTypeBillingClassificationBillingCodeAll { get; private set; }
        public VocabularyKey PostingDefinition { get; private set; }
        public VocabularyKey BillingClassification { get; private set; }
        public VocabularyKey BillingCode { get; private set; }


    }
}