using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class NarrativeTranslationVocabulary : SimpleVocabulary
    {
        public NarrativeTranslationVocabulary()
        {
            VocabularyName = "Narrative Translation";
            KeyPrefix = "commonDataModel.narrativetranslation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.NarrativeTranslation;

            AddGroup("NarrativeTranslation Details for NonProfitIati", group =>
            {
                Attribute = group.Add(new VocabularyKey(nameof(Attribute), "Attribute", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityName = group.Add(new VocabularyKey(nameof(EntityName), "Entity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NarrativeTranslationId = group.Add(new VocabularyKey(nameof(NarrativeTranslationId), "Narrative Translation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Translation = group.Add(new VocabularyKey(nameof(Translation), "Translation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ConditionId"/> to Vocab 'Condition.cdm.json/Condition' with Property 'ConditionId'
            ///Property <see cref="DeliveryFrameworkDescriptionId"/> to Vocab 'DeliveryFrameworkDescription.cdm.json/DeliveryFrameworkDescription' with Property 'DeliveryFrameworkDescriptionId'
            ///Property <see cref="DocuemntCountryId"/> to Vocab 'DocumentCountry.cdm.json/DocumentCountry' with Property 'DocumentCountryId'
            ///Property <see cref="DocumentLinkId"/> to Vocab 'DocumentLink.cdm.json/DocumentLink' with Property 'DocumentLinkId'
            ///Property <see cref="ExpenditureId"/> to Vocab 'Expenditure.cdm.json/Expenditure' with Property 'ExpenditureId'
            ///Property <see cref="HumanitarianScope"/> to Vocab 'HumanitarianScope.cdm.json/HumanitarianScope' with Property 'HumanitarianScopeId'
            ///Property <see cref="LocationId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
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
            ///Property <see cref="BudgetId"/> to Vocab 'Budget.cdm.json/Budget' with Property 'BudgetId'
            ///Property <see cref="DeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DisbursementId"/> to Vocab 'Disbursement.cdm.json/Disbursement' with Property 'DisbursementId'
            ///Property <see cref="DonorCommitment"/> to Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'DonorCommitmentId'
            ///Property <see cref="IndicatorId"/> to Vocab 'Indicator.cdm.json/Indicator' with Property 'IndicatorId'
            ///Property <see cref="IndicatorValue"/> to Vocab 'IndicatorValue.cdm.json/IndicatorValue' with Property 'IndicatorValueId'
            ///Property <see cref="LanguageId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="PolicyMaker"/> to Vocab 'PolicyMarker.cdm.json/PolicyMarker' with Property 'PolicyMarkerId'
            ///Property <see cref="RecipientCountry"/> to Vocab 'RecipientCountry.cdm.json/RecipientCountry' with Property 'Msiati_RecipientCountryId'
            ///Property <see cref="RecipientRegion"/> to Vocab 'RecipientRegion.cdm.json/RecipientRegion' with Property 'RecipientRegionId'
            ///Property <see cref="ResultId"/> to Vocab 'Result.cdm.json/Result' with Property 'ResultId'
            ///Property <see cref="SectorId"/> to Vocab 'Sector.cdm.json/Sector' with Property 'SectorId'
            ///Property <see cref="TagId"/> to Vocab 'Tag.cdm.json/Tag' with Property 'TagId'
            ///Property <see cref="TransactionId"/> to Vocab 'Transaction.cdm.json/Transaction' with Property 'TransactionId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey Attribute { get; private set; }
        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NarrativeTranslationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Translation { get; private set; }
    }
}