using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdProductionUnitEntityVocabulary : SimpleVocabulary
    {
        public ProdProductionUnitEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProdProductionUnitEntity";
            KeyPrefix = "commonDataModel.prodproductionunitentity";
            KeySeparator = ".";
            Grouping = "/ProdProductionUnitEntity";

            AddGroup("Common Data Model ProdProductionUnitEntity Details", group =>
            {
                OutputWarehouseId = group.Add(new VocabularyKey(nameof(OutputWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputWarehouseId = group.Add(new VocabularyKey(nameof(InputWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionUnitId = group.Add(new VocabularyKey(nameof(ProductionUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OutputWarehouseId { get; private set; }
        public VocabularyKey InputWarehouseId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey ProductionUnitId { get; private set; }


    }
}