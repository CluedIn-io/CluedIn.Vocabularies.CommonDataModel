using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.HigherEducation
{
    public class CourseSectionVocabulary : SimpleVocabulary
    {
        public CourseSectionVocabulary()
        {
            VocabularyName = "Course Section";
            KeyPrefix = "commonDataModel.coursesection.highereducation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CourseSection;

            AddGroup("CourseSection Details for HigherEducation", group =>
            {
			    CourseSectionId = group.Add(new VocabularyKey(nameof(CourseSectionId), "Course Section", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Course Section Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CourseDayTime = group.Add(new VocabularyKey(nameof(CourseDayTime), "Course Day/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Location = group.Add(new VocabularyKey(nameof(Location), "Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Prerequisites = group.Add(new VocabularyKey(nameof(Prerequisites), "Prerequisites", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CampusId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="InstructorId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="AcademicPeriodId"/> to Vocab 'AcademicPeriod.cdm.json/AcademicPeriod' with Property 'AcademicPeriodId'
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
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="CourseSectionId"/> from Vocab 'CourseHistory.cdm.json/CourseHistory' with Property 'CourseSectionId'
            #endregion
        }

        public VocabularyKey CourseSectionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CourseDayTime { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey Prerequisites { get; private set; }
    }
}