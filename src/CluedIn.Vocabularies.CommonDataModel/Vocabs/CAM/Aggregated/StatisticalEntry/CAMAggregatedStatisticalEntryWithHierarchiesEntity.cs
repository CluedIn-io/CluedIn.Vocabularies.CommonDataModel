using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CAMAggregatedStatisticalEntryWithHierarchiesEntityVocabulary : SimpleVocabulary
    {
        public CAMAggregatedStatisticalEntryWithHierarchiesEntityVocabulary()
        {
            VocabularyName = "CAM Aggregated Statistical Entry With Hierarchies Entity";
            KeyPrefix = "commonDataModel.camaggregatedstatisticalentrywithhierarchiesentity";
            KeySeparator = ".";
            Grouping = "/CAMAggregatedStatisticalEntryWithHierarchiesEntity";

            AddGroup("CAMAggregatedStatisticalEntryWithHierarchiesEntity Details", group =>
            {
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
                CostControlUnitName = group.Add(new VocabularyKey(nameof(CostControlUnitName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAccountingLedgerName = group.Add(new VocabularyKey(nameof(CostAccountingLedgerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAccountingDate = group.Add(new VocabularyKey(nameof(CostAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel1 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel10 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel11 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel12 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel12), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel13 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel13), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel14 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel14), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel15 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel15), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel2 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel3 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel4 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel5 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel7 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel6 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel8 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyLevel9 = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyLevel9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionMemberDescription = group.Add(new VocabularyKey(nameof(StatisticalDimensionMemberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Magnitude = group.Add(new VocabularyKey(nameof(Magnitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionIdentificationName = group.Add(new VocabularyKey(nameof(VersionIdentificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceVersionIdentificationName = group.Add(new VocabularyKey(nameof(SourceVersionIdentificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionType = group.Add(new VocabularyKey(nameof(VersionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearName = group.Add(new VocabularyKey(nameof(YearName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Month = group.Add(new VocabularyKey(nameof(Month), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodName = group.Add(new VocabularyKey(nameof(PeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodOffset = group.Add(new VocabularyKey(nameof(PeriodOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quarter = group.Add(new VocabularyKey(nameof(Quarter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuarterOffset = group.Add(new VocabularyKey(nameof(QuarterOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearOffset = group.Add(new VocabularyKey(nameof(YearOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostObjectDimensionMemberName = group.Add(new VocabularyKey(nameof(CostObjectDimensionMemberName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostObjectDimensionMemberDescription = group.Add(new VocabularyKey(nameof(CostObjectDimensionMemberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionMemberName = group.Add(new VocabularyKey(nameof(StatisticalDimensionMemberName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalDimensionHierarchyName = group.Add(new VocabularyKey(nameof(StatisticalDimensionHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostObjectDimensionHierarchyName = group.Add(new VocabularyKey(nameof(CostObjectDimensionHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
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
        public VocabularyKey CostControlUnitName { get; private set; }
        public VocabularyKey CostAccountingLedgerName { get; private set; }
        public VocabularyKey CostAccountingDate { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel1 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel10 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel11 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel12 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel13 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel14 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel15 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel2 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel3 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel4 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel5 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel7 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel6 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel8 { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyLevel9 { get; private set; }
        public VocabularyKey StatisticalDimensionMemberDescription { get; private set; }
        public VocabularyKey Magnitude { get; private set; }
        public VocabularyKey VersionIdentificationName { get; private set; }
        public VocabularyKey SourceVersionIdentificationName { get; private set; }
        public VocabularyKey VersionType { get; private set; }
        public VocabularyKey YearName { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey Month { get; private set; }
        public VocabularyKey PeriodName { get; private set; }
        public VocabularyKey PeriodOffset { get; private set; }
        public VocabularyKey Quarter { get; private set; }
        public VocabularyKey QuarterOffset { get; private set; }
        public VocabularyKey YearOffset { get; private set; }
        public VocabularyKey CostObjectDimensionMemberName { get; private set; }
        public VocabularyKey CostObjectDimensionMemberDescription { get; private set; }
        public VocabularyKey StatisticalDimensionMemberName { get; private set; }
        public VocabularyKey StatisticalDimensionHierarchyName { get; private set; }
        public VocabularyKey CostObjectDimensionHierarchyName { get; private set; }
    }
}