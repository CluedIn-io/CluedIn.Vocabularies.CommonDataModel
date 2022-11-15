using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderUpdateLinesParametersEntityVocabulary : SimpleVocabulary
    {
        public SalesOrderUpdateLinesParametersEntityVocabulary()
        {
            VocabularyName = "Sales Order Update Lines Parameters Entity";
            KeyPrefix = "commonDataModel.salesorderupdatelinesparametersentity";
            KeySeparator = ".";
            Grouping = "/SalesOrderUpdateLinesParametersEntity";

            AddGroup("SalesOrderUpdateLinesParametersEntity Details", group =>
            {
                SalesOrderHeaderFieldName = group.Add(new VocabularyKey(nameof(SalesOrderHeaderFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderLineUpdateRule = group.Add(new VocabularyKey(nameof(SalesOrderLineUpdateRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldId = group.Add(new VocabularyKey(nameof(FieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SalesOrderHeaderFieldName { get; private set; }
        public VocabularyKey SalesOrderLineUpdateRule { get; private set; }
        public VocabularyKey FieldId { get; private set; }
    }
}