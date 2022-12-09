using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RequestGroupActionDocumentationVocabulary : SimpleVocabulary
    {
        public RequestGroupActionDocumentationVocabulary()
        {
            VocabularyName = "Request Group Action Documentation";
            KeyPrefix = "commonDataModel.requestgroupactiondocumentation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RequestGroupActionDocumentation;

            AddGroup("RequestGroupActionDocumentation Details for ElectronicMedicalRecords", group =>
            {
			    DocumentationCitation = group.Add(new VocabularyKey(nameof(DocumentationCitation), "Documentation Citation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentationDisplay = group.Add(new VocabularyKey(nameof(DocumentationDisplay), "Documentation Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentationType = group.Add(new VocabularyKey(nameof(DocumentationType), "Documentation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentationUrl = group.Add(new VocabularyKey(nameof(DocumentationUrl), "Documentation Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupActionDocumentId = group.Add(new VocabularyKey(nameof(RequestGroupActionDocumentId), "Request Group Action Document", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Resource = group.Add(new VocabularyKey(nameof(Resource), "Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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

        public VocabularyKey DocumentationCitation { get; private set; }
        public VocabularyKey DocumentationDisplay { get; private set; }
        public VocabularyKey DocumentationType { get; private set; }
        public VocabularyKey DocumentationUrl { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestGroupActionDocumentId { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}