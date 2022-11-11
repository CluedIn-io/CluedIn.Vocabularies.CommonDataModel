using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExpenseFieldsVisibilityEntityVocabulary : SimpleVocabulary
    {
        public ExpenseFieldsVisibilityEntityVocabulary()
        {
            VocabularyName = "Common Data Model ExpenseFieldsVisibilityEntity";
            KeyPrefix = "commonDataModel.expensefieldsvisibilityentity";
            KeySeparator = ".";
            Grouping = "/ExpenseFieldsVisibilityEntity";

            AddGroup("Common Data Model ExpenseFieldsVisibilityEntity Details", group =>
            {
                Area = group.Add(new VocabularyKey(nameof(Area), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisibilityType = group.Add(new VocabularyKey(nameof(VisibilityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseFieldName = group.Add(new VocabularyKey(nameof(ExpenseFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceTableID = group.Add(new VocabularyKey(nameof(ReferenceTableID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Area { get; private set; }
        public VocabularyKey VisibilityType { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey ExpenseFieldName { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey ReferenceTableID { get; private set; }
        public VocabularyKey TableName { get; private set; }
        public VocabularyKey FieldName { get; private set; }


    }
}