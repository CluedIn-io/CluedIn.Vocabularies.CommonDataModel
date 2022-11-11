using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRReqPlanContinuityEntityVocabulary : SimpleVocabulary
    {
        public MCRReqPlanContinuityEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRReqPlanContinuityEntity";
            KeyPrefix = "commonDataModel.mcrreqplancontinuityentity";
            KeySeparator = ".";
            Grouping = "/MCRReqPlanContinuityEntity";

            AddGroup("Common Data Model MCRReqPlanContinuityEntity Details", group =>
            {
                IssueMargin = group.Add(new VocabularyKey(nameof(IssueMargin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderingMargin = group.Add(new VocabularyKey(nameof(OrderingMargin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderSequenceRecId = group.Add(new VocabularyKey(nameof(PlannedOrderSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptMargin = group.Add(new VocabularyKey(nameof(ReceiptMargin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredPlanIdContinuity = group.Add(new VocabularyKey(nameof(RequiredPlanIdContinuity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredPlanSequenceRecId = group.Add(new VocabularyKey(nameof(RequiredPlanSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipCoverageCalculations = group.Add(new VocabularyKey(nameof(SkipCoverageCalculations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeFenceCapacity = group.Add(new VocabularyKey(nameof(TimeFenceCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeFenceCoverage = group.Add(new VocabularyKey(nameof(TimeFenceCoverage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeFenceExplosion = group.Add(new VocabularyKey(nameof(TimeFenceExplosion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseProbabalisticContinuity = group.Add(new VocabularyKey(nameof(UseProbabalisticContinuity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderNumberSequence = group.Add(new VocabularyKey(nameof(PlannedOrderNumberSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderTableNumberSequenceScope = group.Add(new VocabularyKey(nameof(PlannedOrderTableNumberSequenceScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderScopeDataArea = group.Add(new VocabularyKey(nameof(PlannedOrderScopeDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderScopeFiscalCalendarPeriod = group.Add(new VocabularyKey(nameof(PlannedOrderScopeFiscalCalendarPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderScopeLegalEntity = group.Add(new VocabularyKey(nameof(PlannedOrderScopeLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderScopeOperatingUnit = group.Add(new VocabularyKey(nameof(PlannedOrderScopeOperatingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderScopeOperatingUnitType = group.Add(new VocabularyKey(nameof(PlannedOrderScopeOperatingUnitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderPeriodFiscalCalendarYear = group.Add(new VocabularyKey(nameof(PlannedOrderPeriodFiscalCalendarYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderPeriodName = group.Add(new VocabularyKey(nameof(PlannedOrderPeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderYearFiscalCalendar = group.Add(new VocabularyKey(nameof(PlannedOrderYearFiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderYearName = group.Add(new VocabularyKey(nameof(PlannedOrderYearName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderCalendarId = group.Add(new VocabularyKey(nameof(PlannedOrderCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderCompanyInfoPartyNumber = group.Add(new VocabularyKey(nameof(PlannedOrderCompanyInfoPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderCompanyInfoDataArea = group.Add(new VocabularyKey(nameof(PlannedOrderCompanyInfoDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderOMOperatingUnitPartyNumber = group.Add(new VocabularyKey(nameof(PlannedOrderOMOperatingUnitPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogNumberSequence = group.Add(new VocabularyKey(nameof(RequiredLogNumberSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogNumberSequenceScope = group.Add(new VocabularyKey(nameof(RequiredLogNumberSequenceScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogDataArea = group.Add(new VocabularyKey(nameof(RequiredLogDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogFiscalCalendarPeriod = group.Add(new VocabularyKey(nameof(RequiredLogFiscalCalendarPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogLegalEntity = group.Add(new VocabularyKey(nameof(RequiredLogLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogOperatingUnit = group.Add(new VocabularyKey(nameof(RequiredLogOperatingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogOperatingUnitType = group.Add(new VocabularyKey(nameof(RequiredLogOperatingUnitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogPeriodFiscalCalendarYear = group.Add(new VocabularyKey(nameof(RequiredLogPeriodFiscalCalendarYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogPeriodName = group.Add(new VocabularyKey(nameof(RequiredLogPeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogYearFiscalCalendar = group.Add(new VocabularyKey(nameof(RequiredLogYearFiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogYearName = group.Add(new VocabularyKey(nameof(RequiredLogYearName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogCalendarId = group.Add(new VocabularyKey(nameof(RequiredLogCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogCompanyInfoPartyNumber = group.Add(new VocabularyKey(nameof(RequiredLogCompanyInfoPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogCompanyInfoDataArea = group.Add(new VocabularyKey(nameof(RequiredLogCompanyInfoDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredLogOMOperatingUnitPartyNumber = group.Add(new VocabularyKey(nameof(RequiredLogOMOperatingUnitPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IssueMargin { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OrderingMargin { get; private set; }
        public VocabularyKey PlannedOrderSequenceRecId { get; private set; }
        public VocabularyKey ReceiptMargin { get; private set; }
        public VocabularyKey RequiredPlanIdContinuity { get; private set; }
        public VocabularyKey RequiredPlanSequenceRecId { get; private set; }
        public VocabularyKey SkipCoverageCalculations { get; private set; }
        public VocabularyKey TimeFenceCapacity { get; private set; }
        public VocabularyKey TimeFenceCoverage { get; private set; }
        public VocabularyKey TimeFenceExplosion { get; private set; }
        public VocabularyKey UseProbabalisticContinuity { get; private set; }
        public VocabularyKey PlannedOrderNumberSequence { get; private set; }
        public VocabularyKey PlannedOrderTableNumberSequenceScope { get; private set; }
        public VocabularyKey PlannedOrderScopeDataArea { get; private set; }
        public VocabularyKey PlannedOrderScopeFiscalCalendarPeriod { get; private set; }
        public VocabularyKey PlannedOrderScopeLegalEntity { get; private set; }
        public VocabularyKey PlannedOrderScopeOperatingUnit { get; private set; }
        public VocabularyKey PlannedOrderScopeOperatingUnitType { get; private set; }
        public VocabularyKey PlannedOrderPeriodFiscalCalendarYear { get; private set; }
        public VocabularyKey PlannedOrderPeriodName { get; private set; }
        public VocabularyKey PlannedOrderYearFiscalCalendar { get; private set; }
        public VocabularyKey PlannedOrderYearName { get; private set; }
        public VocabularyKey PlannedOrderCalendarId { get; private set; }
        public VocabularyKey PlannedOrderCompanyInfoPartyNumber { get; private set; }
        public VocabularyKey PlannedOrderCompanyInfoDataArea { get; private set; }
        public VocabularyKey PlannedOrderOMOperatingUnitPartyNumber { get; private set; }
        public VocabularyKey RequiredLogNumberSequence { get; private set; }
        public VocabularyKey RequiredLogNumberSequenceScope { get; private set; }
        public VocabularyKey RequiredLogDataArea { get; private set; }
        public VocabularyKey RequiredLogFiscalCalendarPeriod { get; private set; }
        public VocabularyKey RequiredLogLegalEntity { get; private set; }
        public VocabularyKey RequiredLogOperatingUnit { get; private set; }
        public VocabularyKey RequiredLogOperatingUnitType { get; private set; }
        public VocabularyKey RequiredLogPeriodFiscalCalendarYear { get; private set; }
        public VocabularyKey RequiredLogPeriodName { get; private set; }
        public VocabularyKey RequiredLogYearFiscalCalendar { get; private set; }
        public VocabularyKey RequiredLogYearName { get; private set; }
        public VocabularyKey RequiredLogCalendarId { get; private set; }
        public VocabularyKey RequiredLogCompanyInfoPartyNumber { get; private set; }
        public VocabularyKey RequiredLogCompanyInfoDataArea { get; private set; }
        public VocabularyKey RequiredLogOMOperatingUnitPartyNumber { get; private set; }


    }
}