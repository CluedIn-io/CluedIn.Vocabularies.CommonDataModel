using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class LinkedInFormSubmissionAnswerVocabulary : SimpleVocabulary
    {
        public LinkedInFormSubmissionAnswerVocabulary()
        {
            VocabularyName = "Linked In Form Submission Answer";
            KeyPrefix = "commonDataModel.linkedinformsubmissionanswer";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.LinkedInFormSubmissionAnswer;

            AddGroup("LinkedInFormSubmissionAnswer Details for LinkedInLeads", group =>
            {
			    LinkedInFormAnswerId = group.Add(new VocabularyKey(nameof(LinkedInFormAnswerId), "LinkedIn Form Answer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnswerId = group.Add(new VocabularyKey(nameof(AnswerId), "Answer Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnswerFormat = group.Add(new VocabularyKey(nameof(AnswerFormat), "Answer format", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnswerText = group.Add(new VocabularyKey(nameof(AnswerText), "Answer text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInQuestionID = group.Add(new VocabularyKey(nameof(LinkedInQuestionID), "LinkedIn question ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="LinkedInQuestion"/> to Vocab 'LinkedInFormQuestion.cdm.json/LinkedInFormQuestion' with Property 'LinkedInFormQuestionId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="LinkedInFormSubmissionID"/> to Vocab 'LinkedInLeadGenFormSubmission.cdm.json/LinkedInLeadGenFormSubmission' with Property 'LinkedInFormSubmissionId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey AnswerFormat { get; private set; }
        public VocabularyKey AnswerId { get; private set; }
        public VocabularyKey AnswerText { get; private set; }
        public VocabularyKey LinkedInFormAnswerId { get; private set; }
        public VocabularyKey LinkedInQuestionID { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}