using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventTeamMemberVocabulary : SimpleVocabulary
    {
        public EventTeamMemberVocabulary()
        {
            VocabularyName = "Common Data Model EventTeamMember";
            KeyPrefix = "commonDataModel.eventteammember";
            KeySeparator = ".";
            Grouping = "/EventTeamMember";

            AddGroup("Common Data Model EventTeamMember Details", group =>
            {
                company = group.Add(new VocabularyKey(nameof(company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                email = group.Add(new VocabularyKey(nameof(email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                eventTeamMemberId = group.Add(new VocabularyKey(nameof(eventTeamMemberId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                memberType = group.Add(new VocabularyKey(nameof(memberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                phone = group.Add(new VocabularyKey(nameof(phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                role = group.Add(new VocabularyKey(nameof(role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey company { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey email { get; private set; }
        public VocabularyKey eventTeamMemberId { get; private set; }
        public VocabularyKey memberType { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey phone { get; private set; }
        public VocabularyKey role { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}