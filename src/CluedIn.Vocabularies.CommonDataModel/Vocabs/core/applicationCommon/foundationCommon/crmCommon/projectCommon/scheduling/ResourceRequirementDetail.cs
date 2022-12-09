using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ResourceRequirementDetailVocabulary : SimpleVocabulary
    {
        public ResourceRequirementDetailVocabulary()
        {
            VocabularyName = "Resource Requirement Detail";
            KeyPrefix = "commonDataModel.resourcerequirementdetail";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ResourceRequirementDetail;

            AddGroup("ResourceRequirementDetail Details for Scheduling", group =>
            {
			    ResourceRequirementDetailId = group.Add(new VocabularyKey(nameof(ResourceRequirementDetailId), "Resource Requirement Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    From = group.Add(new VocabularyKey(nameof(From), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Hours = group.Add(new VocabularyKey(nameof(Hours), "Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ResourceRequirementId"/> to Vocab 'ResourceRequirement.cdm.json/ResourceRequirement' with Property 'ResourceRequirementId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey Duration { get; private set; }
        public VocabularyKey From { get; private set; }
        public VocabularyKey Hours { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ResourceRequirementDetailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey To { get; private set; }
    }
}