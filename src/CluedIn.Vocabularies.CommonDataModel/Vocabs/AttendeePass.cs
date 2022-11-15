using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AttendeePassVocabulary : SimpleVocabulary
    {
        public AttendeePassVocabulary()
        {
            VocabularyName = "Attendee Pass";
            KeyPrefix = "commonDataModel.attendeepass";
            KeySeparator = ".";
            Grouping = "/AttendeePass";

            AddGroup("AttendeePass Details", group =>
            {
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttendeePassId = group.Add(new VocabularyKey(nameof(AttendeePassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassPrice = group.Add(new VocabularyKey(nameof(PassPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassPriceBase = group.Add(new VocabularyKey(nameof(PassPriceBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AttendeePassId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PassPrice { get; private set; }
        public VocabularyKey PassPriceBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}