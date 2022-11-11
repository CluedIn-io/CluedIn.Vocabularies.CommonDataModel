using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseAppFieldEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseAppFieldEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseAppFieldEntity";
            KeyPrefix = "commonDataModel.whswarehouseappfieldentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseAppFieldEntity";

            AddGroup("WHSWarehouseAppFieldEntity Details", group =>
            {
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputType = group.Add(new VocabularyKey(nameof(InputType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputMode = group.Add(new VocabularyKey(nameof(InputMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey InputType { get; private set; }
        public VocabularyKey InputMode { get; private set; }


    }
}