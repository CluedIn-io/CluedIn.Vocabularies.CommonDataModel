using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventAdministrationVocabulary : SimpleVocabulary
    {
        public EventAdministrationVocabulary()
        {
            VocabularyName = "Event Administration";
            KeyPrefix = "commonDataModel.eventadministration";
            KeySeparator = ".";
            Grouping = "/EventAdministration";

            AddGroup("EventAdministration Details", group =>
            {
                Contactmatchingstrategy = group.Add(new VocabularyKey(nameof(Contactmatchingstrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailTemplateForAttendee = group.Add(new VocabularyKey(nameof(EmailTemplateForAttendee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailTemplateForPurchaser = group.Add(new VocabularyKey(nameof(EmailTemplateForPurchaser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Enablefinalizationendpoints = group.Add(new VocabularyKey(nameof(Enablefinalizationendpoints), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventAdministrationId = group.Add(new VocabularyKey(nameof(EventAdministrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SendMailToEventAttendee = group.Add(new VocabularyKey(nameof(SendMailToEventAttendee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SendMailToPurchaser = group.Add(new VocabularyKey(nameof(SendMailToPurchaser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Contactmatchingstrategy { get; private set; }
        public VocabularyKey EmailTemplateForAttendee { get; private set; }
        public VocabularyKey EmailTemplateForPurchaser { get; private set; }
        public VocabularyKey Enablefinalizationendpoints { get; private set; }
        public VocabularyKey EventAdministrationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SendMailToEventAttendee { get; private set; }
        public VocabularyKey SendMailToPurchaser { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}