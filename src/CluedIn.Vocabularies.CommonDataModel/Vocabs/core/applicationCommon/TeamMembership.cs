using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ApplicationCommon
{
    public class TeamMembershipVocabulary : SimpleVocabulary
    {
        public TeamMembershipVocabulary()
        {
            VocabularyName = "Team Membership";
            KeyPrefix = "commonDataModel.teammembership.applicationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.TeamMembership;

            AddGroup("TeamMembership Details for ApplicationCommon", group =>
            {
			    TeamMembershipId = group.Add(new VocabularyKey(nameof(TeamMembershipId), "Team Membership Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="TeamId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="SystemUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey TeamMembershipId { get; private set; }
    }
}