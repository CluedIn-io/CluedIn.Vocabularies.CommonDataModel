using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class EventVocabulary : SimpleVocabulary
    {
        public EventVocabulary()
        {
            VocabularyName = "Event";
            KeyPrefix = "commonDataModel.event";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Event;

            AddGroup("Event Details for EventManagement", group =>
            {
			    EventId = group.Add(new VocabularyKey(nameof(EventId), "Event", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Event Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    BaseRecurrentEventID = group.Add(new VocabularyKey(nameof(BaseRecurrentEventID), "Base Recurrent Event ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookedFlightReservations = group.Add(new VocabularyKey(nameof(BookedFlightReservations), "Booked Flight reservations?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookRooms = group.Add(new VocabularyKey(nameof(BookRooms), "Book Rooms", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetAllocated = group.Add(new VocabularyKey(nameof(BudgetAllocated), "Budget Allocated", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    BudgetAllocatedBase = group.Add(new VocabularyKey(nameof(BudgetAllocatedBase), "Budget Allocated (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CateringRequired = group.Add(new VocabularyKey(nameof(CateringRequired), "Catering required?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CheckInCount = group.Add(new VocabularyKey(nameof(CheckInCount), "Check-in count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ConfirmedHotelChoices = group.Add(new VocabularyKey(nameof(ConfirmedHotelChoices), "Confirmed Hotel choices?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CountdownInDays = group.Add(new VocabularyKey(nameof(CountdownInDays), "Countdown in Days", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CreateMarketingCollateral = group.Add(new VocabularyKey(nameof(CreateMarketingCollateral), "Create Marketing Collateral", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefinePackagesandPricing = group.Add(new VocabularyKey(nameof(DefinePackagesandPricing), "Define Packages and Pricing", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefineSessions = group.Add(new VocabularyKey(nameof(DefineSessions), "Define Sessions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefineTeam = group.Add(new VocabularyKey(nameof(DefineTeam), "Define Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DevelopMarketingPlan = group.Add(new VocabularyKey(nameof(DevelopMarketingPlan), "Develop Marketing Plan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EarlyBirdCutOffDate = group.Add(new VocabularyKey(nameof(EarlyBirdCutOffDate), "Early Bird Cut-off Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventDebriefing = group.Add(new VocabularyKey(nameof(EventDebriefing), "Event Debriefing", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventEndDate = group.Add(new VocabularyKey(nameof(EventEndDate), "Event End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventFormat = group.Add(new VocabularyKey(nameof(EventFormat), "Event Format", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventStartDate = group.Add(new VocabularyKey(nameof(EventStartDate), "Event Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventTimeZone = group.Add(new VocabularyKey(nameof(EventTimeZone), "Event Time Zone", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    EventTimeZoneName = group.Add(new VocabularyKey(nameof(EventTimeZoneName), "Event Time Zone Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventType = group.Add(new VocabularyKey(nameof(EventType), "Event Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventVenueCost = group.Add(new VocabularyKey(nameof(EventVenueCost), "Event Venue Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EventVenueCostBase = group.Add(new VocabularyKey(nameof(EventVenueCostBase), "Event Venue Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedOutcome = group.Add(new VocabularyKey(nameof(ExpectedOutcome), "Expected Outcome", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FollowUpOnLeads = group.Add(new VocabularyKey(nameof(FollowUpOnLeads), "Follow up on Leads", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GuestLogistics = group.Add(new VocabularyKey(nameof(GuestLogistics), "Guest Logistics?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IdentifySpeakers = group.Add(new VocabularyKey(nameof(IdentifySpeakers), "Identify Speakers", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IdentifySponsors = group.Add(new VocabularyKey(nameof(IdentifySponsors), "Identify Sponsors", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsRecurringEvent = group.Add(new VocabularyKey(nameof(IsRecurringEvent), "Is Recurring Event", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsTemplate = group.Add(new VocabularyKey(nameof(IsTemplate), "Is Template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Language = group.Add(new VocabularyKey(nameof(Language), "Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MakePaymentsDue = group.Add(new VocabularyKey(nameof(MakePaymentsDue), "Make Payments Due", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ManageRegistrationCount = group.Add(new VocabularyKey(nameof(ManageRegistrationCount), "Manage Registration Count?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MaximumEventCapacity = group.Add(new VocabularyKey(nameof(MaximumEventCapacity), "Maximum Event Capacity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    MaxNumberOfRegistrations = group.Add(new VocabularyKey(nameof(MaxNumberOfRegistrations), "Max number of registrations", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    MiscellaneousCosts = group.Add(new VocabularyKey(nameof(MiscellaneousCosts), "Miscellaneous Costs", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    MiscellaneousCostsBase = group.Add(new VocabularyKey(nameof(MiscellaneousCostsBase), "Miscellaneous Costs (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NotifyAuthoritiesOfEvent = group.Add(new VocabularyKey(nameof(NotifyAuthoritiesOfEvent), "Notify Authorities of Event", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanRegistration = group.Add(new VocabularyKey(nameof(PlanRegistration), "Plan Registration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PresentationManagerUrl = group.Add(new VocabularyKey(nameof(PresentationManagerUrl), "Presentation Manager URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    PrimaryGoal = group.Add(new VocabularyKey(nameof(PrimaryGoal), "Primary Goal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PublicEventURL = group.Add(new VocabularyKey(nameof(PublicEventURL), "Event URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    PublishStatus = group.Add(new VocabularyKey(nameof(PublishStatus), "Publish Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReadableEventID = group.Add(new VocabularyKey(nameof(ReadableEventID), "Readable Event ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecurrencePattern = group.Add(new VocabularyKey(nameof(RecurrencePattern), "Recurrence pattern", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecurrentEventStatus = group.Add(new VocabularyKey(nameof(RecurrentEventStatus), "Recurrent Event Status", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RegistrationCount = group.Add(new VocabularyKey(nameof(RegistrationCount), "Registration Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RegistrationsTarget = group.Add(new VocabularyKey(nameof(RegistrationsTarget), "Registrations target", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RequestSponsorship = group.Add(new VocabularyKey(nameof(RequestSponsorship), "Request Sponsorship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RevenueFromSponsorship = group.Add(new VocabularyKey(nameof(RevenueFromSponsorship), "Revenue from Sponsorship", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RevenueFromSponsorshipBase = group.Add(new VocabularyKey(nameof(RevenueFromSponsorshipBase), "Revenue from Sponsorship (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleAirportPickups = group.Add(new VocabularyKey(nameof(ScheduleAirportPickups), "Schedule airport pickups?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleSessions = group.Add(new VocabularyKey(nameof(ScheduleSessions), "Schedule Sessions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SelectSpeakers = group.Add(new VocabularyKey(nameof(SelectSpeakers), "Select Speakers", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SelectVendors = group.Add(new VocabularyKey(nameof(SelectVendors), "Select Vendors", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SendEventInvitation = group.Add(new VocabularyKey(nameof(SendEventInvitation), "Send Event invitation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SendMarketingMaterial = group.Add(new VocabularyKey(nameof(SendMarketingMaterial), "Send Marketing Material", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SendPreEventReminders = group.Add(new VocabularyKey(nameof(SendPreEventReminders), "Send Pre Event Reminders", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SendThankYouEmails = group.Add(new VocabularyKey(nameof(SendThankYouEmails), "Send Thank You Emails", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShowWaitlist = group.Add(new VocabularyKey(nameof(ShowWaitlist), "Show Waitlist", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TargetRevenue = group.Add(new VocabularyKey(nameof(TargetRevenue), "Target Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TargetRevenueBase = group.Add(new VocabularyKey(nameof(TargetRevenueBase), "Target Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TeamDebriefing = group.Add(new VocabularyKey(nameof(TeamDebriefing), "Team Debriefing", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalCostOfEventsActivities = group.Add(new VocabularyKey(nameof(TotalCostOfEventsActivities), "Total Cost of Events Activities", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalCostOfEventsActivitiesBase = group.Add(new VocabularyKey(nameof(TotalCostOfEventsActivitiesBase), "Total Cost of Events Activities (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalCostOfExternalMembers = group.Add(new VocabularyKey(nameof(TotalCostOfExternalMembers), "Total cost of External Members", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalCostOfExternalMembersBase = group.Add(new VocabularyKey(nameof(TotalCostOfExternalMembersBase), "Total cost of External Members (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalRegistrationFee = group.Add(new VocabularyKey(nameof(TotalRegistrationFee), "Total Registration Fee (package cost)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalRegistrationFeeBase = group.Add(new VocabularyKey(nameof(TotalRegistrationFeeBase), "Total Registration Fee (package cost) (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalRevenueFromTheEvent = group.Add(new VocabularyKey(nameof(TotalRevenueFromTheEvent), "Total Revenue from the event", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalRevenueFromTheEventBase = group.Add(new VocabularyKey(nameof(TotalRevenueFromTheEventBase), "Total Revenue from the event (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), "Currency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WaitlistStartingPoint = group.Add(new VocabularyKey(nameof(WaitlistStartingPoint), "Waitlist Starting Point", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WaitlistthisEvent = group.Add(new VocabularyKey(nameof(WaitlistthisEvent), "Waitlist this Event", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarConfigurationId = group.Add(new VocabularyKey(nameof(WebinarConfigurationId), "Webinar Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarID = group.Add(new VocabularyKey(nameof(WebinarID), "Webinar ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarNotificationSeen = group.Add(new VocabularyKey(nameof(WebinarNotificationSeen), "Webinar Notification Seen", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    WebinarOperation = group.Add(new VocabularyKey(nameof(WebinarOperation), "Webinar Operation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarStatus = group.Add(new VocabularyKey(nameof(WebinarStatus), "Webinar Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarStatusReason = group.Add(new VocabularyKey(nameof(WebinarStatusReason), "Webinar Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarType = group.Add(new VocabularyKey(nameof(WebinarType), "Webinar Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarURL = group.Add(new VocabularyKey(nameof(WebinarURL), "Webinar URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    SendSurveys = group.Add(new VocabularyKey(nameof(SendSurveys), "Send Surveys", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventURLspecified = group.Add(new VocabularyKey(nameof(EventURLspecified), "Event URL specified", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SessionsCount = group.Add(new VocabularyKey(nameof(SessionsCount), "Session count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SessionsCountDate = group.Add(new VocabularyKey(nameof(SessionsCountDate), "Session count (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SessionsCountState = group.Add(new VocabularyKey(nameof(SessionsCountState), "Session count (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AllowAnonymousRegistrations = group.Add(new VocabularyKey(nameof(AllowAnonymousRegistrations), "Allow Anonymous Registrations", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PortalBannerImage = group.Add(new VocabularyKey(nameof(PortalBannerImage), "Portal Banner Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventURL = group.Add(new VocabularyKey(nameof(EventURL), "Portal Event URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="Account"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomRegistrationField"/> to Vocab 'CustomRegistrationField.cdm.json/CustomRegistrationField' with Property 'CustomRegistrationFieldId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PrimaryVenue"/> to Vocab 'Venue.cdm.json/Venue' with Property 'VenueId'
            ///Property <see cref="Producer"/> to Vocab 'EventTeamMember.cdm.json/EventTeamMember' with Property 'EventTeamMemberId'
            ///Property <see cref="Event"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="EventId"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ContactId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Contact"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="User"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="EventId"/> from Vocab 'AttendeePass.cdm.json/AttendeePass' with Property 'EventId'
            ///Property <see cref="EventRegistrationId"/> from Vocab 'AttendeePass.cdm.json/AttendeePass' with Property 'EventRegistrationId'
            ///Property <see cref="EventId"/> from Vocab 'CheckIn.cdm.json/CheckIn' with Property 'Event'
            ///Property <see cref="EventRegistrationId"/> from Vocab 'CheckIn.cdm.json/CheckIn' with Property 'RegistrationId'
            ///Property <see cref="EventTeamMemberId"/> from Vocab 'Event.cdm.json/Event' with Property 'Producer'
            ///Property <see cref="EventId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'OriginatingEvent'
            ///Property <see cref="EventId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Lead.cdm.json/Lead' with Property 'OriginatingEvent'
            ///Property <see cref="EventId"/> from Vocab 'EventCustomRegistrationField.cdm.json/EventCustomRegistrationField' with Property 'Event'
            ///Property <see cref="EventId"/> from Vocab 'EventRegistration.cdm.json/EventRegistration' with Property 'EventId'
            ///Property <see cref="EventId"/> from Vocab 'HotelRoomAllocation.cdm.json/HotelRoomAllocation' with Property 'Event'
            ///Property <see cref="EventId"/> from Vocab 'Pass.cdm.json/Pass' with Property 'EventId'
            ///Property <see cref="EventId"/> from Vocab 'Session.cdm.json/Session' with Property 'Event'
            ///Property <see cref="EventId"/> from Vocab 'SessionRegistration.cdm.json/SessionRegistration' with Property 'Event'
            ///Property <see cref="EventId"/> from Vocab 'SessionTrack.cdm.json/SessionTrack' with Property 'EventId'
            ///Property <see cref="EventId"/> from Vocab 'Speaker.cdm.json/Speaker' with Property 'EventId'
            ///Property <see cref="EventId"/> from Vocab 'SpeakerEngagement.cdm.json/SpeakerEngagement' with Property 'Event'
            ///Property <see cref="EventId"/> from Vocab 'Sponsorship.cdm.json/Sponsorship' with Property 'Event'
            ///Property <see cref="EventId"/> from Vocab 'WaitlistItem.cdm.json/WaitlistItem' with Property 'Event'
            ///Property <see cref="EventRegistrationId"/> from Vocab 'HotelRoomReservation.cdm.json/HotelRoomReservation' with Property 'Attendee'
            ///Property <see cref="EventRegistrationId"/> from Vocab 'RegistrationResponse.cdm.json/RegistrationResponse' with Property 'EventRegistration'
            ///Property <see cref="EventRegistrationId"/> from Vocab 'SessionRegistration.cdm.json/SessionRegistration' with Property 'RegistrationId'
            ///Property <see cref="EventTeamMemberId"/> from Vocab 'Session.cdm.json/Session' with Property 'Producer'
            ///Property <see cref="EventVendorId"/> from Vocab 'Hotel.cdm.json/Hotel' with Property 'HotelGroup'
            #endregion
        }

        public VocabularyKey AllowAnonymousRegistrations { get; private set; }
        public VocabularyKey BaseRecurrentEventID { get; private set; }
        public VocabularyKey BookedFlightReservations { get; private set; }
        public VocabularyKey BookRooms { get; private set; }
        public VocabularyKey BudgetAllocated { get; private set; }
        public VocabularyKey BudgetAllocatedBase { get; private set; }
        public VocabularyKey CateringRequired { get; private set; }
        public VocabularyKey CheckInCount { get; private set; }
        public VocabularyKey ConfirmedHotelChoices { get; private set; }
        public VocabularyKey CountdownInDays { get; private set; }
        public VocabularyKey CreateMarketingCollateral { get; private set; }
        public VocabularyKey DefinePackagesandPricing { get; private set; }
        public VocabularyKey DefineSessions { get; private set; }
        public VocabularyKey DefineTeam { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DevelopMarketingPlan { get; private set; }
        public VocabularyKey EarlyBirdCutOffDate { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey EventDebriefing { get; private set; }
        public VocabularyKey EventEndDate { get; private set; }
        public VocabularyKey EventFormat { get; private set; }
        public VocabularyKey EventId { get; private set; }
        public VocabularyKey EventStartDate { get; private set; }
        public VocabularyKey EventTimeZone { get; private set; }
        public VocabularyKey EventTimeZoneName { get; private set; }
        public VocabularyKey EventType { get; private set; }
        public VocabularyKey EventURL { get; private set; }
        public VocabularyKey EventURLspecified { get; private set; }
        public VocabularyKey EventVenueCost { get; private set; }
        public VocabularyKey EventVenueCostBase { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExpectedOutcome { get; private set; }
        public VocabularyKey FollowUpOnLeads { get; private set; }
        public VocabularyKey GuestLogistics { get; private set; }
        public VocabularyKey IdentifySpeakers { get; private set; }
        public VocabularyKey IdentifySponsors { get; private set; }
        public VocabularyKey IsRecurringEvent { get; private set; }
        public VocabularyKey IsTemplate { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey MakePaymentsDue { get; private set; }
        public VocabularyKey ManageRegistrationCount { get; private set; }
        public VocabularyKey MaximumEventCapacity { get; private set; }
        public VocabularyKey MaxNumberOfRegistrations { get; private set; }
        public VocabularyKey MiscellaneousCosts { get; private set; }
        public VocabularyKey MiscellaneousCostsBase { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NotifyAuthoritiesOfEvent { get; private set; }
        public VocabularyKey PlanRegistration { get; private set; }
        public VocabularyKey PortalBannerImage { get; private set; }
        public VocabularyKey PresentationManagerUrl { get; private set; }
        public VocabularyKey PrimaryGoal { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey PublicEventURL { get; private set; }
        public VocabularyKey PublishStatus { get; private set; }
        public VocabularyKey ReadableEventID { get; private set; }
        public VocabularyKey RecurrencePattern { get; private set; }
        public VocabularyKey RecurrentEventStatus { get; private set; }
        public VocabularyKey RegistrationCount { get; private set; }
        public VocabularyKey RegistrationsTarget { get; private set; }
        public VocabularyKey RequestSponsorship { get; private set; }
        public VocabularyKey RevenueFromSponsorship { get; private set; }
        public VocabularyKey RevenueFromSponsorshipBase { get; private set; }
        public VocabularyKey ScheduleAirportPickups { get; private set; }
        public VocabularyKey ScheduleSessions { get; private set; }
        public VocabularyKey SelectSpeakers { get; private set; }
        public VocabularyKey SelectVendors { get; private set; }
        public VocabularyKey SendEventInvitation { get; private set; }
        public VocabularyKey SendMarketingMaterial { get; private set; }
        public VocabularyKey SendPreEventReminders { get; private set; }
        public VocabularyKey SendSurveys { get; private set; }
        public VocabularyKey SendThankYouEmails { get; private set; }
        public VocabularyKey SessionsCount { get; private set; }
        public VocabularyKey SessionsCountDate { get; private set; }
        public VocabularyKey SessionsCountState { get; private set; }
        public VocabularyKey ShowWaitlist { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TargetRevenue { get; private set; }
        public VocabularyKey TargetRevenueBase { get; private set; }
        public VocabularyKey TeamDebriefing { get; private set; }
        public VocabularyKey TotalCostOfEventsActivities { get; private set; }
        public VocabularyKey TotalCostOfEventsActivitiesBase { get; private set; }
        public VocabularyKey TotalCostOfExternalMembers { get; private set; }
        public VocabularyKey TotalCostOfExternalMembersBase { get; private set; }
        public VocabularyKey TotalRegistrationFee { get; private set; }
        public VocabularyKey TotalRegistrationFeeBase { get; private set; }
        public VocabularyKey TotalRevenueFromTheEvent { get; private set; }
        public VocabularyKey TotalRevenueFromTheEventBase { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey WaitlistStartingPoint { get; private set; }
        public VocabularyKey WaitlistthisEvent { get; private set; }
        public VocabularyKey WebinarConfigurationId { get; private set; }
        public VocabularyKey WebinarID { get; private set; }
        public VocabularyKey WebinarNotificationSeen { get; private set; }
        public VocabularyKey WebinarOperation { get; private set; }
        public VocabularyKey WebinarStatus { get; private set; }
        public VocabularyKey WebinarStatusReason { get; private set; }
        public VocabularyKey WebinarType { get; private set; }
        public VocabularyKey WebinarURL { get; private set; }
    }
}