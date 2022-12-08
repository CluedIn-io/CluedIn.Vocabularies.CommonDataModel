using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitForSales
{
    public class DonorCommitmentVocabulary : SimpleVocabulary
    {
        public DonorCommitmentVocabulary()
        {
            VocabularyName = "Donor Commitment";
            KeyPrefix = "commonDataModel.donorcommitment.nonprofitforsales";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DonorCommitment;

            AddGroup("DonorCommitment Details for NonProfitForSales", group =>
            {
			                 
            });
            
            #region Incoming Relationships
            ///Property <see cref="Commitment_CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
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
            ///Property <see cref="CommitmentDefaultDesignationId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Designation.cdm.json/Designation' with Property 'DesignationId'
            ///Property <see cref="DonorCommitmentPlannedGivingId"/> to Vocab 'PlannedGiving.cdm.json/PlannedGiving' with Property 'PlannedGivingId'
            ///Property <see cref="PledgedByAccountId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PledgedByContactId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PledgedOnAccountId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="DonorCommitmentPlannedGivingId"/> to Vocab 'PlannedGiving.cdm.json/PlannedGiving' with Property 'PlannedGivingId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="DonorCommitmentId"/> from Vocab 'DesignationPlan.cdm.json/DesignationPlan' with Property 'DesignationPlanDonorCommitmentId'
            ///Property <see cref="DonorCommitmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DesignationPlan.cdm.json/DesignationPlan' with Property 'DesignationPlanDonorCommitmentId'
            ///Property <see cref="DonorCommitmentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/PaymentSchedule.cdm.json/PaymentSchedule' with Property 'PaymentScheduleDonorCommitmentId'
            ///Property <see cref="DonorCommitmentId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'PrimaryProposalId'
            #endregion
        }

        
    }
}