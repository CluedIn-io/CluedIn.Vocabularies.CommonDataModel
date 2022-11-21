using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CheckInVocabulary : SimpleVocabulary
    {
        public CheckInVocabulary()
        {
            VocabularyName = "Check In";
            KeyPrefix = "commonDataModel.checkin";
            KeySeparator = ".";
            Grouping = "/CheckIn";

            AddGroup("CheckIn Details", group =>
            {
                AudienceType = group.Add(new VocabularyKey(nameof(AudienceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckInId = group.Add(new VocabularyKey(nameof(CheckInId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckInTime = group.Add(new VocabularyKey(nameof(CheckInTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckInType = group.Add(new VocabularyKey(nameof(CheckInType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckOutTime = group.Add(new VocabularyKey(nameof(CheckOutTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfQuestionsAsked = group.Add(new VocabularyKey(nameof(NumberOfQuestionsAsked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Registrationidfromqr = group.Add(new VocabularyKey(nameof(Registrationidfromqr), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionCode = group.Add(new VocabularyKey(nameof(SessionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionType = group.Add(new VocabularyKey(nameof(SessionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ViewingDurationInMins = group.Add(new VocabularyKey(nameof(ViewingDurationInMins), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AudienceType { get; private set; }
        public VocabularyKey CheckInId { get; private set; }
        public VocabularyKey CheckInTime { get; private set; }
        public VocabularyKey CheckInType { get; private set; }
        public VocabularyKey CheckOutTime { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NumberOfQuestionsAsked { get; private set; }
        public VocabularyKey Registrationidfromqr { get; private set; }
        public VocabularyKey SessionCode { get; private set; }
        public VocabularyKey SessionType { get; private set; }
        public VocabularyKey ViewingDurationInMins { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}