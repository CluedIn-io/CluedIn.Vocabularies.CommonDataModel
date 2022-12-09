using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class MeasurementItemRelationshipVocabulary : SimpleVocabulary
    {
        public MeasurementItemRelationshipVocabulary()
        {
            VocabularyName = "Measurement Item Relationship";
            KeyPrefix = "commonDataModel.measurementitemrelationship";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.MeasurementItemRelationship;

            AddGroup("MeasurementItemRelationship Details for NonProfitMeasurement", group =>
            {
			    MeasurementItemRelationshipId = group.Add(new VocabularyKey(nameof(MeasurementItemRelationshipId), "Measurement Item Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Proportion = group.Add(new VocabularyKey(nameof(Proportion), "Proportion", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RelationshipType = group.Add(new VocabularyKey(nameof(RelationshipType), "Relationship Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), "Valid From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), "Valid To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="RelationshipFromId"/> to Vocab 'MeasurementItem.cdm.json/MeasurementItem' with Property 'MeasurementItemId'
            ///Property <see cref="RelationshipToId"/> to Vocab 'MeasurementItem.cdm.json/MeasurementItem' with Property 'MeasurementItemId'
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

        public VocabularyKey MeasurementItemRelationshipId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Proportion { get; private set; }
        public VocabularyKey RelationshipType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
    }
}