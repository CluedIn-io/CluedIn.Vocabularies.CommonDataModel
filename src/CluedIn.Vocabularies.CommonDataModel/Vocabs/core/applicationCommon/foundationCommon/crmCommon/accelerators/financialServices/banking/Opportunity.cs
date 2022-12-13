using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class OpportunityVocabulary : SimpleVocabulary
    {
        public OpportunityVocabulary()
        {
            VocabularyName = "Opportunity";
            KeyPrefix = "commonDataModel.opportunity";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Opportunity;

            AddGroup("Opportunity Details for Banking", group =>
            {
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                CostOfProperty = group.Add(new VocabularyKey(nameof(CostOfProperty), "Cost of Property", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                CostOfPropertyBase = group.Add(new VocabularyKey(nameof(CostOfPropertyBase), "Cost of Property (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                DownPayment = group.Add(new VocabularyKey(nameof(DownPayment), "Down Payment", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                DownPaymentBase = group.Add(new VocabularyKey(nameof(DownPaymentBase), "Down Payment (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                InterestRate = group.Add(new VocabularyKey(nameof(InterestRate), "Interest Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                PreferredFollowUpTime = group.Add(new VocabularyKey(nameof(PreferredFollowUpTime), "Preferred Follow-up Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurposeOfLoan = group.Add(new VocabularyKey(nameof(PurposeOfLoan), "Purpose of Loan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedAmount = group.Add(new VocabularyKey(nameof(RequestedAmount), "Requested Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                RequestedAmountBase = group.Add(new VocabularyKey(nameof(RequestedAmountBase), "Requested Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TermOfLoan = group.Add(new VocabularyKey(nameof(TermOfLoan), "Term of Loan", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Opportunity Details for NonProfitForSales", group =>
            {
                AskReadiness = group.Add(new VocabularyKey(nameof(AskReadiness), "Ask Readiness", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedGivingAmount = group.Add(new VocabularyKey(nameof(ExpectedGivingAmount), "Expected Giving Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ExpectedGivingAmount_Base = group.Add(new VocabularyKey(nameof(ExpectedGivingAmount_Base), "Expected Giving Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ProspectiveGiftType = group.Add(new VocabularyKey(nameof(ProspectiveGiftType), "Prospective Gift Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SolicitationType = group.Add(new VocabularyKey(nameof(SolicitationType), "Solicitation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCode = group.Add(new VocabularyKey(nameof(SourceCode), "Source Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Opportunity Details for NonProfitIati", group =>
            {
                Expectedgivingamount_Base = group.Add(new VocabularyKey(nameof(Expectedgivingamount_Base), "Expected Giving Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Opportunity Details for ProjectServiceAutomation", group =>
            {
                OrderType = group.Add(new VocabularyKey(nameof(OrderType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Opportunity Details for Sales", group =>
            {
                OpportunityId = group.Add(new VocabularyKey(nameof(OpportunityId), "Opportunity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Email Address", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Topic", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualCloseDate = group.Add(new VocabularyKey(nameof(ActualCloseDate), "Actual Close Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualValue = group.Add(new VocabularyKey(nameof(ActualValue), "Actual Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ActualValueBase = group.Add(new VocabularyKey(nameof(ActualValueBase), "Actual Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetAmount = group.Add(new VocabularyKey(nameof(BudgetAmount), "Budget Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                BudgetAmountBase = group.Add(new VocabularyKey(nameof(BudgetAmountBase), "Budget Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetStatus = group.Add(new VocabularyKey(nameof(BudgetStatus), "Budget", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CloseProbability = group.Add(new VocabularyKey(nameof(CloseProbability), "Probability", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                CompleteInternalReview = group.Add(new VocabularyKey(nameof(CompleteInternalReview), "Complete Internal Review", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ConfirmInterest = group.Add(new VocabularyKey(nameof(ConfirmInterest), "Confirm Interest", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                CurrentSituation = group.Add(new VocabularyKey(nameof(CurrentSituation), "Current Situation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerNeed = group.Add(new VocabularyKey(nameof(CustomerNeed), "Customer Need", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPainPoints = group.Add(new VocabularyKey(nameof(CustomerPainPoints), "Customer Pain Points", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecisionMaker = group.Add(new VocabularyKey(nameof(DecisionMaker), "Decision Maker?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DevelopProposal = group.Add(new VocabularyKey(nameof(DevelopProposal), "Develop Proposal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), "Opportunity Discount Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                DiscountAmountBase = group.Add(new VocabularyKey(nameof(DiscountAmountBase), "Opportunity Discount Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage = group.Add(new VocabularyKey(nameof(DiscountPercentage), "Opportunity Discount (%)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                EstimatedCloseDate = group.Add(new VocabularyKey(nameof(EstimatedCloseDate), "Est. Close Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedValue = group.Add(new VocabularyKey(nameof(EstimatedValue), "Est. Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                EstimatedValueBase = group.Add(new VocabularyKey(nameof(EstimatedValueBase), "Est. Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EvaluateFit = group.Add(new VocabularyKey(nameof(EvaluateFit), "Evaluate Fit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ResolveFeedback = group.Add(new VocabularyKey(nameof(ResolveFeedback), "Feedback Resolved", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                FileDebrief = group.Add(new VocabularyKey(nameof(FileDebrief), "File Debrief", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                CompleteFinalProposal = group.Add(new VocabularyKey(nameof(CompleteFinalProposal), "Final Proposal Ready", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                FinalDecisionDate = group.Add(new VocabularyKey(nameof(FinalDecisionDate), "Final Decision Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightAmount = group.Add(new VocabularyKey(nameof(FreightAmount), "Freight Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                FreightAmountBase = group.Add(new VocabularyKey(nameof(FreightAmountBase), "Freight Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InitialCommunication = group.Add(new VocabularyKey(nameof(InitialCommunication), "Initial Communication", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRevenueSystemCalculated = group.Add(new VocabularyKey(nameof(IsRevenueSystemCalculated), "Revenue", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Need = group.Add(new VocabularyKey(nameof(Need), "Need", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpportunityRatingCode = group.Add(new VocabularyKey(nameof(OpportunityRatingCode), "Rating", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipatesInWorkflow = group.Add(new VocabularyKey(nameof(ParticipatesInWorkflow), "Participates in Workflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                PricingErrorCode = group.Add(new VocabularyKey(nameof(PricingErrorCode), "Pricing Error ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseProcess = group.Add(new VocabularyKey(nameof(PurchaseProcess), "Purchase Process", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseTimeFrame = group.Add(new VocabularyKey(nameof(PurchaseTimeFrame), "Purchase Timeframe", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesStage = group.Add(new VocabularyKey(nameof(SalesStage), "Sales Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesStageCode = group.Add(new VocabularyKey(nameof(SalesStageCode), "Process Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PresentProposal = group.Add(new VocabularyKey(nameof(PresentProposal), "Presented Proposal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                CaptureProposalFeedback = group.Add(new VocabularyKey(nameof(CaptureProposalFeedback), "Proposal Feedback Captured", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ProposedSolution = group.Add(new VocabularyKey(nameof(ProposedSolution), "Proposed Solution", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PursuitDecision = group.Add(new VocabularyKey(nameof(PursuitDecision), "Decide Go/No-Go", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                QualificationComments = group.Add(new VocabularyKey(nameof(QualificationComments), "Qualification Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuoteComments = group.Add(new VocabularyKey(nameof(QuoteComments), "Quote Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SendThankYouNote = group.Add(new VocabularyKey(nameof(SendThankYouNote), "Send Thank You Note", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ScheduleFollowupProspect = group.Add(new VocabularyKey(nameof(ScheduleFollowupProspect), "Scheduled Follow up (Prospect)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleFollowUpQualify = group.Add(new VocabularyKey(nameof(ScheduleFollowUpQualify), "Scheduled Follow up (Qualify)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleProposalMeeting = group.Add(new VocabularyKey(nameof(ScheduleProposalMeeting), "Schedule Proposal Meeting", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StepId = group.Add(new VocabularyKey(nameof(StepId), "Step", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StepName = group.Add(new VocabularyKey(nameof(StepName), "Pipeline Phase", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeLine = group.Add(new VocabularyKey(nameof(TimeLine), "Timeline", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalAmount = group.Add(new VocabularyKey(nameof(TotalAmount), "Total Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TotalAmountBase = group.Add(new VocabularyKey(nameof(TotalAmountBase), "Total Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalAmountLessFreight = group.Add(new VocabularyKey(nameof(TotalAmountLessFreight), "Total Pre-Freight Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TotalAmountLessFreightBase = group.Add(new VocabularyKey(nameof(TotalAmountLessFreightBase), "Total Pre-Freight Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), "Total Discount Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TotalDiscountAmountBase = group.Add(new VocabularyKey(nameof(TotalDiscountAmountBase), "Total Discount Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalLineItemAmount = group.Add(new VocabularyKey(nameof(TotalLineItemAmount), "Total Detail Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TotalLineItemAmountBase = group.Add(new VocabularyKey(nameof(TotalLineItemAmountBase), "Total Detail Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalLineItemDiscountAmount = group.Add(new VocabularyKey(nameof(TotalLineItemDiscountAmount), "Total Line Item Discount Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TotalLineItemDiscountAmountBase = group.Add(new VocabularyKey(nameof(TotalLineItemDiscountAmountBase), "Total Line Item Discount Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalTax = group.Add(new VocabularyKey(nameof(TotalTax), "Total Tax", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TotalTaxBase = group.Add(new VocabularyKey(nameof(TotalTaxBase), "Total Tax (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentifyCustomerContacts = group.Add(new VocabularyKey(nameof(IdentifyCustomerContacts), "Identify Customer Contacts", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IdentifyCompetitors = group.Add(new VocabularyKey(nameof(IdentifyCompetitors), "Identify Competitors", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IdentifyPursuitTeam = group.Add(new VocabularyKey(nameof(IdentifyPursuitTeam), "Identify Sales Team", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                PresentFinalProposal = group.Add(new VocabularyKey(nameof(PresentFinalProposal), "Present Final Proposal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeSpentByMeOnEmailAndMeetings = group.Add(new VocabularyKey(nameof(TimeSpentByMeOnEmailAndMeetings), "Time Spent by me", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Unique identifier of the account with which the opportunity is associated.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Unique identifier of the contact associated with the opportunity.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Opportunity Details for Portals", group =>
            {

            });

            #region Incoming Relationships
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="OriginatingLeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
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
            ///Property <see cref="PriceLevelId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="CampaignId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="OpportunityId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'QualifyingOpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'BusinessCheckingAccount.cdm.json/BusinessCheckingAccount' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'CertificateOfDeposit.cdm.json/CertificateOfDeposit' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'CommercialDeposit.cdm.json/CommercialDeposit' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'CommercialLoan.cdm.json/CommercialLoan' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'RequestedFacility.cdm.json/RequestedFacility' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab 'MortgageApplication.cdm.json/MortgageApplication' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'QualifyingOpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'QualifyingOpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/AutoLeadToOpportunitySalesProcess.cdm.json/AutoLeadToOpportunitySalesProcess' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/DealFile.cdm.json/DealFile' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/LeadDisposition.cdm.json/LeadDisposition' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/TestDrive.cdm.json/TestDrive' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Invoice.cdm.json/Invoice' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityCompetitors.cdm.json/OpportunityCompetitors' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityRelationship.cdm.json/OpportunityRelationship' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Order.cdm.json/Order' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Quote.cdm.json/Quote' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey ActualCloseDate { get; private set; }
        public VocabularyKey ActualValue { get; private set; }
        public VocabularyKey ActualValueBase { get; private set; }
        public VocabularyKey AskReadiness { get; private set; }
        public VocabularyKey BudgetAmount { get; private set; }
        public VocabularyKey BudgetAmountBase { get; private set; }
        public VocabularyKey BudgetStatus { get; private set; }
        public VocabularyKey CaptureProposalFeedback { get; private set; }
        public VocabularyKey CloseProbability { get; private set; }
        public VocabularyKey CompleteFinalProposal { get; private set; }
        public VocabularyKey CompleteInternalReview { get; private set; }
        public VocabularyKey ConfirmInterest { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey CostOfProperty { get; private set; }
        public VocabularyKey CostOfPropertyBase { get; private set; }
        public VocabularyKey CurrentSituation { get; private set; }
        public VocabularyKey CustomerNeed { get; private set; }
        public VocabularyKey CustomerPainPoints { get; private set; }
        public VocabularyKey DecisionMaker { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DevelopProposal { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey DiscountAmountBase { get; private set; }
        public VocabularyKey DiscountPercentage { get; private set; }
        public VocabularyKey DownPayment { get; private set; }
        public VocabularyKey DownPaymentBase { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey EstimatedCloseDate { get; private set; }
        public VocabularyKey EstimatedValue { get; private set; }
        public VocabularyKey EstimatedValueBase { get; private set; }
        public VocabularyKey EvaluateFit { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExpectedGivingAmount { get; private set; }
        public VocabularyKey Expectedgivingamount_Base { get; private set; }
        public VocabularyKey ExpectedGivingAmount_Base { get; private set; }
        public VocabularyKey FileDebrief { get; private set; }
        public VocabularyKey FinalDecisionDate { get; private set; }
        public VocabularyKey FreightAmount { get; private set; }
        public VocabularyKey FreightAmountBase { get; private set; }
        public VocabularyKey IdentifyCompetitors { get; private set; }
        public VocabularyKey IdentifyCustomerContacts { get; private set; }
        public VocabularyKey IdentifyPursuitTeam { get; private set; }
        public VocabularyKey InitialCommunication { get; private set; }
        public VocabularyKey InterestRate { get; private set; }
        public VocabularyKey IsRevenueSystemCalculated { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Need { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey OpportunityId { get; private set; }
        public VocabularyKey OpportunityRatingCode { get; private set; }
        public VocabularyKey OrderType { get; private set; }
        public VocabularyKey ParticipatesInWorkflow { get; private set; }
        public VocabularyKey PreferredFollowUpTime { get; private set; }
        public VocabularyKey PresentFinalProposal { get; private set; }
        public VocabularyKey PresentProposal { get; private set; }
        public VocabularyKey PricingErrorCode { get; private set; }
        public VocabularyKey PriorityCode { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey ProposedSolution { get; private set; }
        public VocabularyKey ProspectiveGiftType { get; private set; }
        public VocabularyKey PurchaseProcess { get; private set; }
        public VocabularyKey PurchaseTimeFrame { get; private set; }
        public VocabularyKey PurposeOfLoan { get; private set; }
        public VocabularyKey PursuitDecision { get; private set; }
        public VocabularyKey QualificationComments { get; private set; }
        public VocabularyKey QuoteComments { get; private set; }
        public VocabularyKey RequestedAmount { get; private set; }
        public VocabularyKey RequestedAmountBase { get; private set; }
        public VocabularyKey ResolveFeedback { get; private set; }
        public VocabularyKey SalesStage { get; private set; }
        public VocabularyKey SalesStageCode { get; private set; }
        public VocabularyKey ScheduleFollowupProspect { get; private set; }
        public VocabularyKey ScheduleFollowUpQualify { get; private set; }
        public VocabularyKey ScheduleProposalMeeting { get; private set; }
        public VocabularyKey SendThankYouNote { get; private set; }
        public VocabularyKey SolicitationType { get; private set; }
        public VocabularyKey SourceCode { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StepId { get; private set; }
        public VocabularyKey StepName { get; private set; }
        public VocabularyKey TermOfLoan { get; private set; }
        public VocabularyKey TimeLine { get; private set; }
        public VocabularyKey TimeSpentByMeOnEmailAndMeetings { get; private set; }
        public VocabularyKey TotalAmount { get; private set; }
        public VocabularyKey TotalAmountBase { get; private set; }
        public VocabularyKey TotalAmountLessFreight { get; private set; }
        public VocabularyKey TotalAmountLessFreightBase { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey TotalDiscountAmountBase { get; private set; }
        public VocabularyKey TotalLineItemAmount { get; private set; }
        public VocabularyKey TotalLineItemAmountBase { get; private set; }
        public VocabularyKey TotalLineItemDiscountAmount { get; private set; }
        public VocabularyKey TotalLineItemDiscountAmountBase { get; private set; }
        public VocabularyKey TotalTax { get; private set; }
        public VocabularyKey TotalTaxBase { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
    }
}