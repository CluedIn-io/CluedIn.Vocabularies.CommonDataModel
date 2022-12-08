using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class ObservationRelatedResourceVocabulary : SimpleVocabulary
    {
        public ObservationRelatedResourceVocabulary()
        {
            VocabularyName = "Observation Related Resource";
            KeyPrefix = "commonDataModel.observationrelatedresource.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ObservationRelatedResource;

            AddGroup("ObservationRelatedResource Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationRelatedResourceId = group.Add(new VocabularyKey(nameof(ObservationRelatedResourceId), "Observation Related Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObsRelatedResourceTargetType = group.Add(new VocabularyKey(nameof(ObsRelatedResourceTargetType), "Target Resource Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObsRelatedResourceType = group.Add(new VocabularyKey(nameof(ObsRelatedResourceType), "Related Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ObsRelatedResourceQuestionaireResponseId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ObsRelatedResourceSequenceIdentfierId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ObsRelatedResourceObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
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

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObservationRelatedResourceId { get; private set; }
        public VocabularyKey ObsRelatedResourceTargetType { get; private set; }
        public VocabularyKey ObsRelatedResourceType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}