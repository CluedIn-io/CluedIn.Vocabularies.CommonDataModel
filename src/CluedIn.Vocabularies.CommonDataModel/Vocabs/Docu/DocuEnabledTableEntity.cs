using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DocuEnabledTableEntityVocabulary : SimpleVocabulary
    {
        public DocuEnabledTableEntityVocabulary()
        {
            VocabularyName = "DocuEnabledTableEntity";
            KeyPrefix = "commonDataModel.docuenabledtableentity";
            KeySeparator = ".";
            Grouping = "/DocuEnabledTableEntity";

            AddGroup("DocuEnabledTableEntity Details", group =>
            {
                AllowEditAlways = group.Add(new VocabularyKey(nameof(AllowEditAlways), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableEnabledId = group.Add(new VocabularyKey(nameof(TableEnabledId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AllowEditAlways { get; private set; }
        public VocabularyKey TableEnabledId { get; private set; }
        public VocabularyKey TableName { get; private set; }


    }
}