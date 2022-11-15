using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseAppFieldLineEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseAppFieldLineEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse App Field Line Entity";
            KeyPrefix = "commonDataModel.whswarehouseappfieldlineentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseAppFieldLineEntity";

            AddGroup("WHSWarehouseAppFieldLineEntity Details", group =>
            {
                WHSMobileAppField = group.Add(new VocabularyKey(nameof(WHSMobileAppField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseAppFieldGroupPriority = group.Add(new VocabularyKey(nameof(WarehouseAppFieldGroupPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldPriority = group.Add(new VocabularyKey(nameof(FieldPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseAppFieldName = group.Add(new VocabularyKey(nameof(WarehouseAppFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WHSMobileAppField { get; private set; }
        public VocabularyKey WarehouseAppFieldGroupPriority { get; private set; }
        public VocabularyKey FieldPriority { get; private set; }
        public VocabularyKey WarehouseAppFieldName { get; private set; }
    }
}