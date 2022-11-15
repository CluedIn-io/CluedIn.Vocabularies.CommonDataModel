using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventTeamMemberVocabulary : SimpleVocabulary
    {
        public EventTeamMemberVocabulary()
        {
            VocabularyName = "Event Team Member";
            KeyPrefix = "commonDataModel.eventteammember";
            KeySeparator = ".";
            Grouping = "/EventTeamMember";

            AddGroup("EventTeamMember Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventTeamMemberId = group.Add(new VocabularyKey(nameof(EventTeamMemberId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MemberType = group.Add(new VocabularyKey(nameof(MemberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey(nameof(Phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Role = group.Add(new VocabularyKey(nameof(Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey EventTeamMemberId { get; private set; }
        public VocabularyKey MemberType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey Role { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}