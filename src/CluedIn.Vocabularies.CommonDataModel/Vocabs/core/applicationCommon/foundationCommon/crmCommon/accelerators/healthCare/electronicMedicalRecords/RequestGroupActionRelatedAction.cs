using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RequestGroupActionRelatedActionVocabulary : SimpleVocabulary
    {
        public RequestGroupActionRelatedActionVocabulary()
        {
            VocabularyName = "Request Group Action Related Action";
            KeyPrefix = "commonDataModel.requestgroupactionrelatedaction";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RequestGroupActionRelatedAction;

            AddGroup("RequestGroupActionRelatedAction Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedActionNumber = group.Add(new VocabularyKey(nameof(RelatedActionNumber), "Related Action Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedActionOffsetDuration = group.Add(new VocabularyKey(nameof(RelatedActionOffsetDuration), "Offset Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RelatedActionOffsetRangeHigh = group.Add(new VocabularyKey(nameof(RelatedActionOffsetRangeHigh), "Offset Duration High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RelatedActionOffsetRangeLow = group.Add(new VocabularyKey(nameof(RelatedActionOffsetRangeLow), "Offset Duration Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RelatedActionOffsetType = group.Add(new VocabularyKey(nameof(RelatedActionOffsetType), "Offset Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedActionRelationship = group.Add(new VocabularyKey(nameof(RelatedActionRelationship), "Related Action Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupActionRelatedActionId = group.Add(new VocabularyKey(nameof(RequestGroupActionRelatedActionId), "Request Group Action Related Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="RequestGroupActionId"/> to Vocab 'RequestGroupAction.cdm.json/RequestGroupAction' with Property 'RequestGroupActionId'
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
        public VocabularyKey RelatedActionNumber { get; private set; }
        public VocabularyKey RelatedActionOffsetDuration { get; private set; }
        public VocabularyKey RelatedActionOffsetRangeHigh { get; private set; }
        public VocabularyKey RelatedActionOffsetRangeLow { get; private set; }
        public VocabularyKey RelatedActionOffsetType { get; private set; }
        public VocabularyKey RelatedActionRelationship { get; private set; }
        public VocabularyKey RequestGroupActionRelatedActionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}