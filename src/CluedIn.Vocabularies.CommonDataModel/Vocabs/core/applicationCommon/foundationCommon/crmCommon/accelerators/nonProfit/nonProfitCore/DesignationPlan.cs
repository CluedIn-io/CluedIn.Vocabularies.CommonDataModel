using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitCore
{
    public class DesignationPlanVocabulary : SimpleVocabulary
    {
        public DesignationPlanVocabulary()
        {
            VocabularyName = "Designation Plan";
            KeyPrefix = "commonDataModel.designationplan.nonprofitcore";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DesignationPlan;

            AddGroup("DesignationPlan Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AmountOfPledgeMax = group.Add(new VocabularyKey(nameof(AmountOfPledgeMax), "Amount Of Pledge Max", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountOfPledgeMaxBase = group.Add(new VocabularyKey(nameof(AmountOfPledgeMaxBase), "Amount Of Pledge Max (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DesignationPlanId = group.Add(new VocabularyKey(nameof(DesignationPlanId), "Designation Plan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfPaymentsMax = group.Add(new VocabularyKey(nameof(NumberOfPaymentsMax), "Number Of Payments Max", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PercentageOfPaymentsMax = group.Add(new VocabularyKey(nameof(PercentageOfPaymentsMax), "Percentage Of Payments Max", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PercentageOfPledgeMax = group.Add(new VocabularyKey(nameof(PercentageOfPledgeMax), "Percentage Of Pledge Max", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PerPaymentMaxAmount = group.Add(new VocabularyKey(nameof(PerPaymentMaxAmount), "Per Payment Max Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PerPaymentMaxAmountBase = group.Add(new VocabularyKey(nameof(PerPaymentMaxAmountBase), "Per Payment Max Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PerPaymentMaxPercent = group.Add(new VocabularyKey(nameof(PerPaymentMaxPercent), "Per Payment Max Percent", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PriorityOrder = group.Add(new VocabularyKey(nameof(PriorityOrder), "Priority Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), "Valid From Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), "Valid To Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="DesignationPlanDesignationId"/> to Vocab 'Designation.cdm.json/Designation' with Property 'DesignationId'
            ///Property <see cref="DesignationPlanDesignationId"/> to Vocab 'Designation.cdm.json/Designation' with Property 'DesignationId'
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
            ///Property <see cref="DesignationPlanDonorCommitmentId"/> to Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'DonorCommitmentId'
            ///Property <see cref="DesignationPlanPaymentScheduleId"/> to Vocab 'PaymentSchedule.cdm.json/PaymentSchedule' with Property 'PaymentScheduleId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="DesignationPlanPaymentScheduleId"/> to Vocab 'PaymentSchedule.cdm.json/PaymentSchedule' with Property 'PaymentScheduleId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AmountOfPledgeMax { get; private set; }
        public VocabularyKey AmountOfPledgeMaxBase { get; private set; }
        public VocabularyKey DesignationPlanId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NumberOfPaymentsMax { get; private set; }
        public VocabularyKey PercentageOfPaymentsMax { get; private set; }
        public VocabularyKey PercentageOfPledgeMax { get; private set; }
        public VocabularyKey PerPaymentMaxAmount { get; private set; }
        public VocabularyKey PerPaymentMaxAmountBase { get; private set; }
        public VocabularyKey PerPaymentMaxPercent { get; private set; }
        public VocabularyKey PriorityOrder { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}