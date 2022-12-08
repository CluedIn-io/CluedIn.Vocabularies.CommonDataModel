using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.LinkedInLeads
{
    public class LinkedInFormQuestionVocabulary : SimpleVocabulary
    {
        public LinkedInFormQuestionVocabulary()
        {
            VocabularyName = "Linked In Form Question";
            KeyPrefix = "commonDataModel.linkedinformquestion.linkedinleads";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.LinkedInFormQuestion;

            AddGroup("LinkedInFormQuestion Details for LinkedInLeads", group =>
            {
			    LinkedInFormQuestionId = group.Add(new VocabularyKey(nameof(LinkedInFormQuestionId), "LinkedIn Form Question", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayName = group.Add(new VocabularyKey(nameof(DisplayName), "Display name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsCustomQuestion = group.Add(new VocabularyKey(nameof(IsCustomQuestion), "Is Custom Question", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LinkedInID = group.Add(new VocabularyKey(nameof(LinkedInID), "LinkedIn ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInPredefinedField = group.Add(new VocabularyKey(nameof(LinkedInPredefinedField), "LinkedIn Predefined Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResponseEditable = group.Add(new VocabularyKey(nameof(ResponseEditable), "Response editable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ResponseType = group.Add(new VocabularyKey(nameof(ResponseType), "Response type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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
            ///Property <see cref="LinkedinForm"/> to Vocab 'LinkedInLeadGenForm.cdm.json/LinkedInLeadGenForm' with Property 'LinkedinformId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="LinkedInFormQuestionId"/> from Vocab 'LinkedInFormSubmissionAnswer.cdm.json/LinkedInFormSubmissionAnswer' with Property 'LinkedInQuestion'
            #endregion
        }

        public VocabularyKey LinkedInFormQuestionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey DisplayName { get; private set; }
        public VocabularyKey IsCustomQuestion { get; private set; }
        public VocabularyKey LinkedInID { get; private set; }
        public VocabularyKey LinkedInPredefinedField { get; private set; }
        public VocabularyKey ResponseEditable { get; private set; }
        public VocabularyKey ResponseType { get; private set; }
    }
}