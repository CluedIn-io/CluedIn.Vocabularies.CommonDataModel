using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CAMAggregatedCostEntryWithDefaultCostObjectHierarchyEntityVocabulary : SimpleVocabulary
    {
        public CAMAggregatedCostEntryWithDefaultCostObjectHierarchyEntityVocabulary()
        {
            VocabularyName = "Common Data Model CAMAggregatedCostEntryWithDefaultCostObjectHierarchyEntity";
            KeyPrefix = "commonDataModel.camaggregatedcostentrywithdefaultcostobjecthierarchyentity";
            KeySeparator = ".";
            Grouping = "/CAMAggregatedCostEntryWithDefaultCostObjectHierarchyEntity";

            AddGroup("Common Data Model CAMAggregatedCostEntryWithDefaultCostObjectHierarchyEntity Details", group =>
            {
                CostAccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(CostAccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostAccountingDate = group.Add(new VocabularyKey(nameof(CostAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostAccountingLedgerName = group.Add(new VocabularyKey(nameof(CostAccountingLedgerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostControlUnitName = group.Add(new VocabularyKey(nameof(CostControlUnitName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostBehavior = group.Add(new VocabularyKey(nameof(CostBehavior), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel1 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel10 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel11 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel12 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel12), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel13 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel13), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel14 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel14), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel15 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel15), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel2 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel3 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel4 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel5 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel6 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel7 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel8 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyLevel9 = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyLevel9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionMemberName = group.Add(new VocabularyKey(nameof(CostElementDimensionMemberName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionMemberDescription = group.Add(new VocabularyKey(nameof(CostElementDimensionMemberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel1 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel10 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel11 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel12 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel12), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel13 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel13), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel14 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel14), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel15 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel15), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel2 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel3 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel4 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel5 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel6 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel7 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel8 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionHierarchyLevel9 = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyLevel9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionMemberName = group.Add(new VocabularyKey(nameof(CostObjectDimensionMemberName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostObjectDimensionMemberDescription = group.Add(new VocabularyKey(nameof(CostObjectDimensionMemberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Month = group.Add(new VocabularyKey(nameof(Month), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodName = group.Add(new VocabularyKey(nameof(PeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodOffset = group.Add(new VocabularyKey(nameof(PeriodOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quarter = group.Add(new VocabularyKey(nameof(Quarter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuarterOffset = group.Add(new VocabularyKey(nameof(QuarterOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
YearOffset = group.Add(new VocabularyKey(nameof(YearOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
YearName = group.Add(new VocabularyKey(nameof(YearName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostElementDimensionHierarchyName = group.Add(new VocabularyKey(nameof(CostElementDimensionHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VersionIdentificationName = group.Add(new VocabularyKey(nameof(VersionIdentificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceVersionIdentificationName = group.Add(new VocabularyKey(nameof(SourceVersionIdentificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VersionType = group.Add(new VocabularyKey(nameof(VersionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CostAccountingCurrencyAmount { get; private set; }
public VocabularyKey CostAccountingDate { get; private set; }
public VocabularyKey CostAccountingLedgerName { get; private set; }
public VocabularyKey CostControlUnitName { get; private set; }
public VocabularyKey CostBehavior { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel1 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel10 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel11 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel12 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel13 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel14 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel15 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel2 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel3 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel4 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel5 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel6 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel7 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel8 { get; private set; }
public VocabularyKey CostElementDimensionHierarchyLevel9 { get; private set; }
public VocabularyKey CostElementDimensionMemberName { get; private set; }
public VocabularyKey CostElementDimensionMemberDescription { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel1 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel10 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel11 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel12 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel13 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel14 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel15 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel2 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel3 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel4 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel5 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel6 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel7 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel8 { get; private set; }
public VocabularyKey CostObjectDimensionHierarchyLevel9 { get; private set; }
public VocabularyKey CostObjectDimensionMemberName { get; private set; }
public VocabularyKey CostObjectDimensionMemberDescription { get; private set; }
public VocabularyKey CalendarId { get; private set; }
public VocabularyKey Month { get; private set; }
public VocabularyKey PeriodName { get; private set; }
public VocabularyKey PeriodOffset { get; private set; }
public VocabularyKey Quarter { get; private set; }
public VocabularyKey QuarterOffset { get; private set; }
public VocabularyKey YearOffset { get; private set; }
public VocabularyKey YearName { get; private set; }
public VocabularyKey CostElementDimensionHierarchyName { get; private set; }
public VocabularyKey VersionIdentificationName { get; private set; }
public VocabularyKey SourceVersionIdentificationName { get; private set; }
public VocabularyKey VersionType { get; private set; }


    }
}