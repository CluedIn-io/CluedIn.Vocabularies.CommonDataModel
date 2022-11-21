using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseSlottingUnitOfMeasureTierEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseSlottingUnitOfMeasureTierEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Slotting Unit Of Measure Tier Entity";
            KeyPrefix = "commonDataModel.whswarehouseslottingunitofmeasuretierentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseSlottingUnitOfMeasureTierEntity";

            AddGroup("WHSWarehouseSlottingUnitOfMeasureTierEntity Details", group =>
            {
                TierDescription = group.Add(new VocabularyKey(nameof(TierDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TierId = group.Add(new VocabularyKey(nameof(TierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TierDescription { get; private set; }
        public VocabularyKey TierId { get; private set; }
    }
}