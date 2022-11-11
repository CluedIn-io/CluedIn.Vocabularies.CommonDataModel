using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventByProductTableEntityVocabulary : SimpleVocabulary
    {
        public InventByProductTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventByProductTableEntity";
            KeyPrefix = "commonDataModel.inventbyproducttableentity";
            KeySeparator = ".";
            Grouping = "/InventByProductTableEntity";

            AddGroup("Common Data Model InventByProductTableEntity Details", group =>
            {
                CostingRule = group.Add(new VocabularyKey(nameof(CostingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionNumberByProd = group.Add(new VocabularyKey(nameof(DimensionNumberByProd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionNumberMain = group.Add(new VocabularyKey(nameof(DimensionNumberMain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemIdByProd = group.Add(new VocabularyKey(nameof(ItemIdByProd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainProduct = group.Add(new VocabularyKey(nameof(MainProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percentage = group.Add(new VocabularyKey(nameof(Percentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CostingRule { get; private set; }
        public VocabularyKey DimensionNumberByProd { get; private set; }
        public VocabularyKey DimensionNumberMain { get; private set; }
        public VocabularyKey ItemIdByProd { get; private set; }
        public VocabularyKey MainProduct { get; private set; }
        public VocabularyKey Percentage { get; private set; }


    }
}