using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkExceptionEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkExceptionEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkExceptionEntity";
            KeyPrefix = "commonDataModel.whswarehouseworkexceptionentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkExceptionEntity";

            AddGroup("Common Data Model WHSWarehouseWorkExceptionEntity Details", group =>
            {
                WillExceptionAdjustInventory = group.Add(new VocabularyKey(nameof(WillExceptionAdjustInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillExceptionCreateCycleCounting = group.Add(new VocabularyKey(nameof(WillExceptionCreateCycleCounting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillExceptionDecrementShipmentOrLoad = group.Add(new VocabularyKey(nameof(WillExceptionDecrementShipmentOrLoad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemReallocationMethod = group.Add(new VocabularyKey(nameof(ItemReallocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultInventoryAdjustmentTypeId = group.Add(new VocabularyKey(nameof(DefaultInventoryAdjustmentTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExceptionType = group.Add(new VocabularyKey(nameof(ExceptionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExceptionCode = group.Add(new VocabularyKey(nameof(ExceptionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExceptionDescription = group.Add(new VocabularyKey(nameof(ExceptionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaveLabelReprint = group.Add(new VocabularyKey(nameof(WaveLabelReprint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WillExceptionAdjustInventory { get; private set; }
public VocabularyKey WillExceptionCreateCycleCounting { get; private set; }
public VocabularyKey WillExceptionDecrementShipmentOrLoad { get; private set; }
public VocabularyKey ItemReallocationMethod { get; private set; }
public VocabularyKey DefaultInventoryAdjustmentTypeId { get; private set; }
public VocabularyKey ExceptionType { get; private set; }
public VocabularyKey ExceptionCode { get; private set; }
public VocabularyKey ExceptionDescription { get; private set; }
public VocabularyKey WaveLabelReprint { get; private set; }


    }
}