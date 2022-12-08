using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitIati
{
    public class PaymentScheduleVocabulary : SimpleVocabulary
    {
        public PaymentScheduleVocabulary()
        {
            VocabularyName = "Payment Schedule";
            KeyPrefix = "commonDataModel.paymentschedule.nonprofitiati";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PaymentSchedule;

            AddGroup("PaymentSchedule Details for NonProfitIati", group =>
            {
			                 
            });
            
            #region Incoming Relationships
            ///Property <see cref="OmtSchedDefaultHardCreditToCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ReceiptOnAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OmtSchedDefaultHardCreditToCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ReceiptOnAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OmtSchedDefaultHardCreditToCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="OmtSchedDefaultHardCreditToCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PaymentScheduleDonorCommitmentId"/> to Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'DonorCommitmentId'
            ///Property <see cref="PaymentScheduleDonorCommitmentId"/> to Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'DonorCommitmentId'
            ///Property <see cref="PaymentSchedule_DonorCommitmentId"/> to Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'DonorCommitmentId'
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
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="PaymentScheduleId"/> from Vocab 'DesignationPlan.cdm.json/DesignationPlan' with Property 'DesignationPlanPaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab 'PaymentMethod.cdm.json/PaymentMethod' with Property 'PaymentscheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab 'PaymentMethod.cdm.json/PaymentMethod' with Property 'PaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/CreditPlan.cdm.json/CreditPlan' with Property 'CreditPlanPaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DesignationPlan.cdm.json/DesignationPlan' with Property 'DesignationPlanPaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/PaymentAsset.cdm.json/PaymentAsset' with Property 'PledgedOnPaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/PaymentMethod.cdm.json/PaymentMethod' with Property 'PaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Transaction.cdm.json/Transaction' with Property 'TransactionPaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/CreditPlan.cdm.json/CreditPlan' with Property 'CreditPlanPaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/DesignationPlan.cdm.json/DesignationPlan' with Property 'DesignationPlanPaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Transaction.cdm.json/Transaction' with Property 'TransactionPaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'Transaction_PaymentScheduleId'
            ///Property <see cref="PaymentScheduleId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'TransactionPaymentScheduleId'
            #endregion
        }

        
    }
}