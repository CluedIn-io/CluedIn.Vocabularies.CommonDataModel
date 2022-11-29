using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class TeamMembershipVocabulary : SimpleVocabulary
    {
        public TeamMembershipVocabulary()
        {
            VocabularyName = "Team Membership";
            KeyPrefix = "commonDataModel.teammembership.applicationcommon";
            KeySeparator = ".";
            Grouping = "/TeamMembership";

            AddGroup("TeamMembership Details for ApplicationCommon", group =>
            {
			    TeamMembershipId = group.Add(new VocabularyKey(nameof(TeamMembershipId), "Team Membership Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey TeamMembershipId { get; private set; }
    }
}