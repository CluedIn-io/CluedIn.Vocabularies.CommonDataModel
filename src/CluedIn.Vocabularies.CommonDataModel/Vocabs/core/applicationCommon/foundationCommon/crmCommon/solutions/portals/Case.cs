using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class CaseVocabulary : SimpleVocabulary
    {
        public CaseVocabulary()
        {
            VocabularyName = "Case";
            KeyPrefix = "commonDataModel.case.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Case;

            AddGroup("Case Details for Portals", group =>
            {
			    AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByIPAddress = group.Add(new VocabularyKey(nameof(AdxModifiedByIPAddress), "Modified By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByUsername = group.Add(new VocabularyKey(nameof(AdxModifiedByUsername), "Modified By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PublishToWeb = group.Add(new VocabularyKey(nameof(PublishToWeb), "Publish to Web", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Resolution = group.Add(new VocabularyKey(nameof(Resolution), "Resolution", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResolutionDate = group.Add(new VocabularyKey(nameof(ResolutionDate), "Resolution Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StepsToReproduce = group.Add(new VocabularyKey(nameof(StepsToReproduce), "Steps to Reproduce", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Partnerid"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="IncidentId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ChildIncidentCount.cdm.json/ChildIncidentCount' with Property 'ParentCaseId'
            ///Property <see cref="ContractDetailId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ContractLine.cdm.json/ContractLine' with Property 'ContractDetailId'
            ///Property <see cref="ContractId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Contract.cdm.json/Contract' with Property 'ContractId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="EntitlementId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Entitlement.cdm.json/Entitlement' with Property 'EntitlementId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="KbArticleId"/> to Vocab '/core/applicationCommon/Article.cdm.json/Article' with Property 'KbArticleId'
            ///Property <see cref="ProductId"/> to Vocab '/core/applicationCommon/foundationCommon/Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ExistingCase"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="ResponsibleContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SocialProfileId"/> to Vocab '/core/applicationCommon/SocialProfile.cdm.json/SocialProfile' with Property 'SocialProfileId'
            ///Property <see cref="MasterId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="ParentCaseId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ResolveByKPIId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'SLAKPIInstanceId'
            ///Property <see cref="FirstResponseByKPIId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'SLAKPIInstanceId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="PartnerContact"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ExistingCase"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="MasterId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="ParentCaseId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Contact"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="KnowledgeArticle"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ResponsibleContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="IncidentId"/> from Vocab 'Case.cdm.json/Case' with Property 'ExistingCase'
            ///Property <see cref="IncidentId"/> from Vocab 'Case.cdm.json/Case' with Property 'MasterId'
            ///Property <see cref="IncidentId"/> from Vocab 'Case.cdm.json/Case' with Property 'ParentCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/financialServices/banking/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'ExistingCase'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'MasterId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'ParentCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/IncidentKnowledgeBaseRecord.cdm.json/IncidentKnowledgeBaseRecord' with Property 'IncidentId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/KnowledgeArticleIncident.cdm.json/KnowledgeArticleIncident' with Property 'IncidentId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            ///Property <see cref="IncidentId"/> from Vocab 'InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="CaseDeflectionId"/> from Vocab 'InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey AdxModifiedByIPAddress { get; private set; }
        public VocabularyKey AdxModifiedByUsername { get; private set; }
        public VocabularyKey PublishToWeb { get; private set; }
        public VocabularyKey Resolution { get; private set; }
        public VocabularyKey ResolutionDate { get; private set; }
        public VocabularyKey StepsToReproduce { get; private set; }
    }
}