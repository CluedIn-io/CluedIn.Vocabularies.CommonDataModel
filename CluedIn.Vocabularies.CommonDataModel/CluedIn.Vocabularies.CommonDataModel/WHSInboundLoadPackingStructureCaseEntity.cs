using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSInboundLoadPackingStructureCaseEntityVocabulary : SimpleVocabulary
    {
        public WHSInboundLoadPackingStructureCaseEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSInboundLoadPackingStructureCaseEntity";
            KeyPrefix = "commonDataModel.whsinboundloadpackingstructurecaseentity";
            KeySeparator = ".";
            Grouping = "/WHSInboundLoadPackingStructureCaseEntity";

            AddGroup("Common Data Model WHSInboundLoadPackingStructureCaseEntity Details", group =>
            {
                ContainedItemNumber = group.Add(new VocabularyKey(nameof(ContainedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentPackingStructureLicensePlateNumber = group.Add(new VocabularyKey(nameof(ParentPackingStructureLicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackedTotalQuantity = group.Add(new VocabularyKey(nameof(PackedTotalQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryUnitSymbol = group.Add(new VocabularyKey(nameof(InventoryUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingUnitSymbol = group.Add(new VocabularyKey(nameof(ReceivingUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InboundShipmentId = group.Add(new VocabularyKey(nameof(InboundShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ContainedItemNumber { get; private set; }
public VocabularyKey LicensePlateNumber { get; private set; }
public VocabularyKey ParentPackingStructureLicensePlateNumber { get; private set; }
public VocabularyKey PackedTotalQuantity { get; private set; }
public VocabularyKey InventoryUnitSymbol { get; private set; }
public VocabularyKey ReceivingUnitSymbol { get; private set; }
public VocabularyKey InboundShipmentId { get; private set; }


    }
}