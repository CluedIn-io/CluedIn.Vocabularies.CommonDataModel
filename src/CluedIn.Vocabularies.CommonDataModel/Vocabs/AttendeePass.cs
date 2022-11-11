using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AttendeePassVocabulary : SimpleVocabulary
    {
        public AttendeePassVocabulary()
        {
            VocabularyName = "Common Data Model AttendeePass";
            KeyPrefix = "commonDataModel.attendeepass";
            KeySeparator = ".";
            Grouping = "/AttendeePass";

            AddGroup("Common Data Model AttendeePass Details", group =>
            {
                exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                attendeePassId = group.Add(new VocabularyKey(nameof(attendeePassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                passPrice = group.Add(new VocabularyKey(nameof(passPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                passPriceBase = group.Add(new VocabularyKey(nameof(passPriceBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey exchangeRate { get; private set; }
        public VocabularyKey attendeePassId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey passPrice { get; private set; }
        public VocabularyKey passPriceBase { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}