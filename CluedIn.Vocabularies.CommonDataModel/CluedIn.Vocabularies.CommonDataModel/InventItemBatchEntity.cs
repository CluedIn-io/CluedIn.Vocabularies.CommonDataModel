using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventItemBatchEntityVocabulary : SimpleVocabulary
    {
        public InventItemBatchEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventItemBatchEntity";
            KeyPrefix = "commonDataModel.inventitembatchentity";
            KeySeparator = ".";
            Grouping = "/InventItemBatchEntity";

            AddGroup("Common Data Model InventItemBatchEntity Details", group =>
            {
                BatchDescription = group.Add(new VocabularyKey(nameof(BatchDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BatchExpirationDate = group.Add(new VocabularyKey(nameof(BatchExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BatchNumber = group.Add(new VocabularyKey(nameof(BatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BestBeforeDate = group.Add(new VocabularyKey(nameof(BestBeforeDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryVendorOriginCountryRegionId = group.Add(new VocabularyKey(nameof(PrimaryVendorOriginCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SecondaryVendorOriginCountryRegionId = group.Add(new VocabularyKey(nameof(SecondaryVendorOriginCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BatchDispositionCode = group.Add(new VocabularyKey(nameof(BatchDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MostRecentTestDate = group.Add(new VocabularyKey(nameof(MostRecentTestDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreBatchAttributesInherited = group.Add(new VocabularyKey(nameof(AreBatchAttributesInherited), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreShelfLifeDatesInherited = group.Add(new VocabularyKey(nameof(AreShelfLifeDatesInherited), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBatchConsolidated = group.Add(new VocabularyKey(nameof(IsBatchConsolidated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShelfLifeAdviceDate = group.Add(new VocabularyKey(nameof(ShelfLifeAdviceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsManufacturingDateVendorBatchDate = group.Add(new VocabularyKey(nameof(IsManufacturingDateVendorBatchDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsExpirationDateVendorExpirationDate = group.Add(new VocabularyKey(nameof(IsExpirationDateVendorExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorBatchDate = group.Add(new VocabularyKey(nameof(VendorBatchDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorBatchNumber = group.Add(new VocabularyKey(nameof(VendorBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorExpirationDate = group.Add(new VocabularyKey(nameof(VendorExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ManufacturingDate = group.Add(new VocabularyKey(nameof(ManufacturingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BatchDescription { get; private set; }
public VocabularyKey BatchExpirationDate { get; private set; }
public VocabularyKey BatchNumber { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey BestBeforeDate { get; private set; }
public VocabularyKey PrimaryVendorOriginCountryRegionId { get; private set; }
public VocabularyKey SecondaryVendorOriginCountryRegionId { get; private set; }
public VocabularyKey BatchDispositionCode { get; private set; }
public VocabularyKey MostRecentTestDate { get; private set; }
public VocabularyKey AreBatchAttributesInherited { get; private set; }
public VocabularyKey AreShelfLifeDatesInherited { get; private set; }
public VocabularyKey IsBatchConsolidated { get; private set; }
public VocabularyKey ShelfLifeAdviceDate { get; private set; }
public VocabularyKey IsManufacturingDateVendorBatchDate { get; private set; }
public VocabularyKey IsExpirationDateVendorExpirationDate { get; private set; }
public VocabularyKey VendorBatchDate { get; private set; }
public VocabularyKey VendorBatchNumber { get; private set; }
public VocabularyKey VendorExpirationDate { get; private set; }
public VocabularyKey ManufacturingDate { get; private set; }


    }
}