using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class AcademicPeriodVocabulary : SimpleVocabulary
    {
        public AcademicPeriodVocabulary()
        {
            VocabularyName = "Academic Period";
            KeyPrefix = "commonDataModel.academicperiod";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.AcademicPeriod;

            AddGroup("AcademicPeriod Details for HigherEducation", group =>
            {
			    AcademicPeriodId = group.Add(new VocabularyKey(nameof(AcademicPeriodId), "Academic Period", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Academic Period Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="StudentId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
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
            ///Property <see cref="AcademicPeriodId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'CurrentAcademicPeriodId'
            ///Property <see cref="AcademicPeriodId"/> from Vocab 'AcademicPeriodDetail.cdm.json/AcademicPeriodDetail' with Property 'AcademicPeriodID'
            ///Property <see cref="AcademicPeriodId"/> from Vocab 'CourseSection.cdm.json/CourseSection' with Property 'AcademicPeriodId'
            ///Property <see cref="AcademicPeriodId"/> from Vocab 'Scholarship.cdm.json/Scholarship' with Property 'AcademicPeriodId'
            ///Property <see cref="AcademicPeriodDetailsId"/> from Vocab 'CourseHistory.cdm.json/CourseHistory' with Property 'AcademicPeriodDetailsId'
            #endregion
        }

        public VocabularyKey AcademicPeriodId { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}