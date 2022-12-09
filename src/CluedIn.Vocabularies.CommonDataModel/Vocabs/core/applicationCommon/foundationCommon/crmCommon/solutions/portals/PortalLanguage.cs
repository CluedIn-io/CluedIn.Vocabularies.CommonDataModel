using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PortalLanguageVocabulary : SimpleVocabulary
    {
        public PortalLanguageVocabulary()
        {
            VocabularyName = "Portal Language";
            KeyPrefix = "commonDataModel.portallanguage";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PortalLanguage;

            AddGroup("PortalLanguage Details for Portals", group =>
            {
			    PortalLanguageId = group.Add(new VocabularyKey(nameof(PortalLanguageId), "Portal Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LanguageCode = group.Add(new VocabularyKey(nameof(LanguageCode), "Language Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SystemLanguage = group.Add(new VocabularyKey(nameof(SystemLanguage), "System Language", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PortalDisplayName = group.Add(new VocabularyKey(nameof(PortalDisplayName), "Portal Display Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Lcid = group.Add(new VocabularyKey(nameof(Lcid), "LCID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
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
            ///Property <see cref="PortalLanguageId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'PreferredLanguage'
            ///Property <see cref="PortalLanguageId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'PreferredLanguage'
            ///Property <see cref="PortalLanguageId"/> from Vocab 'WebsiteLanguage.cdm.json/WebsiteLanguage' with Property 'PortalLanguageId'
            #endregion
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageCode { get; private set; }
        public VocabularyKey Lcid { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PortalDisplayName { get; private set; }
        public VocabularyKey PortalLanguageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SystemLanguage { get; private set; }
    }
}