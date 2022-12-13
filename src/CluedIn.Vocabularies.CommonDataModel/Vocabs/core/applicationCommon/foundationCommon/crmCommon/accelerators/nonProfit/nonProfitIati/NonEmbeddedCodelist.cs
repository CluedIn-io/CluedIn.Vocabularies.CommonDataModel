using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class NonEmbeddedCodelistVocabulary : SimpleVocabulary
    {
        public NonEmbeddedCodelistVocabulary()
        {
            VocabularyName = "Non Embedded Codelist";
            KeyPrefix = "commonDataModel.nonembeddedcodelist";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.NonEmbeddedCodelist;

            AddGroup("NonEmbeddedCodelist Details for NonProfitIati", group =>
            {
                Category = group.Add(new VocabularyKey(nameof(Category), "Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CodelistType = group.Add(new VocabularyKey(nameof(CodelistType), "Codelist Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonEmbeddedCodelistId = group.Add(new VocabularyKey(nameof(NonEmbeddedCodelistId), "Non Embedded Codelist", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonEmbeddedCodelistVocabularyId = group.Add(new VocabularyKey(nameof(NonEmbeddedCodelistVocabularyId), "Vocabulary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
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
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Account.cdm.json/Account' with Property 'DefaultLanguage'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Account.cdm.json/Account' with Property 'OrganizationType'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'AidType.cdm.json/AidType' with Property 'AidType'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Condition.cdm.json/Condition' with Property 'TypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DeliveryFrameworkContact.cdm.json/DeliveryFrameworkContact' with Property 'ContactType'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DeliveryFrameworkDescription.cdm.json/DeliveryFrameworkDescription' with Property 'TypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DocumentCountry.cdm.json/DocumentCountry' with Property 'CountryId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DocumentLanguage.cdm.json/DocumentLanguage' with Property 'LanguageId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DocumentLink.cdm.json/DocumentLink' with Property 'FileFormat'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Expenditure.cdm.json/Expenditure' with Property 'DisbursementChannel'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Expenditure.cdm.json/Expenditure' with Property 'FinanceType'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Expenditure.cdm.json/Expenditure' with Property 'FlowType'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Expenditure.cdm.json/Expenditure' with Property 'RecipientCountryId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Expenditure.cdm.json/Expenditure' with Property 'RecipientRegionId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Expenditure.cdm.json/Expenditure' with Property 'TiedStatusId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'HumanitarianScope.cdm.json/HumanitarianScope' with Property 'CodeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'HumanitarianScope.cdm.json/HumanitarianScope' with Property 'TypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Identifier.cdm.json/Identifier' with Property 'TypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'IndicatorReference.cdm.json/IndicatorReference' with Property 'IndicatorCodeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Location.cdm.json/Location' with Property 'CodeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Location.cdm.json/Location' with Property 'ExactnessId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Location.cdm.json/Location' with Property 'FeatureDesignationId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Location.cdm.json/Location' with Property 'LocationClassId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Location.cdm.json/Location' with Property 'ReachId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'NarrativeTranslation.cdm.json/NarrativeTranslation' with Property 'LanguageId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'ParticipatingOrganization.cdm.json/ParticipatingOrganization' with Property 'CrsChannelId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'PolicyMarker.cdm.json/PolicyMarker' with Property 'CodeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'PolicyMarker.cdm.json/PolicyMarker' with Property 'SignificanceId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'RecipientCountry.cdm.json/RecipientCountry' with Property 'CountryId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'RecipientRegion.cdm.json/RecipientRegion' with Property 'RegionId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'ResultReference.cdm.json/ResultReference' with Property 'ResultCode'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Sector.cdm.json/Sector' with Property 'CodeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Tag.cdm.json/Tag' with Property 'CodeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Budget.cdm.json/Budget' with Property 'BudgetIdentifier'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Budget.cdm.json/Budget' with Property 'RecipientCountryId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Budget.cdm.json/Budget' with Property 'RecipientRegionId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'BudgetNotProvidedId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'CollaborationTypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'LoanRepaymentPeriodId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'LoanRepaymentTypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DefaultFinanceTypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DefaultFlowTypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DefaultLanguageId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'ScopeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Disbursement.cdm.json/Disbursement' with Property 'DisbursementChannel'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Disbursement.cdm.json/Disbursement' with Property 'FinanceTypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Disbursement.cdm.json/Disbursement' with Property 'FlowTypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Disbursement.cdm.json/Disbursement' with Property 'RecipientCountryId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Disbursement.cdm.json/Disbursement' with Property 'RecipientRegionId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Disbursement.cdm.json/Disbursement' with Property 'TiedStatusId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'DisbursementChannelId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'FinanceTypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'FlowTypeId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'RecipientCountryId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'RecipientRegionId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'TiedStatusId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Indicator.cdm.json/Indicator' with Property 'IndicatorMeasureId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'DisbursementChannel'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'FinanceType'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'FlowType'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'RecipientCountryId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'RecipientRegionId'
            ///Property <see cref="NonEmbeddedCodelistId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'TiedStatusId'
            ///Property <see cref="NonEmbeddedCodelistVocabularyId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'BudgetIdentifierVocabularyId'
            #endregion
        }

        public VocabularyKey Category { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey CodelistType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NonEmbeddedCodelistId { get; private set; }
        public VocabularyKey NonEmbeddedCodelistVocabularyId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}