using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.HigherEducation
{
    public class AcademicPeriodDetailVocabulary : SimpleVocabulary
    {
        public AcademicPeriodDetailVocabulary()
        {
            VocabularyName = "Academic Period Detail";
            KeyPrefix = "commonDataModel.academicperioddetail.highereducation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.AcademicPeriodDetail;

            AddGroup("AcademicPeriodDetail Details for HigherEducation", group =>
            {
			    AcademicPeriodDetailsId = group.Add(new VocabularyKey(nameof(AcademicPeriodDetailsId), "Academic Period Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Academic Period Detail Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AttendanceType = group.Add(new VocabularyKey(nameof(AttendanceType), "Attendance Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreditLoad = group.Add(new VocabularyKey(nameof(CreditLoad), "Credit Load", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EmployedHoursPerWeek = group.Add(new VocabularyKey(nameof(EmployedHoursPerWeek), "Employed Hours Per Week", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IsAthlete = group.Add(new VocabularyKey(nameof(IsAthlete), "Is Athlete?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsEmployed = group.Add(new VocabularyKey(nameof(IsEmployed), "Is Employed?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsInternationalStudent = group.Add(new VocabularyKey(nameof(IsInternationalStudent), "Is International Student?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ISIRonFIle = group.Add(new VocabularyKey(nameof(ISIRonFIle), "ISIR on FIle", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsTransferStudent = group.Add(new VocabularyKey(nameof(IsTransferStudent), "Is Transfer Student?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MajorCreditEarned = group.Add(new VocabularyKey(nameof(MajorCreditEarned), "Major Credit Earned", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    MajorGPA = group.Add(new VocabularyKey(nameof(MajorGPA), "Major GPA", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    MidTermDeficiency = group.Add(new VocabularyKey(nameof(MidTermDeficiency), "Mid-Term Deficiency", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TermCreditsEarned = group.Add(new VocabularyKey(nameof(TermCreditsEarned), "Term Credits Earned", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TermGPA = group.Add(new VocabularyKey(nameof(TermGPA), "Term GPA", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="StudentId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="AcademicPeriodID"/> to Vocab 'AcademicPeriod.cdm.json/AcademicPeriod' with Property 'AcademicPeriodId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="EducationLevelId"/> to Vocab 'EducationLevel.cdm.json/EducationLevel' with Property 'EducationLevelId'
            ///Property <see cref="ProgramId"/> to Vocab 'Program.cdm.json/Program' with Property 'ProgramId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="AcademicPeriodDetailsId"/> from Vocab 'CourseHistory.cdm.json/CourseHistory' with Property 'AcademicPeriodDetailsId'
            #endregion
        }

        public VocabularyKey AcademicPeriodDetailsId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AttendanceType { get; private set; }
        public VocabularyKey CreditLoad { get; private set; }
        public VocabularyKey EmployedHoursPerWeek { get; private set; }
        public VocabularyKey IsAthlete { get; private set; }
        public VocabularyKey IsEmployed { get; private set; }
        public VocabularyKey IsInternationalStudent { get; private set; }
        public VocabularyKey ISIRonFIle { get; private set; }
        public VocabularyKey IsTransferStudent { get; private set; }
        public VocabularyKey MajorCreditEarned { get; private set; }
        public VocabularyKey MajorGPA { get; private set; }
        public VocabularyKey MidTermDeficiency { get; private set; }
        public VocabularyKey TermCreditsEarned { get; private set; }
        public VocabularyKey TermGPA { get; private set; }
    }
}