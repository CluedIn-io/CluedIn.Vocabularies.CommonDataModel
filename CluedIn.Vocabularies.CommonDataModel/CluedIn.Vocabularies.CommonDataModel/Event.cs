using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventVocabulary : SimpleVocabulary
    {
        public EventVocabulary()
        {
            VocabularyName = "Common Data Model Event";
            KeyPrefix = "commonDataModel.event";
            KeySeparator = ".";
            Grouping = "/Event";

            AddGroup("Common Data Model Event Details", group =>
            {
                entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
allowAnonymousRegistrations = group.Add(new VocabularyKey(nameof(allowAnonymousRegistrations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
allowAttendeesToUnmute = group.Add(new VocabularyKey(nameof(allowAttendeesToUnmute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
allowCustomAgenda = group.Add(new VocabularyKey(nameof(allowCustomAgenda), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
allowMeetingChat = group.Add(new VocabularyKey(nameof(allowMeetingChat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
allowpstnsserstobypasslobby = group.Add(new VocabularyKey(nameof(allowpstnsserstobypasslobby), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
allowteamsmeetingreactions = group.Add(new VocabularyKey(nameof(allowteamsmeetingreactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
attendeeEngagementReport = group.Add(new VocabularyKey(nameof(attendeeEngagementReport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
attendeeurl = group.Add(new VocabularyKey(nameof(attendeeurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
autoadmittedusers = group.Add(new VocabularyKey(nameof(autoadmittedusers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
autorecordingenabled = group.Add(new VocabularyKey(nameof(autorecordingenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
autoregisterwaitlistitems = group.Add(new VocabularyKey(nameof(autoregisterwaitlistitems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
baseRecurrentEventID = group.Add(new VocabularyKey(nameof(baseRecurrentEventID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
bookedFlightReservations = group.Add(new VocabularyKey(nameof(bookedFlightReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
bookRooms = group.Add(new VocabularyKey(nameof(bookRooms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
budgetAllocated = group.Add(new VocabularyKey(nameof(budgetAllocated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
budgetAllocatedBase = group.Add(new VocabularyKey(nameof(budgetAllocatedBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
calendarcontent = group.Add(new VocabularyKey(nameof(calendarcontent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
calendarcontentPlaintext = group.Add(new VocabularyKey(nameof(calendarcontentPlaintext), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
cateringRequired = group.Add(new VocabularyKey(nameof(cateringRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
changeMeetingOptions = group.Add(new VocabularyKey(nameof(changeMeetingOptions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
checkInCount = group.Add(new VocabularyKey(nameof(checkInCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
confirmedHotelChoices = group.Add(new VocabularyKey(nameof(confirmedHotelChoices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
countdownInDays = group.Add(new VocabularyKey(nameof(countdownInDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createLeadsForEventRegistrations = group.Add(new VocabularyKey(nameof(createLeadsForEventRegistrations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createMarketingCollateral = group.Add(new VocabularyKey(nameof(createMarketingCollateral), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
customEventURL = group.Add(new VocabularyKey(nameof(customEventURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
definePackagesAndPricing = group.Add(new VocabularyKey(nameof(definePackagesAndPricing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
defineSessions = group.Add(new VocabularyKey(nameof(defineSessions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
defineTeam = group.Add(new VocabularyKey(nameof(defineTeam), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
descriptorSyncStatus = group.Add(new VocabularyKey(nameof(descriptorSyncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
developMarketingPlan = group.Add(new VocabularyKey(nameof(developMarketingPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
earlyBirdCutOffDate = group.Add(new VocabularyKey(nameof(earlyBirdCutOffDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
enableCAPTCHA = group.Add(new VocabularyKey(nameof(enableCAPTCHA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
enableMultiAttendeeRegistration = group.Add(new VocabularyKey(nameof(enableMultiAttendeeRegistration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
entryexitannouncementsenabled = group.Add(new VocabularyKey(nameof(entryexitannouncementsenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventDebriefing = group.Add(new VocabularyKey(nameof(eventDebriefing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventEndDate = group.Add(new VocabularyKey(nameof(eventEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventFormat = group.Add(new VocabularyKey(nameof(eventFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventId = group.Add(new VocabularyKey(nameof(eventId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventImageId = group.Add(new VocabularyKey(nameof(eventImageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventStartDate = group.Add(new VocabularyKey(nameof(eventStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventTimeZone = group.Add(new VocabularyKey(nameof(eventTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventTimeZoneName = group.Add(new VocabularyKey(nameof(eventTimeZoneName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventType = group.Add(new VocabularyKey(nameof(eventType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventVenueCost = group.Add(new VocabularyKey(nameof(eventVenueCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventVenueCostBase = group.Add(new VocabularyKey(nameof(eventVenueCostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
expectedOutcome = group.Add(new VocabularyKey(nameof(expectedOutcome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
followUpOnLeads = group.Add(new VocabularyKey(nameof(followUpOnLeads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
guestLogistics = group.Add(new VocabularyKey(nameof(guestLogistics), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
identifySpeakers = group.Add(new VocabularyKey(nameof(identifySpeakers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
identifySponsors = group.Add(new VocabularyKey(nameof(identifySponsors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isoutofsync = group.Add(new VocabularyKey(nameof(isoutofsync), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isRecurringEvent = group.Add(new VocabularyKey(nameof(isRecurringEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isTemplate = group.Add(new VocabularyKey(nameof(isTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
language = group.Add(new VocabularyKey(nameof(language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastteamssyncdate = group.Add(new VocabularyKey(nameof(lastteamssyncdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
makePaymentsDue = group.Add(new VocabularyKey(nameof(makePaymentsDue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
manageRegistrationCount = group.Add(new VocabularyKey(nameof(manageRegistrationCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maximumEventCapacity = group.Add(new VocabularyKey(nameof(maximumEventCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maxNumberOfRegistrations = group.Add(new VocabularyKey(nameof(maxNumberOfRegistrations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
miscellaneousCosts = group.Add(new VocabularyKey(nameof(miscellaneousCosts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
miscellaneousCostsBase = group.Add(new VocabularyKey(nameof(miscellaneousCostsBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
notifyAuthoritiesOfEvent = group.Add(new VocabularyKey(nameof(notifyAuthoritiesOfEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberofinvitations = group.Add(new VocabularyKey(nameof(numberofinvitations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
planRegistration = group.Add(new VocabularyKey(nameof(planRegistration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
presentationManagerURL = group.Add(new VocabularyKey(nameof(presentationManagerURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
previousNumberOfFreeSlots = group.Add(new VocabularyKey(nameof(previousNumberOfFreeSlots), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
primaryGoal = group.Add(new VocabularyKey(nameof(primaryGoal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
publiceventurl = group.Add(new VocabularyKey(nameof(publiceventurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
publishStatus = group.Add(new VocabularyKey(nameof(publishStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
qna = group.Add(new VocabularyKey(nameof(qna), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
readableEventID = group.Add(new VocabularyKey(nameof(readableEventID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
recordingforattendees = group.Add(new VocabularyKey(nameof(recordingforattendees), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
recordingforproducersandspeakers = group.Add(new VocabularyKey(nameof(recordingforproducersandspeakers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
recoveryItems = group.Add(new VocabularyKey(nameof(recoveryItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
recurrencePattern = group.Add(new VocabularyKey(nameof(recurrencePattern), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
recurrentEventStatus = group.Add(new VocabularyKey(nameof(recurrentEventStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
registrationCount = group.Add(new VocabularyKey(nameof(registrationCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
registrationsTarget = group.Add(new VocabularyKey(nameof(registrationsTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
requestSponsorship = group.Add(new VocabularyKey(nameof(requestSponsorship), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
revenueFromSponsorship = group.Add(new VocabularyKey(nameof(revenueFromSponsorship), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
revenueFromSponsorshipBase = group.Add(new VocabularyKey(nameof(revenueFromSponsorshipBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
scheduleAirportPickups = group.Add(new VocabularyKey(nameof(scheduleAirportPickups), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
scheduleSessions = group.Add(new VocabularyKey(nameof(scheduleSessions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
selectSpeakers = group.Add(new VocabularyKey(nameof(selectSpeakers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
selectVendors = group.Add(new VocabularyKey(nameof(selectVendors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sendEventInvitation = group.Add(new VocabularyKey(nameof(sendEventInvitation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sendMarketingMaterial = group.Add(new VocabularyKey(nameof(sendMarketingMaterial), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sendPreEventReminders = group.Add(new VocabularyKey(nameof(sendPreEventReminders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sendThankYouEmails = group.Add(new VocabularyKey(nameof(sendThankYouEmails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
setregistrationsenddate = group.Add(new VocabularyKey(nameof(setregistrationsenddate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
showautomaticregistrationcheckbox = group.Add(new VocabularyKey(nameof(showautomaticregistrationcheckbox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
showWaitlist = group.Add(new VocabularyKey(nameof(showWaitlist), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stopwebsiteregistrationson = group.Add(new VocabularyKey(nameof(stopwebsiteregistrationson), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
streamingenabled = group.Add(new VocabularyKey(nameof(streamingenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
streamingProvider = group.Add(new VocabularyKey(nameof(streamingProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
creationSource = group.Add(new VocabularyKey(nameof(creationSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
targetRevenue = group.Add(new VocabularyKey(nameof(targetRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
targetRevenueBase = group.Add(new VocabularyKey(nameof(targetRevenueBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
teamDebriefing = group.Add(new VocabularyKey(nameof(teamDebriefing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
teamsinvitationhtml = group.Add(new VocabularyKey(nameof(teamsinvitationhtml), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalCostOfEventsActivities = group.Add(new VocabularyKey(nameof(totalCostOfEventsActivities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalCostOfEventsActivitiesBase = group.Add(new VocabularyKey(nameof(totalCostOfEventsActivitiesBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalCostOfExternalMembers = group.Add(new VocabularyKey(nameof(totalCostOfExternalMembers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalCostOfExternalMembersBase = group.Add(new VocabularyKey(nameof(totalCostOfExternalMembersBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalRegistrationFee = group.Add(new VocabularyKey(nameof(totalRegistrationFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalregistrationfeeBase = group.Add(new VocabularyKey(nameof(totalregistrationfeeBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalRevenueFromTheEvent = group.Add(new VocabularyKey(nameof(totalRevenueFromTheEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalRevenueFromTheEventBase = group.Add(new VocabularyKey(nameof(totalRevenueFromTheEventBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
waitlistStartingPoint = group.Add(new VocabularyKey(nameof(waitlistStartingPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
waitlistThisEvent = group.Add(new VocabularyKey(nameof(waitlistThisEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webinarID = group.Add(new VocabularyKey(nameof(webinarID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webinarNotificationSeen = group.Add(new VocabularyKey(nameof(webinarNotificationSeen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webinarOperation = group.Add(new VocabularyKey(nameof(webinarOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webinarStatus = group.Add(new VocabularyKey(nameof(webinarStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webinarStatusReason = group.Add(new VocabularyKey(nameof(webinarStatusReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webinarURL = group.Add(new VocabularyKey(nameof(webinarURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
websitemessage = group.Add(new VocabularyKey(nameof(websitemessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
processID = group.Add(new VocabularyKey(nameof(processID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stageID = group.Add(new VocabularyKey(nameof(stageID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
traversedPath = group.Add(new VocabularyKey(nameof(traversedPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey entityImage { get; private set; }
public VocabularyKey exchangeRate { get; private set; }
public VocabularyKey allowAnonymousRegistrations { get; private set; }
public VocabularyKey allowAttendeesToUnmute { get; private set; }
public VocabularyKey allowCustomAgenda { get; private set; }
public VocabularyKey allowMeetingChat { get; private set; }
public VocabularyKey allowpstnsserstobypasslobby { get; private set; }
public VocabularyKey allowteamsmeetingreactions { get; private set; }
public VocabularyKey attendeeEngagementReport { get; private set; }
public VocabularyKey attendeeurl { get; private set; }
public VocabularyKey autoadmittedusers { get; private set; }
public VocabularyKey autorecordingenabled { get; private set; }
public VocabularyKey autoregisterwaitlistitems { get; private set; }
public VocabularyKey baseRecurrentEventID { get; private set; }
public VocabularyKey bookedFlightReservations { get; private set; }
public VocabularyKey bookRooms { get; private set; }
public VocabularyKey budgetAllocated { get; private set; }
public VocabularyKey budgetAllocatedBase { get; private set; }
public VocabularyKey calendarcontent { get; private set; }
public VocabularyKey calendarcontentPlaintext { get; private set; }
public VocabularyKey cateringRequired { get; private set; }
public VocabularyKey changeMeetingOptions { get; private set; }
public VocabularyKey checkInCount { get; private set; }
public VocabularyKey confirmedHotelChoices { get; private set; }
public VocabularyKey countdownInDays { get; private set; }
public VocabularyKey createLeadsForEventRegistrations { get; private set; }
public VocabularyKey createMarketingCollateral { get; private set; }
public VocabularyKey customEventURL { get; private set; }
public VocabularyKey definePackagesAndPricing { get; private set; }
public VocabularyKey defineSessions { get; private set; }
public VocabularyKey defineTeam { get; private set; }
public VocabularyKey description { get; private set; }
public VocabularyKey descriptorSyncStatus { get; private set; }
public VocabularyKey developMarketingPlan { get; private set; }
public VocabularyKey earlyBirdCutOffDate { get; private set; }
public VocabularyKey enableCAPTCHA { get; private set; }
public VocabularyKey enableMultiAttendeeRegistration { get; private set; }
public VocabularyKey entryexitannouncementsenabled { get; private set; }
public VocabularyKey eventDebriefing { get; private set; }
public VocabularyKey eventEndDate { get; private set; }
public VocabularyKey eventFormat { get; private set; }
public VocabularyKey eventId { get; private set; }
public VocabularyKey eventImageId { get; private set; }
public VocabularyKey eventStartDate { get; private set; }
public VocabularyKey eventTimeZone { get; private set; }
public VocabularyKey eventTimeZoneName { get; private set; }
public VocabularyKey eventType { get; private set; }
public VocabularyKey eventVenueCost { get; private set; }
public VocabularyKey eventVenueCostBase { get; private set; }
public VocabularyKey expectedOutcome { get; private set; }
public VocabularyKey followUpOnLeads { get; private set; }
public VocabularyKey guestLogistics { get; private set; }
public VocabularyKey identifySpeakers { get; private set; }
public VocabularyKey identifySponsors { get; private set; }
public VocabularyKey isoutofsync { get; private set; }
public VocabularyKey isRecurringEvent { get; private set; }
public VocabularyKey isTemplate { get; private set; }
public VocabularyKey language { get; private set; }
public VocabularyKey lastteamssyncdate { get; private set; }
public VocabularyKey makePaymentsDue { get; private set; }
public VocabularyKey manageRegistrationCount { get; private set; }
public VocabularyKey maximumEventCapacity { get; private set; }
public VocabularyKey maxNumberOfRegistrations { get; private set; }
public VocabularyKey miscellaneousCosts { get; private set; }
public VocabularyKey miscellaneousCostsBase { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey notifyAuthoritiesOfEvent { get; private set; }
public VocabularyKey numberofinvitations { get; private set; }
public VocabularyKey planRegistration { get; private set; }
public VocabularyKey presentationManagerURL { get; private set; }
public VocabularyKey previousNumberOfFreeSlots { get; private set; }
public VocabularyKey primaryGoal { get; private set; }
public VocabularyKey publiceventurl { get; private set; }
public VocabularyKey publishStatus { get; private set; }
public VocabularyKey qna { get; private set; }
public VocabularyKey readableEventID { get; private set; }
public VocabularyKey recordingforattendees { get; private set; }
public VocabularyKey recordingforproducersandspeakers { get; private set; }
public VocabularyKey recoveryItems { get; private set; }
public VocabularyKey recurrencePattern { get; private set; }
public VocabularyKey recurrentEventStatus { get; private set; }
public VocabularyKey registrationCount { get; private set; }
public VocabularyKey registrationsTarget { get; private set; }
public VocabularyKey requestSponsorship { get; private set; }
public VocabularyKey revenueFromSponsorship { get; private set; }
public VocabularyKey revenueFromSponsorshipBase { get; private set; }
public VocabularyKey scheduleAirportPickups { get; private set; }
public VocabularyKey scheduleSessions { get; private set; }
public VocabularyKey selectSpeakers { get; private set; }
public VocabularyKey selectVendors { get; private set; }
public VocabularyKey sendEventInvitation { get; private set; }
public VocabularyKey sendMarketingMaterial { get; private set; }
public VocabularyKey sendPreEventReminders { get; private set; }
public VocabularyKey sendThankYouEmails { get; private set; }
public VocabularyKey setregistrationsenddate { get; private set; }
public VocabularyKey showautomaticregistrationcheckbox { get; private set; }
public VocabularyKey showWaitlist { get; private set; }
public VocabularyKey stopwebsiteregistrationson { get; private set; }
public VocabularyKey streamingenabled { get; private set; }
public VocabularyKey streamingProvider { get; private set; }
public VocabularyKey creationSource { get; private set; }
public VocabularyKey targetRevenue { get; private set; }
public VocabularyKey targetRevenueBase { get; private set; }
public VocabularyKey teamDebriefing { get; private set; }
public VocabularyKey teamsinvitationhtml { get; private set; }
public VocabularyKey totalCostOfEventsActivities { get; private set; }
public VocabularyKey totalCostOfEventsActivitiesBase { get; private set; }
public VocabularyKey totalCostOfExternalMembers { get; private set; }
public VocabularyKey totalCostOfExternalMembersBase { get; private set; }
public VocabularyKey totalRegistrationFee { get; private set; }
public VocabularyKey totalregistrationfeeBase { get; private set; }
public VocabularyKey totalRevenueFromTheEvent { get; private set; }
public VocabularyKey totalRevenueFromTheEventBase { get; private set; }
public VocabularyKey waitlistStartingPoint { get; private set; }
public VocabularyKey waitlistThisEvent { get; private set; }
public VocabularyKey webinarID { get; private set; }
public VocabularyKey webinarNotificationSeen { get; private set; }
public VocabularyKey webinarOperation { get; private set; }
public VocabularyKey webinarStatus { get; private set; }
public VocabularyKey webinarStatusReason { get; private set; }
public VocabularyKey webinarURL { get; private set; }
public VocabularyKey websitemessage { get; private set; }
public VocabularyKey processID { get; private set; }
public VocabularyKey stageID { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey traversedPath { get; private set; }


    }
}