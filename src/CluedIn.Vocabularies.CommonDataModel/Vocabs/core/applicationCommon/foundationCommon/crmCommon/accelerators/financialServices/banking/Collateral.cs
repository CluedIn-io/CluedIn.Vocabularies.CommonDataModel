using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CollateralVocabulary : SimpleVocabulary
    {
        public CollateralVocabulary()
        {
            VocabularyName = "Collateral";
            KeyPrefix = "commonDataModel.collateral";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Collateral;

            AddGroup("Collateral Details for Banking", group =>
            {
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                CollateralId = group.Add(new VocabularyKey(nameof(CollateralId), "Collateral", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollateralType = group.Add(new VocabularyKey(nameof(CollateralType), "Collateral Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollateralValue = group.Add(new VocabularyKey(nameof(CollateralValue), "Collateral Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                CollateralValueBase = group.Add(new VocabularyKey(nameof(CollateralValueBase), "Collateral Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                Coverage = group.Add(new VocabularyKey(nameof(Coverage), "Coverage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                DateOfValuation = group.Add(new VocabularyKey(nameof(DateOfValuation), "Date of Valuation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EvaluatedBy = group.Add(new VocabularyKey(nameof(EvaluatedBy), "Evaluated by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextDateOfValuation = group.Add(new VocabularyKey(nameof(NextDateOfValuation), "Next Date of Valuation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                DeprecatedStageId = group.Add(new VocabularyKey(nameof(DeprecatedStageId), "(Deprecated) Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeprecatedTraversedPath = group.Add(new VocabularyKey(nameof(DeprecatedTraversedPath), "(Deprecated) Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
            ///Property <see cref="FinancialProductId"/> to Vocab 'FinancialProduct.cdm.json/FinancialProduct' with Property 'FinancialProductId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey CollateralId { get; private set; }
        public VocabularyKey CollateralType { get; private set; }
        public VocabularyKey CollateralValue { get; private set; }
        public VocabularyKey CollateralValueBase { get; private set; }
        public VocabularyKey Coverage { get; private set; }
        public VocabularyKey DateOfValuation { get; private set; }
        public VocabularyKey DeprecatedStageId { get; private set; }
        public VocabularyKey DeprecatedTraversedPath { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EvaluatedBy { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NextDateOfValuation { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}