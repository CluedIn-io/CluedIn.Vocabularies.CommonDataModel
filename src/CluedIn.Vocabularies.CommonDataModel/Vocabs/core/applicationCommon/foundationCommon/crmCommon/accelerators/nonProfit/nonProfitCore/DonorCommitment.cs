using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DonorCommitmentVocabulary : SimpleVocabulary
    {
        public DonorCommitmentVocabulary()
        {
            VocabularyName = "Donor Commitment";
            KeyPrefix = "commonDataModel.donorcommitment";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DonorCommitment;

            AddGroup("DonorCommitment Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Anonymity = group.Add(new VocabularyKey(nameof(Anonymity), "Anonymity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookDate = group.Add(new VocabularyKey(nameof(BookDate), "Book Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommitmentDate = group.Add(new VocabularyKey(nameof(CommitmentDate), "Commitment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommitmentType = group.Add(new VocabularyKey(nameof(CommitmentType), "Commitment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataEntryReference = group.Add(new VocabularyKey(nameof(DataEntryReference), "Data Entry Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataEntrySource = group.Add(new VocabularyKey(nameof(DataEntrySource), "Data Entry Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DonorCommitmentId = group.Add(new VocabularyKey(nameof(DonorCommitmentId), "Donor Commitment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedByDate = group.Add(new VocabularyKey(nameof(ExpectedByDate), "Expected By Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsBookable = group.Add(new VocabularyKey(nameof(IsBookable), "Is Bookable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NextPaymentAmount = group.Add(new VocabularyKey(nameof(NextPaymentAmount), "Next Payment Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NextPaymentAmountBase = group.Add(new VocabularyKey(nameof(NextPaymentAmountBase), "Next Payment Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NextPaymentDate = group.Add(new VocabularyKey(nameof(NextPaymentDate), "Next Payment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReceivedDate = group.Add(new VocabularyKey(nameof(ReceivedDate), "Received Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalAmount = group.Add(new VocabularyKey(nameof(TotalAmount), "Total Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalAmountBase = group.Add(new VocabularyKey(nameof(TotalAmountBase), "Total Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("DonorCommitment Details for NonProfitForSales", group =>
            {

            });
            AddGroup("DonorCommitment Details for NonProfitIati", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CurrencyValueDate = group.Add(new VocabularyKey(nameof(CurrencyValueDate), "Currency Value Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Humanitarian = group.Add(new VocabularyKey(nameof(Humanitarian), "Humanitarian", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ProviderActivityIdentifier = group.Add(new VocabularyKey(nameof(ProviderActivityIdentifier), "Provider Activity Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientActivityIdentifier = group.Add(new VocabularyKey(nameof(RecipientActivityIdentifier), "Recipient Activity Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientCountryDescription = group.Add(new VocabularyKey(nameof(RecipientCountryDescription), "Recipient Country Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientRegionDescription = group.Add(new VocabularyKey(nameof(RecipientRegionDescription), "Recipient Region Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Reference = group.Add(new VocabularyKey(nameof(Reference), "Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), "Transaction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Nextpaymentamount_Base = group.Add(new VocabularyKey(nameof(Nextpaymentamount_Base), "Next Payment Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Totalamount_Base = group.Add(new VocabularyKey(nameof(Totalamount_Base), "Total Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="PledgedByAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PledgedOnAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PledgedByAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PledgedOnAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PledgedByContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PledgedByContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CommitmentDefaultDesignationId"/> to Vocab 'Designation.cdm.json/Designation' with Property 'DesignationId'
            ///Property <see cref="CommitmentDefaultDesignationId"/> to Vocab 'Designation.cdm.json/Designation' with Property 'DesignationId'
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
            ///Property <see cref="DonorCommitmentPlannedGivingId"/> to Vocab 'PlannedGiving.cdm.json/PlannedGiving' with Property 'PlannedGivingId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="DonorCommitmentId"/> from Vocab 'DesignationPlan.cdm.json/DesignationPlan' with Property 'DesignationPlanDonorCommitmentId'
            ///Property <see cref="DonorCommitmentId"/> from Vocab 'PaymentSchedule.cdm.json/PaymentSchedule' with Property 'PaymentScheduleDonorCommitmentId'
            #endregion
        }

        public VocabularyKey Anonymity { get; private set; }
        public VocabularyKey BookDate { get; private set; }
        public VocabularyKey CommitmentDate { get; private set; }
        public VocabularyKey CommitmentType { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey CurrencyValueDate { get; private set; }
        public VocabularyKey DataEntryReference { get; private set; }
        public VocabularyKey DataEntrySource { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DonorCommitmentId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExpectedByDate { get; private set; }
        public VocabularyKey Humanitarian { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey IsBookable { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NextPaymentAmount { get; private set; }
        public VocabularyKey Nextpaymentamount_Base { get; private set; }
        public VocabularyKey NextPaymentAmountBase { get; private set; }
        public VocabularyKey NextPaymentDate { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ProviderActivityIdentifier { get; private set; }
        public VocabularyKey ReceivedDate { get; private set; }
        public VocabularyKey RecipientActivityIdentifier { get; private set; }
        public VocabularyKey RecipientCountryDescription { get; private set; }
        public VocabularyKey RecipientRegionDescription { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TotalAmount { get; private set; }
        public VocabularyKey Totalamount_Base { get; private set; }
        public VocabularyKey TotalAmountBase { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
    }
}