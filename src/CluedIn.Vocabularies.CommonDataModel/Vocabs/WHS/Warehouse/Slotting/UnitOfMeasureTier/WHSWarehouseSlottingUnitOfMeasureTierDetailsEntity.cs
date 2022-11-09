using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseSlottingUnitOfMeasureTierDetailsEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseSlottingUnitOfMeasureTierDetailsEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseSlottingUnitOfMeasureTierDetailsEntity";
            KeyPrefix = "commonDataModel.whswarehouseslottingunitofmeasuretierdetailsentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseSlottingUnitOfMeasureTierDetailsEntity";

            AddGroup("Common Data Model WHSWarehouseSlottingUnitOfMeasureTierDetailsEntity Details", group =>
            {
                UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SlotUOMTier = group.Add(new VocabularyKey(nameof(SlotUOMTier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseSlottingUnitTierId = group.Add(new VocabularyKey(nameof(WarehouseSlottingUnitTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey UnitSymbol { get; private set; }
public VocabularyKey SlotUOMTier { get; private set; }
public VocabularyKey WarehouseSlottingUnitTierId { get; private set; }


    }
}