using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventAdministrationVocabulary : SimpleVocabulary
    {
        public EventAdministrationVocabulary()
        {
            VocabularyName = "Common Data Model EventAdministration";
            KeyPrefix = "commonDataModel.eventadministration";
            KeySeparator = ".";
            Grouping = "/EventAdministration";

            AddGroup("Common Data Model EventAdministration Details", group =>
            {
                contactmatchingstrategy = group.Add(new VocabularyKey(nameof(contactmatchingstrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailTemplateForAttendee = group.Add(new VocabularyKey(nameof(emailTemplateForAttendee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailTemplateForPurchaser = group.Add(new VocabularyKey(nameof(emailTemplateForPurchaser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                enablefinalizationendpoints = group.Add(new VocabularyKey(nameof(enablefinalizationendpoints), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                eventAdministrationId = group.Add(new VocabularyKey(nameof(eventAdministrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sendMailToEventAttendee = group.Add(new VocabularyKey(nameof(sendMailToEventAttendee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sendMailToPurchaser = group.Add(new VocabularyKey(nameof(sendMailToPurchaser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey contactmatchingstrategy { get; private set; }
        public VocabularyKey emailTemplateForAttendee { get; private set; }
        public VocabularyKey emailTemplateForPurchaser { get; private set; }
        public VocabularyKey enablefinalizationendpoints { get; private set; }
        public VocabularyKey eventAdministrationId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey sendMailToEventAttendee { get; private set; }
        public VocabularyKey sendMailToPurchaser { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}