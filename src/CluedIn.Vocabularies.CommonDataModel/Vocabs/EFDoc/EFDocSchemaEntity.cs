using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EFDocSchemaEntityVocabulary : SimpleVocabulary
    {
        public EFDocSchemaEntityVocabulary()
        {
            VocabularyName = "Common Data Model EFDocSchemaEntity";
            KeyPrefix = "commonDataModel.efdocschemaentity";
            KeySeparator = ".";
            Grouping = "/EFDocSchemaEntity";

            AddGroup("Common Data Model EFDocSchemaEntity Details", group =>
            {
                SchemaType = group.Add(new VocabularyKey(nameof(SchemaType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Version = group.Add(new VocabularyKey(nameof(Version), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SchemaFilePath = group.Add(new VocabularyKey(nameof(SchemaFilePath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SchemaType { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey SchemaFilePath { get; private set; }


    }
}