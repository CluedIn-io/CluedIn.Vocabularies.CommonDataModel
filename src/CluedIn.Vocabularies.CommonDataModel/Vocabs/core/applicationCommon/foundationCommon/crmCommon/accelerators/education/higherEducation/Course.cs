using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CourseVocabulary : SimpleVocabulary
    {
        public CourseVocabulary()
        {
            VocabularyName = "Course";
            KeyPrefix = "commonDataModel.course";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Course;

            AddGroup("Course Details for HigherEducation", group =>
            {
			    CourseId = group.Add(new VocabularyKey(nameof(CourseId), "Course", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Course Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AcademicLevel = group.Add(new VocabularyKey(nameof(AcademicLevel), "Academic Level", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CourseNumber = group.Add(new VocabularyKey(nameof(CourseNumber), "Course Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Prerequisites = group.Add(new VocabularyKey(nameof(Prerequisites), "Prerequisites", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Section = group.Add(new VocabularyKey(nameof(Section), "Section", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Subject = group.Add(new VocabularyKey(nameof(Subject), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CampusId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="StudentId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="InstructorId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="AcademicPeriodId"/> to Vocab 'AcademicPeriod.cdm.json/AcademicPeriod' with Property 'AcademicPeriodId'
            ///Property <see cref="AcademicPeriodDetailsId"/> to Vocab 'AcademicPeriodDetail.cdm.json/AcademicPeriodDetail' with Property 'AcademicPeriodDetailsId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CourseId"/> to Vocab 'Course.cdm.json/Course' with Property 'CourseId'
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
            ///Property <see cref="CourseId"/> from Vocab 'CourseHistory.cdm.json/CourseHistory' with Property 'CourseId'
            ///Property <see cref="CourseId"/> from Vocab 'CourseSection.cdm.json/CourseSection' with Property 'CourseId'
            ///Property <see cref="CourseSectionId"/> from Vocab 'CourseHistory.cdm.json/CourseHistory' with Property 'CourseSectionId'
            #endregion
        }

        public VocabularyKey AcademicLevel { get; private set; }
        public VocabularyKey CourseId { get; private set; }
        public VocabularyKey CourseNumber { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Prerequisites { get; private set; }
        public VocabularyKey Section { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Subject { get; private set; }
    }
}