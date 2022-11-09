using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSInventoryReservationHierarchyLevelEntityVocabulary : SimpleVocabulary
    {
        public WHSInventoryReservationHierarchyLevelEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSInventoryReservationHierarchyLevelEntity";
            KeyPrefix = "commonDataModel.whsinventoryreservationhierarchylevelentity";
            KeySeparator = ".";
            Grouping = "/WHSInventoryReservationHierarchyLevelEntity";

            AddGroup("Common Data Model WHSInventoryReservationHierarchyLevelEntity Details", group =>
            {
                InventoryDimensionFieldId = group.Add(new VocabularyKey(nameof(InventoryDimensionFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryDimensionFieldName = group.Add(new VocabularyKey(nameof(InventoryDimensionFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryReservationHierarchyRefRecId = group.Add(new VocabularyKey(nameof(InventoryReservationHierarchyRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryReservationHierarchyLevel = group.Add(new VocabularyKey(nameof(InventoryReservationHierarchyLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryReservationHierarchyName = group.Add(new VocabularyKey(nameof(InventoryReservationHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandOrderReservationPolicy = group.Add(new VocabularyKey(nameof(DemandOrderReservationPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InventoryDimensionFieldId { get; private set; }
public VocabularyKey InventoryDimensionFieldName { get; private set; }
public VocabularyKey InventoryReservationHierarchyRefRecId { get; private set; }
public VocabularyKey InventoryReservationHierarchyLevel { get; private set; }
public VocabularyKey InventoryReservationHierarchyName { get; private set; }
public VocabularyKey DemandOrderReservationPolicy { get; private set; }


    }
}