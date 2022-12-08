using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectCommon
{
    public class BookableResourceVocabulary : SimpleVocabulary
    {
        public BookableResourceVocabulary()
        {
            VocabularyName = "Bookable Resource";
            KeyPrefix = "commonDataModel.bookableresource.projectcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BookableResource;

            AddGroup("BookableResource Details for ProjectCommon", group =>
            {
			    PoolType = group.Add(new VocabularyKey(nameof(PoolType), "Pool Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeriveCapacity = group.Add(new VocabularyKey(nameof(DeriveCapacity), "Derive Capacity From Group Members", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DisplayOnScheduleAssistant = group.Add(new VocabularyKey(nameof(DisplayOnScheduleAssistant), "Enable for Availability Search", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DisplayOnScheduleBoard = group.Add(new VocabularyKey(nameof(DisplayOnScheduleBoard), "Display On Schedule Board", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EndLocation = group.Add(new VocabularyKey(nameof(EndLocation), "End Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GenericType = group.Add(new VocabularyKey(nameof(GenericType), "Generic Type (Deprecated)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryEMail = group.Add(new VocabularyKey(nameof(PrimaryEMail), "Primary Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    StartLocation = group.Add(new VocabularyKey(nameof(StartLocation), "Start Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetUtilization = group.Add(new VocabularyKey(nameof(TargetUtilization), "Target Utilization", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="AccountId"/> to Vocab 'projectServiceAutomation/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="UserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="OrganizationalUnit"/> to Vocab 'scheduling/OrganizationalUnit.cdm.json/OrganizationalUnit' with Property 'OrganizationalUnitId'
            ///Property <see cref="Resource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="Resource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="Resource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="Resource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="ChildResource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="ParentResource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="ResourceGroup"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="BookableResourceId"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="Resource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="Resource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="Resource1"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="Resource2"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="BookingStatus"/> to Vocab 'BookingStatus.cdm.json/BookingStatus' with Property 'BookingStatusId'
            ///Property <see cref="Header"/> to Vocab 'BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="AppointmentBookingId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="BookingSetupMetadataId"/> to Vocab 'scheduling/BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'BookingSetupMetadataId'
            ///Property <see cref="RequirementGroup"/> to Vocab 'scheduling/RequirementGroup.cdm.json/RequirementGroup' with Property 'RequirementgroupId'
            ///Property <see cref="ResourceRequirement"/> to Vocab 'scheduling/ResourceRequirement.cdm.json/ResourceRequirement' with Property 'ResourceRequirementId'
            ///Property <see cref="TimeGroupDetailSelected"/> to Vocab 'scheduling/TimeGroupDetail.cdm.json/TimeGroupDetail' with Property 'TimeGroupDetailId'
            ///Property <see cref="ProjectId"/> to Vocab 'projectServiceAutomation/Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ProjectTeamId"/> to Vocab 'projectServiceAutomation/ProjectTeam.cdm.json/ProjectTeam' with Property 'ProjectTeamId'
            ///Property <see cref="ResourceCategoryId"/> to Vocab 'projectServiceAutomation/BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="BookingStatusId"/> to Vocab 'BookingStatus.cdm.json/BookingStatus' with Property 'BookingStatusId'
            ///Property <see cref="ResourceRequirement"/> to Vocab 'scheduling/ResourceRequirement.cdm.json/ResourceRequirement' with Property 'ResourceRequirementId'
            ///Property <see cref="ProjectId"/> to Vocab 'projectServiceAutomation/Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ProjectTeamId"/> to Vocab 'projectServiceAutomation/ProjectTeam.cdm.json/ProjectTeam' with Property 'ProjectTeamId'
            ///Property <see cref="ResourceCategoryId"/> to Vocab 'projectServiceAutomation/BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="Header"/> to Vocab 'BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="BookingStatus"/> to Vocab 'BookingStatus.cdm.json/BookingStatus' with Property 'BookingStatusId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RatingValue"/> to Vocab 'RatingValue.cdm.json/RatingValue' with Property 'RatingValueId'
            ///Property <see cref="RatingValue"/> to Vocab 'RatingValue.cdm.json/RatingValue' with Property 'RatingValueId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="UserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BookableResourceId"/> from Vocab 'BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'Resource'
            ///Property <see cref="BookableResourceId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'Resource'
            ///Property <see cref="BookableResourceId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResourceCategoryAssn.cdm.json/BookableResourceCategoryAssn' with Property 'Resource'
            ///Property <see cref="BookableResourceId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResourceCharacteristic.cdm.json/BookableResourceCharacteristic' with Property 'Resource'
            ///Property <see cref="BookableResourceId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResourceGroup.cdm.json/BookableResourceGroup' with Property 'ChildResource'
            ///Property <see cref="BookableResourceId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResourceGroup.cdm.json/BookableResourceGroup' with Property 'ParentResource'
            ///Property <see cref="BookableResourceId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Schedule.cdm.json/Schedule' with Property 'BookableResourceId'
            ///Property <see cref="BookableResourceId"/> from Vocab 'BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'ResourceGroup'
            ///Property <see cref="BookableResourceId"/> from Vocab 'BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceId'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/BookableResourceCategoryAssn.cdm.json/BookableResourceCategoryAssn' with Property 'Resource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/BookableResourceCharacteristic.cdm.json/BookableResourceCharacteristic' with Property 'Resource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/Delegation.cdm.json/Delegation' with Property 'DelegationFrom'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/Delegation.cdm.json/Delegation' with Property 'DelegationTo'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/EstimateLine.cdm.json/EstimateLine' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/Expense.cdm.json/Expense' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/Fact.cdm.json/Fact' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/FindWorkEvent.cdm.json/FindWorkEvent' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/JournalLine.cdm.json/JournalLine' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/OpportunityLineTransaction.cdm.json/OpportunityLineTransaction' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/ProjectApproval.cdm.json/ProjectApproval' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/ProjectApproval.cdm.json/ProjectApproval' with Property 'SubmittedBy'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/ProjectTaskStatusUser.cdm.json/ProjectTaskStatusUser' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/ProjectTeam.cdm.json/ProjectTeam' with Property 'BookableResourceId'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/ProjectTeamMemberSignUp.cdm.json/ProjectTeamMemberSignUp' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/ResourceAssignment.cdm.json/ResourceAssignment' with Property 'BookableResourceId'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/RolePriceMarkup.cdm.json/RolePriceMarkup' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/TimeEntry.cdm.json/TimeEntry' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'projectServiceAutomation/UserWorkHistory.cdm.json/UserWorkHistory' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'scheduling/Actual.cdm.json/Actual' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'scheduling/BookableResourceAssociation.cdm.json/BookableResourceAssociation' with Property 'Resource1'
            ///Property <see cref="BookableResourceId"/> from Vocab 'scheduling/BookableResourceAssociation.cdm.json/BookableResourceAssociation' with Property 'Resource2'
            ///Property <see cref="BookableResourceId"/> from Vocab 'scheduling/RequirementResourcePreference.cdm.json/RequirementResourcePreference' with Property 'BookableResource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'scheduling/ResourceTerritory.cdm.json/ResourceTerritory' with Property 'Resource'
            ///Property <see cref="BookableResourceId"/> from Vocab 'scheduling/WorkHourTemplate.cdm.json/WorkHourTemplate' with Property 'TemplateResource'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'Header'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'ResourceCategoryId'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'ResourceCategoryId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'Header'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignActivity.cdm.json/CampaignActivity' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey PoolType { get; private set; }
        public VocabularyKey DeriveCapacity { get; private set; }
        public VocabularyKey DisplayOnScheduleAssistant { get; private set; }
        public VocabularyKey DisplayOnScheduleBoard { get; private set; }
        public VocabularyKey EndLocation { get; private set; }
        public VocabularyKey GenericType { get; private set; }
        public VocabularyKey PrimaryEMail { get; private set; }
        public VocabularyKey StartLocation { get; private set; }
        public VocabularyKey TargetUtilization { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
    }
}