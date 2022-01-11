using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeanProductLeanScheduleGroupAssignmentV2EntityVocabulary : SimpleVocabulary
    {
        public LeanProductLeanScheduleGroupAssignmentV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model LeanProductLeanScheduleGroupAssignmentV2Entity";
            KeyPrefix = "commonDataModel.leanproductleanschedulegroupassignmentv2entity";
            KeySeparator = ".";
            Grouping = "/LeanProductLeanScheduleGroupAssignmentV2Entity";

            AddGroup("Common Data Model LeanProductLeanScheduleGroupAssignmentV2Entity Details", group =>
            {
                LeanScheduleGroup = group.Add(new VocabularyKey(nameof(LeanScheduleGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LeanScheduleGroupId = group.Add(new VocabularyKey(nameof(LeanScheduleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkCellOperationsResourceGroup = group.Add(new VocabularyKey(nameof(WorkCellOperationsResourceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NullableWorkCellOperationsResourceGroupId = group.Add(new VocabularyKey(nameof(NullableWorkCellOperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkCellOperationsResourceGroupId = group.Add(new VocabularyKey(nameof(WorkCellOperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ThroughputRatio = group.Add(new VocabularyKey(nameof(ThroughputRatio), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LeanScheduleGroup { get; private set; }
public VocabularyKey LeanScheduleGroupId { get; private set; }
public VocabularyKey WorkCellOperationsResourceGroup { get; private set; }
public VocabularyKey NullableWorkCellOperationsResourceGroupId { get; private set; }
public VocabularyKey WorkCellOperationsResourceGroupId { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey ThroughputRatio { get; private set; }


    }
}