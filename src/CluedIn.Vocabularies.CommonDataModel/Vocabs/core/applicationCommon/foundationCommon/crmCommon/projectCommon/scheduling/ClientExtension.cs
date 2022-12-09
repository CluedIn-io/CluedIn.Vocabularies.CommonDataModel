using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ClientExtensionVocabulary : SimpleVocabulary
    {
        public ClientExtensionVocabulary()
        {
            VocabularyName = "Client Extension";
            KeyPrefix = "commonDataModel.clientextension";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ClientExtension;

            AddGroup("ClientExtension Details for Scheduling", group =>
            {
			    ClientextensionId = group.Add(new VocabularyKey(nameof(ClientextensionId), "Client Extension", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExtensionType = group.Add(new VocabularyKey(nameof(ExtensionType), "Extension Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Rank = group.Add(new VocabularyKey(nameof(Rank), "Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WebResource = group.Add(new VocabularyKey(nameof(WebResource), "Web Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ScheduleBoardSettingId"/> to Vocab 'ScheduleBoardSetting.cdm.json/ScheduleBoardSetting' with Property 'ScheduleBoardSettingId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ClientextensionId { get; private set; }
        public VocabularyKey ExtensionType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Rank { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey WebResource { get; private set; }
    }
}