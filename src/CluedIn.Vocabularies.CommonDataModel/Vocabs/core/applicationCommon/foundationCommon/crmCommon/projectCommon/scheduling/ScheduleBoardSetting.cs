using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class ScheduleBoardSettingVocabulary : SimpleVocabulary
    {
        public ScheduleBoardSettingVocabulary()
        {
            VocabularyName = "Schedule Board Setting";
            KeyPrefix = "commonDataModel.scheduleboardsetting.scheduling";
            KeySeparator = ".";
            Grouping = "/ScheduleBoardSetting";

            AddGroup("ScheduleBoardSetting Details for Scheduling", group =>
            {
			    ScheduleBoardSettingId = group.Add(new VocabularyKey(nameof(ScheduleBoardSettingId), "Schedule Board Setting", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TabName = group.Add(new VocabularyKey(nameof(TabName), "Tab name.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookBasedOn = group.Add(new VocabularyKey(nameof(BookBasedOn), "Book Based On", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CustomTabName = group.Add(new VocabularyKey(nameof(CustomTabName), "Custom Tab Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomTabWebResource = group.Add(new VocabularyKey(nameof(CustomTabWebResource), "Custom Tab Web Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FilterValues = group.Add(new VocabularyKey(nameof(FilterValues), "Filter Values", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FullyBookedColor = group.Add(new VocabularyKey(nameof(FullyBookedColor), "Fully Booked Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HideCancelled = group.Add(new VocabularyKey(nameof(HideCancelled), "Hide Canceled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsPublic = group.Add(new VocabularyKey(nameof(IsPublic), "Is Public (Deprecated)", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsSynchronizeResources = group.Add(new VocabularyKey(nameof(IsSynchronizeResources), "Is Synchronize Resources", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MapViewTabPlacement = group.Add(new VocabularyKey(nameof(MapViewTabPlacement), "Map View Tab Placement", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    NotBookedColor = group.Add(new VocabularyKey(nameof(NotBookedColor), "Not Booked Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrderNumber = group.Add(new VocabularyKey(nameof(OrderNumber), "Order Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OrganizationalUnitTooltipsViewId = group.Add(new VocabularyKey(nameof(OrganizationalUnitTooltipsViewId), "Organizational Unit Tooltips View Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationalUnitViewId = group.Add(new VocabularyKey(nameof(OrganizationalUnitViewId), "Organizational Unit View Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverbookedColor = group.Add(new VocabularyKey(nameof(OverbookedColor), "Overbooked Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartiallyBookedColor = group.Add(new VocabularyKey(nameof(PartiallyBookedColor), "Partially Booked Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SAAvailableColor = group.Add(new VocabularyKey(nameof(SAAvailableColor), "SA Available Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SAAvailableIcon = group.Add(new VocabularyKey(nameof(SAAvailableIcon), "SA Available Icon", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SAAvailableIconDefault = group.Add(new VocabularyKey(nameof(SAAvailableIconDefault), "SA Available Icon Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SAPartiallyAvailableColor = group.Add(new VocabularyKey(nameof(SAPartiallyAvailableColor), "SA Partially Available Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SAPartiallyAvailableIcon = group.Add(new VocabularyKey(nameof(SAPartiallyAvailableIcon), "SA Partially Available Icon", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SAPartiallyAvailableIconDefault = group.Add(new VocabularyKey(nameof(SAPartiallyAvailableIconDefault), "SA Partially Available Icon Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SAUnavailableColor = group.Add(new VocabularyKey(nameof(SAUnavailableColor), "SA Unavailable Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SAUnavailableIcon = group.Add(new VocabularyKey(nameof(SAUnavailableIcon), "SA Unavailable Icon", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SAUnavailableIconDefault = group.Add(new VocabularyKey(nameof(SAUnavailableIconDefault), "SA Unavailable Icon Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SchedulerAlertsView = group.Add(new VocabularyKey(nameof(SchedulerAlertsView), "Scheduler Alerts View", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SchedulerResourceDetailsView = group.Add(new VocabularyKey(nameof(SchedulerResourceDetailsView), "Resource Details View", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SchedulerResourceTooltipView = group.Add(new VocabularyKey(nameof(SchedulerResourceTooltipView), "Resource Tooltips View", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Settings = group.Add(new VocabularyKey(nameof(Settings), "Settings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShareType = group.Add(new VocabularyKey(nameof(ShareType), "Share Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UnscheduledRequirementsViewId = group.Add(new VocabularyKey(nameof(UnscheduledRequirementsViewId), "Requirements View Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UnscheduledWOPageRecCount = group.Add(new VocabularyKey(nameof(UnscheduledWOPageRecCount), "Resource Requirement View Page Record Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WorkingHoursColor = group.Add(new VocabularyKey(nameof(WorkingHoursColor), "Working Hours Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ScheduleBoardSettingId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TabName { get; private set; }
        public VocabularyKey BookBasedOn { get; private set; }
        public VocabularyKey CustomTabName { get; private set; }
        public VocabularyKey CustomTabWebResource { get; private set; }
        public VocabularyKey FilterValues { get; private set; }
        public VocabularyKey FullyBookedColor { get; private set; }
        public VocabularyKey HideCancelled { get; private set; }
        public VocabularyKey IsPublic { get; private set; }
        public VocabularyKey IsSynchronizeResources { get; private set; }
        public VocabularyKey MapViewTabPlacement { get; private set; }
        public VocabularyKey NotBookedColor { get; private set; }
        public VocabularyKey OrderNumber { get; private set; }
        public VocabularyKey OrganizationalUnitTooltipsViewId { get; private set; }
        public VocabularyKey OrganizationalUnitViewId { get; private set; }
        public VocabularyKey OverbookedColor { get; private set; }
        public VocabularyKey PartiallyBookedColor { get; private set; }
        public VocabularyKey SAAvailableColor { get; private set; }
        public VocabularyKey SAAvailableIcon { get; private set; }
        public VocabularyKey SAAvailableIconDefault { get; private set; }
        public VocabularyKey SAPartiallyAvailableColor { get; private set; }
        public VocabularyKey SAPartiallyAvailableIcon { get; private set; }
        public VocabularyKey SAPartiallyAvailableIconDefault { get; private set; }
        public VocabularyKey SAUnavailableColor { get; private set; }
        public VocabularyKey SAUnavailableIcon { get; private set; }
        public VocabularyKey SAUnavailableIconDefault { get; private set; }
        public VocabularyKey SchedulerAlertsView { get; private set; }
        public VocabularyKey SchedulerResourceDetailsView { get; private set; }
        public VocabularyKey SchedulerResourceTooltipView { get; private set; }
        public VocabularyKey Settings { get; private set; }
        public VocabularyKey ShareType { get; private set; }
        public VocabularyKey UnscheduledRequirementsViewId { get; private set; }
        public VocabularyKey UnscheduledWOPageRecCount { get; private set; }
        public VocabularyKey WorkingHoursColor { get; private set; }
    }
}