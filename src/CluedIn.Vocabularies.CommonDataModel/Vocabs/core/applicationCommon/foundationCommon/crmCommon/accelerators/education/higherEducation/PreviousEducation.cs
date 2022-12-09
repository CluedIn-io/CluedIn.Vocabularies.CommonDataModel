using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PreviousEducationVocabulary : SimpleVocabulary
    {
        public PreviousEducationVocabulary()
        {
            VocabularyName = "Previous Education";
            KeyPrefix = "commonDataModel.previouseducation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PreviousEducation;

            AddGroup("PreviousEducation Details for HigherEducation", group =>
            {
			    PreviousEducationId = group.Add(new VocabularyKey(nameof(PreviousEducationId), "Previous Education", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Previous Education Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ClassSize = group.Add(new VocabularyKey(nameof(ClassSize), "Class Size", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DateofEnrollment = group.Add(new VocabularyKey(nameof(DateofEnrollment), "Date of Enrollment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GPA = group.Add(new VocabularyKey(nameof(GPA), "GPA", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Graduated = group.Add(new VocabularyKey(nameof(Graduated), "Graduated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    GraduationDate = group.Add(new VocabularyKey(nameof(GraduationDate), "Graduation Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastDateofAttendance = group.Add(new VocabularyKey(nameof(LastDateofAttendance), "Last Date of Attendance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Major = group.Add(new VocabularyKey(nameof(Major), "Major", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Rank = group.Add(new VocabularyKey(nameof(Rank), "Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="SchoolNameId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="StudentId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="EducationLevelId"/> to Vocab 'EducationLevel.cdm.json/EducationLevel' with Property 'EducationLevelId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="DegreeId"/> to Vocab 'Program.cdm.json/Program' with Property 'ProgramId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ClassSize { get; private set; }
        public VocabularyKey DateofEnrollment { get; private set; }
        public VocabularyKey GPA { get; private set; }
        public VocabularyKey Graduated { get; private set; }
        public VocabularyKey GraduationDate { get; private set; }
        public VocabularyKey LastDateofAttendance { get; private set; }
        public VocabularyKey Major { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PreviousEducationId { get; private set; }
        public VocabularyKey Rank { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}