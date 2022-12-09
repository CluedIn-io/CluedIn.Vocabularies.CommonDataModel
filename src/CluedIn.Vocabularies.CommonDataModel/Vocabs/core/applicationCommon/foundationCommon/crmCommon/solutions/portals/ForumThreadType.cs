using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ForumThreadTypeVocabulary : SimpleVocabulary
    {
        public ForumThreadTypeVocabulary()
        {
            VocabularyName = "Forum Thread Type";
            KeyPrefix = "commonDataModel.forumthreadtype";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ForumThreadType;

            AddGroup("ForumThreadType Details for Portals", group =>
            {
			    ForumThreadTypeId = group.Add(new VocabularyKey(nameof(ForumThreadTypeId), "Forum Thread Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllowsVoting = group.Add(new VocabularyKey(nameof(AllowsVoting), "Allows Voting", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), "Display Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RequiresAnswer = group.Add(new VocabularyKey(nameof(RequiresAnswer), "Requires Answer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="WebsiteId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ForumThreadTypeId"/> from Vocab 'ForumThread.cdm.json/ForumThread' with Property 'TypeId'
            #endregion
        }

        public VocabularyKey AllowsVoting { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey ForumThreadTypeId { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequiresAnswer { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}