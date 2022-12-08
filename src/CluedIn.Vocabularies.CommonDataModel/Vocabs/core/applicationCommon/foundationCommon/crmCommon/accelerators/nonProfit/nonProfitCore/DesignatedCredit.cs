using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitCore
{
    public class DesignatedCreditVocabulary : SimpleVocabulary
    {
        public DesignatedCreditVocabulary()
        {
            VocabularyName = "Designated Credit";
            KeyPrefix = "commonDataModel.designatedcredit.nonprofitcore";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DesignatedCredit;

            AddGroup("DesignatedCredit Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AdjustmentComment = group.Add(new VocabularyKey(nameof(AdjustmentComment), "Adjustment Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdjustmentReason = group.Add(new VocabularyKey(nameof(AdjustmentReason), "Adjustment Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdjustmentType = group.Add(new VocabularyKey(nameof(AdjustmentType), "Adjustment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ApplyToCommitmentPaymentDate = group.Add(new VocabularyKey(nameof(ApplyToCommitmentPaymentDate), "Apply To Commitment Payment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookDate = group.Add(new VocabularyKey(nameof(BookDate), "Book Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreditReason = group.Add(new VocabularyKey(nameof(CreditReason), "Credit Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreditType = group.Add(new VocabularyKey(nameof(CreditType), "Credit Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataEntryReference = group.Add(new VocabularyKey(nameof(DataEntryReference), "Data Entry Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataEntrySource = group.Add(new VocabularyKey(nameof(DataEntrySource), "Data Entry Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DesignatedCreditId = group.Add(new VocabularyKey(nameof(DesignatedCreditId), "Designated Credit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRateDate = group.Add(new VocabularyKey(nameof(ExchangeRateDate), "Exchange Rate Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsAdjusted = group.Add(new VocabularyKey(nameof(IsAdjusted), "Is Adjusted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostedDate = group.Add(new VocabularyKey(nameof(PostedDate), "Posted Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReceivedDate = group.Add(new VocabularyKey(nameof(ReceivedDate), "Received Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
            ///Property <see cref="DesignatiedCreditDesignationId"/> to Vocab 'Designation.cdm.json/Designation' with Property 'DesignationId'
            ///Property <see cref="TransactionId"/> to Vocab 'Transaction.cdm.json/Transaction' with Property 'TransactionId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AdjustmentComment { get; private set; }
        public VocabularyKey AdjustmentReason { get; private set; }
        public VocabularyKey AdjustmentType { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey ApplyToCommitmentPaymentDate { get; private set; }
        public VocabularyKey BookDate { get; private set; }
        public VocabularyKey CreditReason { get; private set; }
        public VocabularyKey CreditType { get; private set; }
        public VocabularyKey DataEntryReference { get; private set; }
        public VocabularyKey DataEntrySource { get; private set; }
        public VocabularyKey DesignatedCreditId { get; private set; }
        public VocabularyKey ExchangeRateDate { get; private set; }
        public VocabularyKey IsAdjusted { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PostedDate { get; private set; }
        public VocabularyKey ReceivedDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}