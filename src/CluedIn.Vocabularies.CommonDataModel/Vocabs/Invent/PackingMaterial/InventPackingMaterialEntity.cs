using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventPackingMaterialEntityVocabulary : SimpleVocabulary
    {
        public InventPackingMaterialEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventPackingMaterialEntity";
            KeyPrefix = "commonDataModel.inventpackingmaterialentity";
            KeySeparator = ".";
            Grouping = "/InventPackingMaterialEntity";

            AddGroup("Common Data Model InventPackingMaterialEntity Details", group =>
            {
                MaterialName = group.Add(new VocabularyKey(nameof(MaterialName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaterialCode = group.Add(new VocabularyKey(nameof(MaterialCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MaterialName { get; private set; }
        public VocabularyKey MaterialCode { get; private set; }
        public VocabularyKey UnitSymbol { get; private set; }


    }
}