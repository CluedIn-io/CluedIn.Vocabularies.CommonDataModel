using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ExtraCurricularParticipantVocabulary : SimpleVocabulary
    {
        public ExtraCurricularParticipantVocabulary()
        {
            VocabularyName = "Extra Curricular Participant";
            KeyPrefix = "commonDataModel.extracurricularparticipant";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ExtraCurricularParticipant;

            AddGroup("ExtraCurricularParticipant Details for HigherEducation", group =>
            {
			    ExtracurricularParticipantId = group.Add(new VocabularyKey(nameof(ExtracurricularParticipantId), "Extra Curricular Participant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Student Extra Curricular Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AwardsReceived = group.Add(new VocabularyKey(nameof(AwardsReceived), "Awards Received", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PositionsHeld = group.Add(new VocabularyKey(nameof(PositionsHeld), "Positions Held", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Source = group.Add(new VocabularyKey(nameof(Source), "Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    State = group.Add(new VocabularyKey(nameof(State), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ExtraCurricularActivityId"/> to Vocab 'ExtraCurricularActivity.cdm.json/ExtraCurricularActivity' with Property 'ExtracurricularActivitiesId'
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
            
            #endregion
        }

        public VocabularyKey AwardsReceived { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ExtracurricularParticipantId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PositionsHeld { get; private set; }
        public VocabularyKey Source { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}