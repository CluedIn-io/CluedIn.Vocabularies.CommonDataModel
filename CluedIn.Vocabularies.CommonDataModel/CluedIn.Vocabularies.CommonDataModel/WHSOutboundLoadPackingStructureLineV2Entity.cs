using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSOutboundLoadPackingStructureLineV2EntityVocabulary : SimpleVocabulary
    {
        public WHSOutboundLoadPackingStructureLineV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSOutboundLoadPackingStructureLineV2Entity";
            KeyPrefix = "commonDataModel.whsoutboundloadpackingstructurelinev2entity";
            KeySeparator = ".";
            Grouping = "/WHSOutboundLoadPackingStructureLineV2Entity";

            AddGroup("Common Data Model WHSOutboundLoadPackingStructureLineV2Entity Details", group =>
            {
                OutboundShipmentId = group.Add(new VocabularyKey(nameof(OutboundShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingStructureLicensePlateNumber = group.Add(new VocabularyKey(nameof(PackingStructureLicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CapturedWeight = group.Add(new VocabularyKey(nameof(CapturedWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchExpirationDate = group.Add(new VocabularyKey(nameof(ItemBatchExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey OutboundShipmentId { get; private set; }
public VocabularyKey PackingStructureLicensePlateNumber { get; private set; }
public VocabularyKey LineDescription { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey CapturedWeight { get; private set; }
public VocabularyKey UnitSymbol { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey ItemBatchExpirationDate { get; private set; }
public VocabularyKey ItemSerialNumber { get; private set; }


    }
}