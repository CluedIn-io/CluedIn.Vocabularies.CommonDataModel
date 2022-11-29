using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class EventTeamMemberVocabulary : SimpleVocabulary
    {
        public EventTeamMemberVocabulary()
        {
            VocabularyName = "Event Team Member";
            KeyPrefix = "commonDataModel.eventteammember.eventmanagement";
            KeySeparator = ".";
            Grouping = "/EventTeamMember";

            AddGroup("EventTeamMember Details for EventManagement", group =>
            {
			    EventTeamMemberId = group.Add(new VocabularyKey(nameof(EventTeamMemberId), "Event Team Member", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Company = group.Add(new VocabularyKey(nameof(Company), "Company", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Email = group.Add(new VocabularyKey(nameof(Email), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    MemberType = group.Add(new VocabularyKey(nameof(MemberType), "Member Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Phone = group.Add(new VocabularyKey(nameof(Phone), "Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Role = group.Add(new VocabularyKey(nameof(Role), "Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EventTeamMemberId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey MemberType { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey Role { get; private set; }
    }
}