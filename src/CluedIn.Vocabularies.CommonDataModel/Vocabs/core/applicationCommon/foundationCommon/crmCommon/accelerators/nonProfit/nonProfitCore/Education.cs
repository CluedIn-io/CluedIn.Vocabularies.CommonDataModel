using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class EducationVocabulary : SimpleVocabulary
    {
        public EducationVocabulary()
        {
            VocabularyName = "Education";
            KeyPrefix = "commonDataModel.education";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Education;

            AddGroup("Education Details for NonProfitCore", group =>
            {
			    ClassYear = group.Add(new VocabularyKey(nameof(ClassYear), "Class Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CompletionYear = group.Add(new VocabularyKey(nameof(CompletionYear), "Completion Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DegreeOrCertificate = group.Add(new VocabularyKey(nameof(DegreeOrCertificate), "Degree Or Certificate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EducationId = group.Add(new VocabularyKey(nameof(EducationId), "Education", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FieldOfStudy1 = group.Add(new VocabularyKey(nameof(FieldOfStudy1), "Field of Study #1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FieldOfStudy2 = group.Add(new VocabularyKey(nameof(FieldOfStudy2), "Field of Study #2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstYearAttended = group.Add(new VocabularyKey(nameof(FirstYearAttended), "First Year Attended", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Grade = group.Add(new VocabularyKey(nameof(Grade), "Grade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastYearAttended = group.Add(new VocabularyKey(nameof(LastYearAttended), "Last Year Attended", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="DepartmentOrCollegeId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="InstitutionId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="EducationContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ClassYear { get; private set; }
        public VocabularyKey CompletionYear { get; private set; }
        public VocabularyKey DegreeOrCertificate { get; private set; }
        public VocabularyKey EducationId { get; private set; }
        public VocabularyKey FieldOfStudy1 { get; private set; }
        public VocabularyKey FieldOfStudy2 { get; private set; }
        public VocabularyKey FirstYearAttended { get; private set; }
        public VocabularyKey Grade { get; private set; }
        public VocabularyKey LastYearAttended { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}