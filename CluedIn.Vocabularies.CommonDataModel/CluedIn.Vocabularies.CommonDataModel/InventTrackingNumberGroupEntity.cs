using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventTrackingNumberGroupEntityVocabulary : SimpleVocabulary
    {
        public InventTrackingNumberGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventTrackingNumberGroupEntity";
            KeyPrefix = "commonDataModel.inventtrackingnumbergroupentity";
            KeySeparator = ".";
            Grouping = "/InventTrackingNumberGroupEntity";

            AddGroup("Common Data Model InventTrackingNumberGroupEntity Details", group =>
            {
                IsExpectedDateIncluded = group.Add(new VocabularyKey(nameof(IsExpectedDateIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLotIdIncluded = group.Add(new VocabularyKey(nameof(IsLotIdIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsNumberSequenceNumberIncluded = group.Add(new VocabularyKey(nameof(IsNumberSequenceNumberIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReferenceNumberIncluded = group.Add(new VocabularyKey(nameof(IsReferenceNumberIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivatedForInventory = group.Add(new VocabularyKey(nameof(IsActivatedForInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivatedForKanban = group.Add(new VocabularyKey(nameof(IsActivatedForKanban), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsNumberManuallyAllocated = group.Add(new VocabularyKey(nameof(IsNumberManuallyAllocated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceRecId = group.Add(new VocabularyKey(nameof(NumberSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOnlyForInventoryTransactions = group.Add(new VocabularyKey(nameof(IsOnlyForInventoryTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryQuantityTreshold = group.Add(new VocabularyKey(nameof(InventoryQuantityTreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillPhysicalUpdateAssignNumber = group.Add(new VocabularyKey(nameof(WillPhysicalUpdateAssignNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivatedForProduction = group.Add(new VocabularyKey(nameof(IsActivatedForProduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivatedForPurchase = group.Add(new VocabularyKey(nameof(IsActivatedForPurchase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivatedForSales = group.Add(new VocabularyKey(nameof(IsActivatedForSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceTable_NumberSequenceScope = group.Add(new VocabularyKey(nameof(NumberSequenceTable_NumberSequenceScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceScopeDataArea = group.Add(new VocabularyKey(nameof(NumberSequenceScopeDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsExpectedDateIncluded { get; private set; }
public VocabularyKey IsLotIdIncluded { get; private set; }
public VocabularyKey IsNumberSequenceNumberIncluded { get; private set; }
public VocabularyKey IsReferenceNumberIncluded { get; private set; }
public VocabularyKey IsActivatedForInventory { get; private set; }
public VocabularyKey IsActivatedForKanban { get; private set; }
public VocabularyKey IsNumberManuallyAllocated { get; private set; }
public VocabularyKey GroupName { get; private set; }
public VocabularyKey NumberSequenceRecId { get; private set; }
public VocabularyKey GroupCode { get; private set; }
public VocabularyKey IsOnlyForInventoryTransactions { get; private set; }
public VocabularyKey InventoryQuantityTreshold { get; private set; }
public VocabularyKey WillPhysicalUpdateAssignNumber { get; private set; }
public VocabularyKey IsActivatedForProduction { get; private set; }
public VocabularyKey IsActivatedForPurchase { get; private set; }
public VocabularyKey IsActivatedForSales { get; private set; }
public VocabularyKey NumberSequenceCode { get; private set; }
public VocabularyKey NumberSequenceTable_NumberSequenceScope { get; private set; }
public VocabularyKey NumberSequenceScopeDataArea { get; private set; }


    }
}