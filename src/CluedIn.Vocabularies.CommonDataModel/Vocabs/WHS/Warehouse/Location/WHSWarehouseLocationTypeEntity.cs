using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationTypeEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationTypeEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Location Type Entity";
            KeyPrefix = "commonDataModel.whswarehouselocationtypeentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationTypeEntity";

            AddGroup("WHSWarehouseLocationTypeEntity Details", group =>
            {
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey TypeId { get; private set; }
    }
}