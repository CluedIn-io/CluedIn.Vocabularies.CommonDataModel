using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class PractitionerRoleAvailableTimeVocabulary : SimpleVocabulary
    {
        public PractitionerRoleAvailableTimeVocabulary()
        {
            VocabularyName = "Practitioner Role Available Time";
            KeyPrefix = "commonDataModel.practitionerroleavailabletime.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PractitionerRoleAvailableTime;

            AddGroup("PractitionerRoleAvailableTime Details for ElectronicMedicalRecords", group =>
            {
			    AllDay = group.Add(new VocabularyKey(nameof(AllDay), "All day", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AvailableEndTime = group.Add(new VocabularyKey(nameof(AvailableEndTime), "Available End Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AvailableStartTime = group.Add(new VocabularyKey(nameof(AvailableStartTime), "Available Start Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DaysOfWeek = group.Add(new VocabularyKey(nameof(DaysOfWeek), "Days of week", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PractitionerRoleAvailableTimeId = group.Add(new VocabularyKey(nameof(PractitionerRoleAvailableTimeId), "Practitioner Role Available Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="PractitionerRoleId"/> to Vocab 'PractitionerRole.cdm.json/PractitionerRole' with Property 'PractitionerRoleId'
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

        public VocabularyKey AllDay { get; private set; }
        public VocabularyKey AvailableEndTime { get; private set; }
        public VocabularyKey AvailableStartTime { get; private set; }
        public VocabularyKey DaysOfWeek { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PractitionerRoleAvailableTimeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}