using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventVocabulary : SimpleVocabulary
    {
        public EventVocabulary()
        {
            VocabularyName = "Event";
            KeyPrefix = "commonDataModel.event";
            KeySeparator = ".";
            Grouping = "/Event";

            AddGroup("Event Details", group =>
            {
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowAnonymousRegistrations = group.Add(new VocabularyKey(nameof(AllowAnonymousRegistrations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowAttendeesToUnmute = group.Add(new VocabularyKey(nameof(AllowAttendeesToUnmute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowCustomAgenda = group.Add(new VocabularyKey(nameof(AllowCustomAgenda), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowMeetingChat = group.Add(new VocabularyKey(nameof(AllowMeetingChat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Allowpstnsserstobypasslobby = group.Add(new VocabularyKey(nameof(Allowpstnsserstobypasslobby), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Allowteamsmeetingreactions = group.Add(new VocabularyKey(nameof(Allowteamsmeetingreactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttendeeEngagementReport = group.Add(new VocabularyKey(nameof(AttendeeEngagementReport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Attendeeurl = group.Add(new VocabularyKey(nameof(Attendeeurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Autoadmittedusers = group.Add(new VocabularyKey(nameof(Autoadmittedusers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Autorecordingenabled = group.Add(new VocabularyKey(nameof(Autorecordingenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Autoregisterwaitlistitems = group.Add(new VocabularyKey(nameof(Autoregisterwaitlistitems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseRecurrentEventID = group.Add(new VocabularyKey(nameof(BaseRecurrentEventID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BookedFlightReservations = group.Add(new VocabularyKey(nameof(BookedFlightReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BookRooms = group.Add(new VocabularyKey(nameof(BookRooms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetAllocated = group.Add(new VocabularyKey(nameof(BudgetAllocated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetAllocatedBase = group.Add(new VocabularyKey(nameof(BudgetAllocatedBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Calendarcontent = group.Add(new VocabularyKey(nameof(Calendarcontent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarcontentPlaintext = group.Add(new VocabularyKey(nameof(CalendarcontentPlaintext), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CateringRequired = group.Add(new VocabularyKey(nameof(CateringRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeMeetingOptions = group.Add(new VocabularyKey(nameof(ChangeMeetingOptions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckInCount = group.Add(new VocabularyKey(nameof(CheckInCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedHotelChoices = group.Add(new VocabularyKey(nameof(ConfirmedHotelChoices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountdownInDays = group.Add(new VocabularyKey(nameof(CountdownInDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateLeadsForEventRegistrations = group.Add(new VocabularyKey(nameof(CreateLeadsForEventRegistrations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateMarketingCollateral = group.Add(new VocabularyKey(nameof(CreateMarketingCollateral), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomEventURL = group.Add(new VocabularyKey(nameof(CustomEventURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefinePackagesAndPricing = group.Add(new VocabularyKey(nameof(DefinePackagesAndPricing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefineSessions = group.Add(new VocabularyKey(nameof(DefineSessions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefineTeam = group.Add(new VocabularyKey(nameof(DefineTeam), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescriptorSyncStatus = group.Add(new VocabularyKey(nameof(DescriptorSyncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DevelopMarketingPlan = group.Add(new VocabularyKey(nameof(DevelopMarketingPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarlyBirdCutOffDate = group.Add(new VocabularyKey(nameof(EarlyBirdCutOffDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableCAPTCHA = group.Add(new VocabularyKey(nameof(EnableCAPTCHA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableMultiAttendeeRegistration = group.Add(new VocabularyKey(nameof(EnableMultiAttendeeRegistration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Entryexitannouncementsenabled = group.Add(new VocabularyKey(nameof(Entryexitannouncementsenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventDebriefing = group.Add(new VocabularyKey(nameof(EventDebriefing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventEndDate = group.Add(new VocabularyKey(nameof(EventEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventFormat = group.Add(new VocabularyKey(nameof(EventFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventId = group.Add(new VocabularyKey(nameof(EventId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventImageId = group.Add(new VocabularyKey(nameof(EventImageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventStartDate = group.Add(new VocabularyKey(nameof(EventStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventTimeZone = group.Add(new VocabularyKey(nameof(EventTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventTimeZoneName = group.Add(new VocabularyKey(nameof(EventTimeZoneName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventType = group.Add(new VocabularyKey(nameof(EventType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventVenueCost = group.Add(new VocabularyKey(nameof(EventVenueCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventVenueCostBase = group.Add(new VocabularyKey(nameof(EventVenueCostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedOutcome = group.Add(new VocabularyKey(nameof(ExpectedOutcome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FollowUpOnLeads = group.Add(new VocabularyKey(nameof(FollowUpOnLeads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GuestLogistics = group.Add(new VocabularyKey(nameof(GuestLogistics), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentifySpeakers = group.Add(new VocabularyKey(nameof(IdentifySpeakers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentifySponsors = group.Add(new VocabularyKey(nameof(IdentifySponsors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Isoutofsync = group.Add(new VocabularyKey(nameof(Isoutofsync), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRecurringEvent = group.Add(new VocabularyKey(nameof(IsRecurringEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTemplate = group.Add(new VocabularyKey(nameof(IsTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastteamssyncdate = group.Add(new VocabularyKey(nameof(Lastteamssyncdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MakePaymentsDue = group.Add(new VocabularyKey(nameof(MakePaymentsDue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManageRegistrationCount = group.Add(new VocabularyKey(nameof(ManageRegistrationCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumEventCapacity = group.Add(new VocabularyKey(nameof(MaximumEventCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxNumberOfRegistrations = group.Add(new VocabularyKey(nameof(MaxNumberOfRegistrations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscellaneousCosts = group.Add(new VocabularyKey(nameof(MiscellaneousCosts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscellaneousCostsBase = group.Add(new VocabularyKey(nameof(MiscellaneousCostsBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotifyAuthoritiesOfEvent = group.Add(new VocabularyKey(nameof(NotifyAuthoritiesOfEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Numberofinvitations = group.Add(new VocabularyKey(nameof(Numberofinvitations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanRegistration = group.Add(new VocabularyKey(nameof(PlanRegistration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PresentationManagerURL = group.Add(new VocabularyKey(nameof(PresentationManagerURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreviousNumberOfFreeSlots = group.Add(new VocabularyKey(nameof(PreviousNumberOfFreeSlots), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryGoal = group.Add(new VocabularyKey(nameof(PrimaryGoal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Publiceventurl = group.Add(new VocabularyKey(nameof(Publiceventurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublishStatus = group.Add(new VocabularyKey(nameof(PublishStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Qna = group.Add(new VocabularyKey(nameof(Qna), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReadableEventID = group.Add(new VocabularyKey(nameof(ReadableEventID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Recordingforattendees = group.Add(new VocabularyKey(nameof(Recordingforattendees), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Recordingforproducersandspeakers = group.Add(new VocabularyKey(nameof(Recordingforproducersandspeakers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecoveryItems = group.Add(new VocabularyKey(nameof(RecoveryItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecurrencePattern = group.Add(new VocabularyKey(nameof(RecurrencePattern), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecurrentEventStatus = group.Add(new VocabularyKey(nameof(RecurrentEventStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationCount = group.Add(new VocabularyKey(nameof(RegistrationCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationsTarget = group.Add(new VocabularyKey(nameof(RegistrationsTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestSponsorship = group.Add(new VocabularyKey(nameof(RequestSponsorship), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueFromSponsorship = group.Add(new VocabularyKey(nameof(RevenueFromSponsorship), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueFromSponsorshipBase = group.Add(new VocabularyKey(nameof(RevenueFromSponsorshipBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleAirportPickups = group.Add(new VocabularyKey(nameof(ScheduleAirportPickups), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleSessions = group.Add(new VocabularyKey(nameof(ScheduleSessions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectSpeakers = group.Add(new VocabularyKey(nameof(SelectSpeakers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectVendors = group.Add(new VocabularyKey(nameof(SelectVendors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SendEventInvitation = group.Add(new VocabularyKey(nameof(SendEventInvitation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SendMarketingMaterial = group.Add(new VocabularyKey(nameof(SendMarketingMaterial), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SendPreEventReminders = group.Add(new VocabularyKey(nameof(SendPreEventReminders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SendThankYouEmails = group.Add(new VocabularyKey(nameof(SendThankYouEmails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Setregistrationsenddate = group.Add(new VocabularyKey(nameof(Setregistrationsenddate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Showautomaticregistrationcheckbox = group.Add(new VocabularyKey(nameof(Showautomaticregistrationcheckbox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowWaitlist = group.Add(new VocabularyKey(nameof(ShowWaitlist), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Stopwebsiteregistrationson = group.Add(new VocabularyKey(nameof(Stopwebsiteregistrationson), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Streamingenabled = group.Add(new VocabularyKey(nameof(Streamingenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreamingProvider = group.Add(new VocabularyKey(nameof(StreamingProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreationSource = group.Add(new VocabularyKey(nameof(CreationSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetRevenue = group.Add(new VocabularyKey(nameof(TargetRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetRevenueBase = group.Add(new VocabularyKey(nameof(TargetRevenueBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamDebriefing = group.Add(new VocabularyKey(nameof(TeamDebriefing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Teamsinvitationhtml = group.Add(new VocabularyKey(nameof(Teamsinvitationhtml), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCostOfEventsActivities = group.Add(new VocabularyKey(nameof(TotalCostOfEventsActivities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCostOfEventsActivitiesBase = group.Add(new VocabularyKey(nameof(TotalCostOfEventsActivitiesBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCostOfExternalMembers = group.Add(new VocabularyKey(nameof(TotalCostOfExternalMembers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCostOfExternalMembersBase = group.Add(new VocabularyKey(nameof(TotalCostOfExternalMembersBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRegistrationFee = group.Add(new VocabularyKey(nameof(TotalRegistrationFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalregistrationfeeBase = group.Add(new VocabularyKey(nameof(TotalregistrationfeeBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRevenueFromTheEvent = group.Add(new VocabularyKey(nameof(TotalRevenueFromTheEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRevenueFromTheEventBase = group.Add(new VocabularyKey(nameof(TotalRevenueFromTheEventBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaitlistStartingPoint = group.Add(new VocabularyKey(nameof(WaitlistStartingPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaitlistThisEvent = group.Add(new VocabularyKey(nameof(WaitlistThisEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarID = group.Add(new VocabularyKey(nameof(WebinarID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarNotificationSeen = group.Add(new VocabularyKey(nameof(WebinarNotificationSeen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarOperation = group.Add(new VocabularyKey(nameof(WebinarOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarStatus = group.Add(new VocabularyKey(nameof(WebinarStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarStatusReason = group.Add(new VocabularyKey(nameof(WebinarStatusReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarURL = group.Add(new VocabularyKey(nameof(WebinarURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Websitemessage = group.Add(new VocabularyKey(nameof(Websitemessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessID = group.Add(new VocabularyKey(nameof(ProcessID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StageID = group.Add(new VocabularyKey(nameof(StageID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AllowAnonymousRegistrations { get; private set; }
        public VocabularyKey AllowAttendeesToUnmute { get; private set; }
        public VocabularyKey AllowCustomAgenda { get; private set; }
        public VocabularyKey AllowMeetingChat { get; private set; }
        public VocabularyKey Allowpstnsserstobypasslobby { get; private set; }
        public VocabularyKey Allowteamsmeetingreactions { get; private set; }
        public VocabularyKey AttendeeEngagementReport { get; private set; }
        public VocabularyKey Attendeeurl { get; private set; }
        public VocabularyKey Autoadmittedusers { get; private set; }
        public VocabularyKey Autorecordingenabled { get; private set; }
        public VocabularyKey Autoregisterwaitlistitems { get; private set; }
        public VocabularyKey BaseRecurrentEventID { get; private set; }
        public VocabularyKey BookedFlightReservations { get; private set; }
        public VocabularyKey BookRooms { get; private set; }
        public VocabularyKey BudgetAllocated { get; private set; }
        public VocabularyKey BudgetAllocatedBase { get; private set; }
        public VocabularyKey Calendarcontent { get; private set; }
        public VocabularyKey CalendarcontentPlaintext { get; private set; }
        public VocabularyKey CateringRequired { get; private set; }
        public VocabularyKey ChangeMeetingOptions { get; private set; }
        public VocabularyKey CheckInCount { get; private set; }
        public VocabularyKey ConfirmedHotelChoices { get; private set; }
        public VocabularyKey CountdownInDays { get; private set; }
        public VocabularyKey CreateLeadsForEventRegistrations { get; private set; }
        public VocabularyKey CreateMarketingCollateral { get; private set; }
        public VocabularyKey CustomEventURL { get; private set; }
        public VocabularyKey DefinePackagesAndPricing { get; private set; }
        public VocabularyKey DefineSessions { get; private set; }
        public VocabularyKey DefineTeam { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DescriptorSyncStatus { get; private set; }
        public VocabularyKey DevelopMarketingPlan { get; private set; }
        public VocabularyKey EarlyBirdCutOffDate { get; private set; }
        public VocabularyKey EnableCAPTCHA { get; private set; }
        public VocabularyKey EnableMultiAttendeeRegistration { get; private set; }
        public VocabularyKey Entryexitannouncementsenabled { get; private set; }
        public VocabularyKey EventDebriefing { get; private set; }
        public VocabularyKey EventEndDate { get; private set; }
        public VocabularyKey EventFormat { get; private set; }
        public VocabularyKey EventId { get; private set; }
        public VocabularyKey EventImageId { get; private set; }
        public VocabularyKey EventStartDate { get; private set; }
        public VocabularyKey EventTimeZone { get; private set; }
        public VocabularyKey EventTimeZoneName { get; private set; }
        public VocabularyKey EventType { get; private set; }
        public VocabularyKey EventVenueCost { get; private set; }
        public VocabularyKey EventVenueCostBase { get; private set; }
        public VocabularyKey ExpectedOutcome { get; private set; }
        public VocabularyKey FollowUpOnLeads { get; private set; }
        public VocabularyKey GuestLogistics { get; private set; }
        public VocabularyKey IdentifySpeakers { get; private set; }
        public VocabularyKey IdentifySponsors { get; private set; }
        public VocabularyKey Isoutofsync { get; private set; }
        public VocabularyKey IsRecurringEvent { get; private set; }
        public VocabularyKey IsTemplate { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey Lastteamssyncdate { get; private set; }
        public VocabularyKey MakePaymentsDue { get; private set; }
        public VocabularyKey ManageRegistrationCount { get; private set; }
        public VocabularyKey MaximumEventCapacity { get; private set; }
        public VocabularyKey MaxNumberOfRegistrations { get; private set; }
        public VocabularyKey MiscellaneousCosts { get; private set; }
        public VocabularyKey MiscellaneousCostsBase { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NotifyAuthoritiesOfEvent { get; private set; }
        public VocabularyKey Numberofinvitations { get; private set; }
        public VocabularyKey PlanRegistration { get; private set; }
        public VocabularyKey PresentationManagerURL { get; private set; }
        public VocabularyKey PreviousNumberOfFreeSlots { get; private set; }
        public VocabularyKey PrimaryGoal { get; private set; }
        public VocabularyKey Publiceventurl { get; private set; }
        public VocabularyKey PublishStatus { get; private set; }
        public VocabularyKey Qna { get; private set; }
        public VocabularyKey ReadableEventID { get; private set; }
        public VocabularyKey Recordingforattendees { get; private set; }
        public VocabularyKey Recordingforproducersandspeakers { get; private set; }
        public VocabularyKey RecoveryItems { get; private set; }
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
        public VocabularyKey SendThankYouEmails { get; private set; }
        public VocabularyKey Setregistrationsenddate { get; private set; }
        public VocabularyKey Showautomaticregistrationcheckbox { get; private set; }
        public VocabularyKey ShowWaitlist { get; private set; }
        public VocabularyKey Stopwebsiteregistrationson { get; private set; }
        public VocabularyKey Streamingenabled { get; private set; }
        public VocabularyKey StreamingProvider { get; private set; }
        public VocabularyKey CreationSource { get; private set; }
        public VocabularyKey TargetRevenue { get; private set; }
        public VocabularyKey TargetRevenueBase { get; private set; }
        public VocabularyKey TeamDebriefing { get; private set; }
        public VocabularyKey Teamsinvitationhtml { get; private set; }
        public VocabularyKey TotalCostOfEventsActivities { get; private set; }
        public VocabularyKey TotalCostOfEventsActivitiesBase { get; private set; }
        public VocabularyKey TotalCostOfExternalMembers { get; private set; }
        public VocabularyKey TotalCostOfExternalMembersBase { get; private set; }
        public VocabularyKey TotalRegistrationFee { get; private set; }
        public VocabularyKey TotalregistrationfeeBase { get; private set; }
        public VocabularyKey TotalRevenueFromTheEvent { get; private set; }
        public VocabularyKey TotalRevenueFromTheEventBase { get; private set; }
        public VocabularyKey WaitlistStartingPoint { get; private set; }
        public VocabularyKey WaitlistThisEvent { get; private set; }
        public VocabularyKey WebinarID { get; private set; }
        public VocabularyKey WebinarNotificationSeen { get; private set; }
        public VocabularyKey WebinarOperation { get; private set; }
        public VocabularyKey WebinarStatus { get; private set; }
        public VocabularyKey WebinarStatusReason { get; private set; }
        public VocabularyKey WebinarURL { get; private set; }
        public VocabularyKey Websitemessage { get; private set; }
        public VocabularyKey ProcessID { get; private set; }
        public VocabularyKey StageID { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
    }
}