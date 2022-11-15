using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpenseReportFieldEntityVocabulary : SimpleVocabulary
    {
        public TrvExpenseReportFieldEntityVocabulary()
        {
            VocabularyName = "Trv Expense Report Field Entity";
            KeyPrefix = "commonDataModel.trvexpensereportfieldentity";
            KeySeparator = ".";
            Grouping = "/TrvExpenseReportFieldEntity";

            AddGroup("TrvExpenseReportFieldEntity Details", group =>
            {
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodName = group.Add(new VocabularyKey(nameof(MethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefFieldId = group.Add(new VocabularyKey(nameof(RefFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefTableId = group.Add(new VocabularyKey(nameof(RefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowInForm = group.Add(new VocabularyKey(nameof(ShowInForm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Visibility = group.Add(new VocabularyKey(nameof(Visibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey MethodName { get; private set; }
        public VocabularyKey RefFieldId { get; private set; }
        public VocabularyKey RefTableId { get; private set; }
        public VocabularyKey ShowInForm { get; private set; }
        public VocabularyKey Visibility { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey TableName { get; private set; }
        public VocabularyKey FieldName { get; private set; }
    }
}