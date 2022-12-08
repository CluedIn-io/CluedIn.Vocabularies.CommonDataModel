using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.HigherEducation
{
    public class GrantApplicantVocabulary : SimpleVocabulary
    {
        public GrantApplicantVocabulary()
        {
            VocabularyName = "Grant Applicant";
            KeyPrefix = "commonDataModel.grantapplicant.highereducation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.GrantApplicant;

            AddGroup("GrantApplicant Details for HigherEducation", group =>
            {
			    GrantApplicantId = group.Add(new VocabularyKey(nameof(GrantApplicantId), "Grant Applicant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApplicationStateCode = group.Add(new VocabularyKey(nameof(ApplicationStateCode), "Application State Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OfferAcceptedDate = group.Add(new VocabularyKey(nameof(OfferAcceptedDate), "Offer Accepted Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OfferDeadlineDate = group.Add(new VocabularyKey(nameof(OfferDeadlineDate), "Offer Deadline Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OfferMadeDate = group.Add(new VocabularyKey(nameof(OfferMadeDate), "Offer Made Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QualificationDescription = group.Add(new VocabularyKey(nameof(QualificationDescription), "Qualification Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubmissionDate = group.Add(new VocabularyKey(nameof(SubmissionDate), "Submission Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    DeprecatedStageId = group.Add(new VocabularyKey(nameof(DeprecatedStageId), "(Deprecated) Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeprecatedTraversedPath = group.Add(new VocabularyKey(nameof(DeprecatedTraversedPath), "(Deprecated) Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="BusinessPartnerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ApplicantId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="GrantId"/> to Vocab 'Grant.cdm.json/Grant' with Property 'GrantId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="GrantApplicantId"/> from Vocab 'GrantApplicationBusinessProcessFlow.cdm.json/GrantApplicationBusinessProcessFlow' with Property 'Mshied_GrantapplicantId'
            #endregion
        }

        public VocabularyKey GrantApplicantId { get; private set; }
        public VocabularyKey ApplicationStateCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OfferAcceptedDate { get; private set; }
        public VocabularyKey OfferDeadlineDate { get; private set; }
        public VocabularyKey OfferMadeDate { get; private set; }
        public VocabularyKey QualificationDescription { get; private set; }
        public VocabularyKey SubmissionDate { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey DeprecatedStageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey DeprecatedTraversedPath { get; private set; }
    }
}