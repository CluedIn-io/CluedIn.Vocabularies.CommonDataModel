using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventTransferOrderCFOPMappingEntityVocabulary : SimpleVocabulary
    {
        public InventTransferOrderCFOPMappingEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventTransferOrderCFOPMappingEntity";
            KeyPrefix = "commonDataModel.inventtransferordercfopmappingentity";
            KeySeparator = ".";
            Grouping = "/InventTransferOrderCFOPMappingEntity";

            AddGroup("Common Data Model InventTransferOrderCFOPMappingEntity Details", group =>
            {
                ShipmentCFOPRecId = group.Add(new VocabularyKey(nameof(ShipmentCFOPRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptCFOPRecId = group.Add(new VocabularyKey(nameof(ReceiptCFOPRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShipmentCFOP = group.Add(new VocabularyKey(nameof(ShipmentCFOP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiveCFOP = group.Add(new VocabularyKey(nameof(ReceiveCFOP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ShipmentCFOPRecId { get; private set; }
public VocabularyKey ReceiptCFOPRecId { get; private set; }
public VocabularyKey ShipmentCFOP { get; private set; }
public VocabularyKey ReceiveCFOP { get; private set; }


    }
}