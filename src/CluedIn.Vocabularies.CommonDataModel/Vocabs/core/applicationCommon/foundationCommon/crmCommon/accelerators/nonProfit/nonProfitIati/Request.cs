using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitIati
{
    public class RequestVocabulary : SimpleVocabulary
    {
        public RequestVocabulary()
        {
            VocabularyName = "Request";
            KeyPrefix = "commonDataModel.request.nonprofitiati";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Request;

            AddGroup("Request Details for NonProfitIati", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AmountProjected = group.Add(new VocabularyKey(nameof(AmountProjected), "Amount Projected", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountProjected_Base = group.Add(new VocabularyKey(nameof(AmountProjected_Base), "Amount Projected (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountRecommended = group.Add(new VocabularyKey(nameof(AmountRecommended), "Amount Recommended", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountRecommended_Base = group.Add(new VocabularyKey(nameof(AmountRecommended_Base), "Amount Recommended (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountRequested = group.Add(new VocabularyKey(nameof(AmountRequested), "Amount Requested", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountRequested_Base = group.Add(new VocabularyKey(nameof(AmountRequested_Base), "Amount Requested (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ApplicationID = group.Add(new VocabularyKey(nameof(ApplicationID), "Application ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConflictOfInterestDetail = group.Add(new VocabularyKey(nameof(ConflictOfInterestDetail), "Conflict of Interest Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConflictOfInterestStatus = group.Add(new VocabularyKey(nameof(ConflictOfInterestStatus), "Conflict of Interest Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InitialApplicationChannel = group.Add(new VocabularyKey(nameof(InitialApplicationChannel), "Initial Application Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RenewalOfAwardId = group.Add(new VocabularyKey(nameof(RenewalOfAwardId), "Renewal of Award", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestedDuration = group.Add(new VocabularyKey(nameof(RequestedDuration), "Requested Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RequestedStartDate = group.Add(new VocabularyKey(nameof(RequestedStartDate), "Requested Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestId = group.Add(new VocabularyKey(nameof(RequestId), "Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestType = group.Add(new VocabularyKey(nameof(RequestType), "Request Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Requirements = group.Add(new VocabularyKey(nameof(Requirements), "Requirements", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Stage = group.Add(new VocabularyKey(nameof(Stage), "Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubmittedDate = group.Add(new VocabularyKey(nameof(SubmittedDate), "Submitted Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalProjectBudget = group.Add(new VocabularyKey(nameof(TotalProjectBudget), "Total Project Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalProjectBudget_Base = group.Add(new VocabularyKey(nameof(TotalProjectBudget_Base), "Total Project Budget (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="FiscalSponsorId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RecipientId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="FiscalSponsorId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RecipientId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="FiscalSponsorId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RecipientId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RecipientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="SubmittedById"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RecipientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="SubmittedById"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RecipientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="SubmittedById"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RenewalOfAwardId"/> to Vocab 'Award.cdm.json/Award' with Property 'AwardId'
            ///Property <see cref="RenewalOfAwardId"/> to Vocab 'Award.cdm.json/Award' with Property 'AwardId'
            ///Property <see cref="DocketId"/> to Vocab 'Docket.cdm.json/Docket' with Property 'DocketId'
            ///Property <see cref="DocketId"/> to Vocab 'Docket.cdm.json/Docket' with Property 'DocketId'
            ///Property <see cref="DocketId"/> to Vocab 'Docket.cdm.json/Docket' with Property 'DocketId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="LeadId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'LeadId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="RequestId"/> from Vocab 'Award.cdm.json/Award' with Property 'RequestId'
            ///Property <see cref="RequestId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/OfacMatch.cdm.json/OfacMatch' with Property 'RequestId'
            ///Property <see cref="RequestId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Recommendation.cdm.json/Recommendation' with Property 'RequestId'
            ///Property <see cref="RequestId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Report.cdm.json/Report' with Property 'RequestId'
            ///Property <see cref="RequestId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Review.cdm.json/Review' with Property 'RequestId'
            ///Property <see cref="RequestId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Award.cdm.json/Award' with Property 'RequestId'
            ///Property <see cref="RequestId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/OfacMatch.cdm.json/OfacMatch' with Property 'RequestId'
            ///Property <see cref="RequestId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Recommendation.cdm.json/Recommendation' with Property 'RequestId'
            ///Property <see cref="RequestId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Report.cdm.json/Report' with Property 'RequestId'
            ///Property <see cref="RequestId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Review.cdm.json/Review' with Property 'RequestId'
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey AmountProjected { get; private set; }
        public VocabularyKey AmountProjected_Base { get; private set; }
        public VocabularyKey AmountRecommended { get; private set; }
        public VocabularyKey AmountRecommended_Base { get; private set; }
        public VocabularyKey AmountRequested { get; private set; }
        public VocabularyKey AmountRequested_Base { get; private set; }
        public VocabularyKey ApplicationID { get; private set; }
        public VocabularyKey ConflictOfInterestDetail { get; private set; }
        public VocabularyKey ConflictOfInterestStatus { get; private set; }
        public VocabularyKey InitialApplicationChannel { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey RenewalOfAwardId { get; private set; }
        public VocabularyKey RequestedDuration { get; private set; }
        public VocabularyKey RequestedStartDate { get; private set; }
        public VocabularyKey RequestId { get; private set; }
        public VocabularyKey RequestType { get; private set; }
        public VocabularyKey Requirements { get; private set; }
        public VocabularyKey Stage { get; private set; }
        public VocabularyKey SubmittedDate { get; private set; }
        public VocabularyKey TotalProjectBudget { get; private set; }
        public VocabularyKey TotalProjectBudget_Base { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}