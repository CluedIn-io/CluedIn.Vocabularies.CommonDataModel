using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ResourceRequirementVocabulary : SimpleVocabulary
    {
        public ResourceRequirementVocabulary()
        {
            VocabularyName = "Resource Requirement";
            KeyPrefix = "commonDataModel.resourcerequirement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ResourceRequirement;

            AddGroup("ResourceRequirement Details for Scheduling", group =>
            {
			    ResourceRequirementId = group.Add(new VocabularyKey(nameof(ResourceRequirementId), "Resource Requirement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllocationMethod = group.Add(new VocabularyKey(nameof(AllocationMethod), "Allocation Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), "Calendar Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Effort = group.Add(new VocabularyKey(nameof(Effort), "Effort", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    FromDate = group.Add(new VocabularyKey(nameof(FromDate), "From Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FulfilledDuration = group.Add(new VocabularyKey(nameof(FulfilledDuration), "Fulfilled Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    InternalFlags = group.Add(new VocabularyKey(nameof(InternalFlags), "Internal Flags", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), "Is Primary", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsTemplate = group.Add(new VocabularyKey(nameof(IsTemplate), "Is Template", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Latitude = group.Add(new VocabularyKey(nameof(Latitude), "Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Longitude = group.Add(new VocabularyKey(nameof(Longitude), "Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Percentage = group.Add(new VocabularyKey(nameof(Percentage), "Percentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PoolType = group.Add(new VocabularyKey(nameof(PoolType), "Pool Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProposedDuration = group.Add(new VocabularyKey(nameof(ProposedDuration), "Proposed Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RemainingDuration = group.Add(new VocabularyKey(nameof(RemainingDuration), "Remaining Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RequirementGroupControlViewId = group.Add(new VocabularyKey(nameof(RequirementGroupControlViewId), "Requirement Group Control View Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResourceType = group.Add(new VocabularyKey(nameof(ResourceType), "Resource Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SortOptions = group.Add(new VocabularyKey(nameof(SortOptions), "Sort Options", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TemplateRequirementId = group.Add(new VocabularyKey(nameof(TemplateRequirementId), "Template Requirement Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeFromPromised = group.Add(new VocabularyKey(nameof(TimeFromPromised), "Time From Promised", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeToPromised = group.Add(new VocabularyKey(nameof(TimeToPromised), "Time To Promised", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeWindowEnd = group.Add(new VocabularyKey(nameof(TimeWindowEnd), "Time Window End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeWindowStart = group.Add(new VocabularyKey(nameof(TimeWindowStart), "Time Window Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ToDate = group.Add(new VocabularyKey(nameof(ToDate), "To Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkLocation = group.Add(new VocabularyKey(nameof(WorkLocation), "Work Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    City = group.Add(new VocabularyKey(nameof(City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostPrice = group.Add(new VocabularyKey(nameof(CostPrice), "Cost Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostPriceBase = group.Add(new VocabularyKey(nameof(CostPriceBase), "Cost Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    DeprecatedFulfilledHours = group.Add(new VocabularyKey(nameof(DeprecatedFulfilledHours), "Fulfilled Hours (Deprecated)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DeprecatedHours = group.Add(new VocabularyKey(nameof(DeprecatedHours), "Hours (Deprecated)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity (Deprecated in v3.0)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RequestStatus = group.Add(new VocabularyKey(nameof(RequestStatus), "Request Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateOrProvince = group.Add(new VocabularyKey(nameof(StateOrProvince), "State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="BookingSetupMetadataId"/> to Vocab 'BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'BookingSetupMetadataId'
            ///Property <see cref="Priority"/> to Vocab 'Priority.cdm.json/Priority' with Property 'PriorityId'
            ///Property <see cref="RequirementGroup"/> to Vocab 'RequirementGroup.cdm.json/RequirementGroup' with Property 'RequirementgroupId'
            ///Property <see cref="RequirementRelationship"/> to Vocab 'RequirementRelationship.cdm.json/RequirementRelationship' with Property 'RequirementrelationshipId'
            ///Property <see cref="Status"/> to Vocab 'RequirementStatus.cdm.json/RequirementStatus' with Property 'RequirementStatusId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="AppointmentRequirementId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="Territory"/> to Vocab '/core/applicationCommon/Territory.cdm.json/Territory' with Property 'TerritoryId'
            ///Property <see cref="TimeGroup"/> to Vocab 'TimeGroup.cdm.json/TimeGroup' with Property 'TimeGroupId'
            ///Property <see cref="WorkHourTemplate"/> to Vocab 'WorkHourTemplate.cdm.json/WorkHourTemplate' with Property 'WorkHourTemplateId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ProjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="DeprecatedRole"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="ResourceRequirementId"/> to Vocab 'ResourceRequirement.cdm.json/ResourceRequirement' with Property 'ResourceRequirementId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ResourceRequirementId"/> from Vocab 'RequirementCharacteristic.cdm.json/RequirementCharacteristic' with Property 'ResourceRequirement'
            ///Property <see cref="ResourceRequirementId"/> from Vocab 'RequirementOrganizationUnit.cdm.json/RequirementOrganizationUnit' with Property 'ResourceRequirement'
            ///Property <see cref="ResourceRequirementId"/> from Vocab 'RequirementResourceCategory.cdm.json/RequirementResourceCategory' with Property 'ResourceRequirement'
            ///Property <see cref="ResourceRequirementId"/> from Vocab 'RequirementResourcePreference.cdm.json/RequirementResourcePreference' with Property 'ResourceRequirement'
            ///Property <see cref="ResourceRequirementId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'ResourceRequirement'
            ///Property <see cref="ResourceRequirementId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'ResourceRequirement'
            ///Property <see cref="ResourceRequirementId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectTeam.cdm.json/ProjectTeam' with Property 'ResourceRequirementId'
            ///Property <see cref="ResourceRequirementId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ResourceRequest.cdm.json/ResourceRequest' with Property 'ResourceRequirementId'
            ///Property <see cref="ResourceRequirementId"/> from Vocab 'ResourceRequirementDetail.cdm.json/ResourceRequirementDetail' with Property 'ResourceRequirementId'
            #endregion
        }

        public VocabularyKey AllocationMethod { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CostPrice { get; private set; }
        public VocabularyKey CostPriceBase { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey DeprecatedFulfilledHours { get; private set; }
        public VocabularyKey DeprecatedHours { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey Effort { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey FulfilledDuration { get; private set; }
        public VocabularyKey InternalFlags { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey IsTemplate { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Percentage { get; private set; }
        public VocabularyKey PoolType { get; private set; }
        public VocabularyKey ProposedDuration { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey RemainingDuration { get; private set; }
        public VocabularyKey RequestStatus { get; private set; }
        public VocabularyKey RequirementGroupControlViewId { get; private set; }
        public VocabularyKey ResourceRequirementId { get; private set; }
        public VocabularyKey ResourceType { get; private set; }
        public VocabularyKey SortOptions { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StateOrProvince { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TemplateRequirementId { get; private set; }
        public VocabularyKey TimeFromPromised { get; private set; }
        public VocabularyKey TimeToPromised { get; private set; }
        public VocabularyKey TimeWindowEnd { get; private set; }
        public VocabularyKey TimeWindowStart { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey WorkLocation { get; private set; }
    }
}