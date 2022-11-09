using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSOutboundLoadPackingStructureEntityVocabulary : SimpleVocabulary
    {
        public WHSOutboundLoadPackingStructureEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSOutboundLoadPackingStructureEntity";
            KeyPrefix = "commonDataModel.whsoutboundloadpackingstructureentity";
            KeySeparator = ".";
            Grouping = "/WHSOutboundLoadPackingStructureEntity";

            AddGroup("Common Data Model WHSOutboundLoadPackingStructureEntity Details", group =>
            {
                ContainedItemNumber = group.Add(new VocabularyKey(nameof(ContainedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackedTotalQuantity = group.Add(new VocabularyKey(nameof(PackedTotalQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryUnitSymbol = group.Add(new VocabularyKey(nameof(InventoryUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveringUnitSymbol = group.Add(new VocabularyKey(nameof(DeliveringUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OutboundShipmentId = group.Add(new VocabularyKey(nameof(OutboundShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ContainedItemNumber { get; private set; }
public VocabularyKey LicensePlateNumber { get; private set; }
public VocabularyKey PackedTotalQuantity { get; private set; }
public VocabularyKey InventoryUnitSymbol { get; private set; }
public VocabularyKey DeliveringUnitSymbol { get; private set; }
public VocabularyKey OutboundShipmentId { get; private set; }


    }
}