using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitCore
{
    public class BenefitRecipientVocabulary : SimpleVocabulary
    {
        public BenefitRecipientVocabulary()
        {
            VocabularyName = "Benefit Recipient";
            KeyPrefix = "commonDataModel.benefitrecipient.nonprofitcore";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BenefitRecipient;

            AddGroup("BenefitRecipient Details for NonProfitCore", group =>
            {
			    BenefitRecipientId = group.Add(new VocabularyKey(nameof(BenefitRecipientId), "Benefit Recipient", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BenefitRecipientType = group.Add(new VocabularyKey(nameof(BenefitRecipientType), "Benefit Recipient Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="BeneficiaryId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="BeneficiaryId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
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
            ///Property <see cref="ParentBenefitRecipientId"/> to Vocab 'BenefitRecipient.cdm.json/BenefitRecipient' with Property 'BenefitRecipientId'
            ///Property <see cref="ResourceCatalogId"/> to Vocab 'ResourceCatalog.cdm.json/ResourceCatalog' with Property 'ResourceCatalogId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BenefitRecipientId"/> from Vocab 'BenefitRecipient.cdm.json/BenefitRecipient' with Property 'ParentBenefitRecipientId'
            #endregion
        }

        public VocabularyKey BenefitRecipientId { get; private set; }
        public VocabularyKey BenefitRecipientType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}