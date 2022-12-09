using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CourseHistoryVocabulary : SimpleVocabulary
    {
        public CourseHistoryVocabulary()
        {
            VocabularyName = "Course History";
            KeyPrefix = "commonDataModel.coursehistory";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CourseHistory;

            AddGroup("CourseHistory Details for HigherEducation", group =>
            {
			    CourseHistoryId = group.Add(new VocabularyKey(nameof(CourseHistoryId), "Course History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Course History Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContinuingEducation = group.Add(new VocabularyKey(nameof(ContinuingEducation), "Continuing Education", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreditsAttempted = group.Add(new VocabularyKey(nameof(CreditsAttempted), "Credits Attempted", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CreditsEarrned = group.Add(new VocabularyKey(nameof(CreditsEarrned), "Credits Earrned", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    GradePoints = group.Add(new VocabularyKey(nameof(GradePoints), "Grade Points", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    LastDateofAttendance = group.Add(new VocabularyKey(nameof(LastDateofAttendance), "Last Date of Attendance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LetterGrade = group.Add(new VocabularyKey(nameof(LetterGrade), "Letter Grade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MidTermLetterGrade = group.Add(new VocabularyKey(nameof(MidTermLetterGrade), "Mid Term Letter Grade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MidTermNumericGrade = group.Add(new VocabularyKey(nameof(MidTermNumericGrade), "Mid Term Numeric Grade", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="StudentId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="AcademicPeriodDetailsId"/> to Vocab 'AcademicPeriodDetail.cdm.json/AcademicPeriodDetail' with Property 'AcademicPeriodDetailsId'
            ///Property <see cref="CourseId"/> to Vocab 'Course.cdm.json/Course' with Property 'CourseId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CourseSectionId"/> to Vocab 'CourseSection.cdm.json/CourseSection' with Property 'CourseSectionId'
            ///Property <see cref="RegistrationStatusId"/> to Vocab 'RegistrationStatus.cdm.json/RegistrationStatus' with Property 'RegistrationStatusId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ContinuingEducation { get; private set; }
        public VocabularyKey CourseHistoryId { get; private set; }
        public VocabularyKey CreditsAttempted { get; private set; }
        public VocabularyKey CreditsEarrned { get; private set; }
        public VocabularyKey GradePoints { get; private set; }
        public VocabularyKey LastDateofAttendance { get; private set; }
        public VocabularyKey LetterGrade { get; private set; }
        public VocabularyKey MidTermLetterGrade { get; private set; }
        public VocabularyKey MidTermNumericGrade { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}