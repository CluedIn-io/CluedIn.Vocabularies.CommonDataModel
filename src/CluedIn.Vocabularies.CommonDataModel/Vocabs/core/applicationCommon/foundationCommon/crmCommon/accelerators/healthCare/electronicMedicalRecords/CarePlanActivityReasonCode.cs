using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class CarePlanActivityReasonCodeVocabulary : SimpleVocabulary
    {
        public CarePlanActivityReasonCodeVocabulary()
        {
            VocabularyName = "Care Plan Activity Reason Code";
            KeyPrefix = "commonDataModel.careplanactivityreasoncode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CarePlanActivityReasonCode;

            AddGroup("CarePlanActivityReasonCode Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanActivityReasonCodeId = group.Add(new VocabularyKey(nameof(CarePlanActivityReasonCodeId), "Care Plan Activity Reason Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    System = group.Add(new VocabularyKey(nameof(System), "System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CarePlanActivityId"/> to Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'CarePlanActivityId'
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

        public VocabularyKey CarePlanActivityReasonCodeId { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Display { get; private set; }
        public VocabularyKey System { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}