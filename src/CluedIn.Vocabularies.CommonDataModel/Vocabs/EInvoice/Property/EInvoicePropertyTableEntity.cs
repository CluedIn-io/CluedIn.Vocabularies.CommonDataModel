using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EInvoicePropertyTableEntityVocabulary : SimpleVocabulary
    {
        public EInvoicePropertyTableEntityVocabulary()
        {
            VocabularyName = "EInvoicePropertyTableEntity";
            KeyPrefix = "commonDataModel.einvoicepropertytableentity";
            KeySeparator = ".";
            Grouping = "/EInvoicePropertyTableEntity";

            AddGroup("EInvoicePropertyTableEntity Details", group =>
            {
                RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefTableId = group.Add(new VocabularyKey(nameof(RefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableFieldName = group.Add(new VocabularyKey(nameof(TableFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableFieldValue = group.Add(new VocabularyKey(nameof(TableFieldValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RefRecId { get; private set; }
        public VocabularyKey RefTableId { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey TableName { get; private set; }
        public VocabularyKey TableFieldName { get; private set; }
        public VocabularyKey TableFieldValue { get; private set; }


    }
}