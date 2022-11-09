using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseClusterProfileV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseClusterProfileV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseClusterProfileV2Entity";
            KeyPrefix = "commonDataModel.whswarehouseclusterprofilev2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseClusterProfileV2Entity";

            AddGroup("Common Data Model WHSWarehouseClusterProfileV2Entity Details", group =>
            {
                ClusterBreakingAction = group.Add(new VocabularyKey(nameof(ClusterBreakingAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClusterPositionCount = group.Add(new VocabularyKey(nameof(ClusterPositionCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClusterPositionNameType = group.Add(new VocabularyKey(nameof(ClusterPositionNameType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillClusterPickingGeneratePositionNames = group.Add(new VocabularyKey(nameof(WillClusterPickingGeneratePositionNames), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClusterProfileId = group.Add(new VocabularyKey(nameof(ClusterProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClusterProfileName = group.Add(new VocabularyKey(nameof(ClusterProfileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClusterSortingVerificationType = group.Add(new VocabularyKey(nameof(ClusterSortingVerificationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillClusterPickingRegisterClusterId = group.Add(new VocabularyKey(nameof(WillClusterPickingRegisterClusterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClusterType = group.Add(new VocabularyKey(nameof(ClusterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PutawayClusterAssignmentRule = group.Add(new VocabularyKey(nameof(PutawayClusterAssignmentRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PutawayClusterAssignmentTiming = group.Add(new VocabularyKey(nameof(PutawayClusterAssignmentTiming), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PutawayClusterLocateRule = group.Add(new VocabularyKey(nameof(PutawayClusterLocateRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPutawayClusterAssignedPerUser = group.Add(new VocabularyKey(nameof(IsPutawayClusterAssignedPerUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsClusterIdPersistedAsParentLicensePlateNumber = group.Add(new VocabularyKey(nameof(IsClusterIdPersistedAsParentLicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PutawayRestrictingUnitSymbol = group.Add(new VocabularyKey(nameof(PutawayRestrictingUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PutawayWorkUnitBreakRule = group.Add(new VocabularyKey(nameof(PutawayWorkUnitBreakRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfileSequenceNumber = group.Add(new VocabularyKey(nameof(ProfileSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseLocationDirectiveCode = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfileQuery = group.Add(new VocabularyKey(nameof(ProfileQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ClusterBreakingAction { get; private set; }
public VocabularyKey ClusterPositionCount { get; private set; }
public VocabularyKey ClusterPositionNameType { get; private set; }
public VocabularyKey WillClusterPickingGeneratePositionNames { get; private set; }
public VocabularyKey ClusterProfileId { get; private set; }
public VocabularyKey ClusterProfileName { get; private set; }
public VocabularyKey ClusterSortingVerificationType { get; private set; }
public VocabularyKey WillClusterPickingRegisterClusterId { get; private set; }
public VocabularyKey ClusterType { get; private set; }
public VocabularyKey PutawayClusterAssignmentRule { get; private set; }
public VocabularyKey PutawayClusterAssignmentTiming { get; private set; }
public VocabularyKey PutawayClusterLocateRule { get; private set; }
public VocabularyKey IsPutawayClusterAssignedPerUser { get; private set; }
public VocabularyKey IsClusterIdPersistedAsParentLicensePlateNumber { get; private set; }
public VocabularyKey PutawayRestrictingUnitSymbol { get; private set; }
public VocabularyKey PutawayWorkUnitBreakRule { get; private set; }
public VocabularyKey ProfileSequenceNumber { get; private set; }
public VocabularyKey WarehouseLocationDirectiveCode { get; private set; }
public VocabularyKey ProfileQuery { get; private set; }


    }
}