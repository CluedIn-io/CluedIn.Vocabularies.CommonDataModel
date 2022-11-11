using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventRegistrationVocabulary : SimpleVocabulary
    {
        public EventRegistrationVocabulary()
        {
            VocabularyName = "Common Data Model EventRegistration";
            KeyPrefix = "commonDataModel.eventregistration";
            KeySeparator = ".";
            Grouping = "/EventRegistration";

            AddGroup("Common Data Model EventRegistration Details", group =>
            {
                area = group.Add(new VocabularyKey(nameof(area), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                companySize = group.Add(new VocabularyKey(nameof(companySize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                correlationID = group.Add(new VocabularyKey(nameof(correlationID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdFromApi = group.Add(new VocabularyKey(nameof(createdFromApi), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                eventRegistrationId = group.Add(new VocabularyKey(nameof(eventRegistrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                industry = group.Add(new VocabularyKey(nameof(industry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                internalRegistrationStatus = group.Add(new VocabularyKey(nameof(internalRegistrationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isCanceled = group.Add(new VocabularyKey(nameof(isCanceled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                memo = group.Add(new VocabularyKey(nameof(memo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                primaryRole = group.Add(new VocabularyKey(nameof(primaryRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                publishingState = group.Add(new VocabularyKey(nameof(publishingState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCode = group.Add(new VocabularyKey(nameof(QRCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                registrationNotificationSeen = group.Add(new VocabularyKey(nameof(registrationNotificationSeen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                registrationOperation = group.Add(new VocabularyKey(nameof(registrationOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                registrationStatus = group.Add(new VocabularyKey(nameof(registrationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                syncedWithProvider = group.Add(new VocabularyKey(nameof(syncedWithProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timesCheckedIn = group.Add(new VocabularyKey(nameof(timesCheckedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                webinarRegistrationID = group.Add(new VocabularyKey(nameof(webinarRegistrationID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                yearsInIndustry = group.Add(new VocabularyKey(nameof(yearsInIndustry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey area { get; private set; }
        public VocabularyKey companySize { get; private set; }
        public VocabularyKey correlationID { get; private set; }
        public VocabularyKey createdFromApi { get; private set; }
        public VocabularyKey eventRegistrationId { get; private set; }
        public VocabularyKey industry { get; private set; }
        public VocabularyKey internalRegistrationStatus { get; private set; }
        public VocabularyKey isCanceled { get; private set; }
        public VocabularyKey memo { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey primaryRole { get; private set; }
        public VocabularyKey publishingState { get; private set; }
        public VocabularyKey QRCode { get; private set; }
        public VocabularyKey registrationNotificationSeen { get; private set; }
        public VocabularyKey registrationOperation { get; private set; }
        public VocabularyKey registrationStatus { get; private set; }
        public VocabularyKey syncedWithProvider { get; private set; }
        public VocabularyKey timesCheckedIn { get; private set; }
        public VocabularyKey webinarRegistrationID { get; private set; }
        public VocabularyKey yearsInIndustry { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}