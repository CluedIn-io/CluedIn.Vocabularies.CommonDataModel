using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitIati
{
    public class DeliveryFrameworkVocabulary : SimpleVocabulary
    {
        public DeliveryFrameworkVocabulary()
        {
            VocabularyName = "Delivery Framework";
            KeyPrefix = "commonDataModel.deliveryframework.nonprofitiati";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeliveryFramework;

            AddGroup("DeliveryFramework Details for NonProfitIati", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CapitalSpend = group.Add(new VocabularyKey(nameof(CapitalSpend), "Capital Spend", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CollaborationType = group.Add(new VocabularyKey(nameof(CollaborationType), "Collaboration Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CrsChannelId = group.Add(new VocabularyKey(nameof(CrsChannelId), "CRS Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommitmentDate = group.Add(new VocabularyKey(nameof(CommitmentDate), "Commitment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InterestArrears = group.Add(new VocabularyKey(nameof(InterestArrears), "Interest Arrears", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CrsInterestArrears_Base = group.Add(new VocabularyKey(nameof(CrsInterestArrears_Base), "Interest Arrears (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InterestReceived = group.Add(new VocabularyKey(nameof(InterestReceived), "Interest Received", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CrsInterestReceived_Base = group.Add(new VocabularyKey(nameof(CrsInterestReceived_Base), "Interest Received (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    LoanRate1 = group.Add(new VocabularyKey(nameof(LoanRate1), "Loan Rate 1", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    LoanRate2 = group.Add(new VocabularyKey(nameof(LoanRate2), "Loan Rate 2", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PrincipalArrears = group.Add(new VocabularyKey(nameof(PrincipalArrears), "Principal Arrears", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CrsPrincipalArrears_Base = group.Add(new VocabularyKey(nameof(CrsPrincipalArrears_Base), "Principal Arrears (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PrincipalOutstanding = group.Add(new VocabularyKey(nameof(PrincipalOutstanding), "Principal Outstanding", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CrsPrincipalOutstanding_Base = group.Add(new VocabularyKey(nameof(CrsPrincipalOutstanding_Base), "Principal Outstanding (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    FinalRepaymentDate = group.Add(new VocabularyKey(nameof(FinalRepaymentDate), "Final Repayment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstRepaymentDate = group.Add(new VocabularyKey(nameof(FirstRepaymentDate), "First Repayment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReportingYear = group.Add(new VocabularyKey(nameof(ReportingYear), "Reporting Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CurrencyValueDate = group.Add(new VocabularyKey(nameof(CurrencyValueDate), "Currency Value Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefaultTiedStatusIdId = group.Add(new VocabularyKey(nameof(DefaultTiedStatusIdId), "Default Tied Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExtractionDate = group.Add(new VocabularyKey(nameof(ExtractionDate), "Extraction Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PhaseoutYear = group.Add(new VocabularyKey(nameof(PhaseoutYear), "Phaseout Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    FssPriority = group.Add(new VocabularyKey(nameof(FssPriority), "Priority", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    HierarchyLevel = group.Add(new VocabularyKey(nameof(HierarchyLevel), "Hierarchy Level", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    HumanitarianScope = group.Add(new VocabularyKey(nameof(HumanitarianScope), "Humanitarian Scope", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IatiActivityId = group.Add(new VocabularyKey(nameof(IatiActivityId), "IATI Activity Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SecondaryReporter = group.Add(new VocabularyKey(nameof(SecondaryReporter), "Secondary Reporter", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DeliveryFrameworkId = group.Add(new VocabularyKey(nameof(DeliveryFrameworkId), "Delivery Framework", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeliveryFrameworkType = group.Add(new VocabularyKey(nameof(DeliveryFrameworkType), "Delivery Framework Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Goal = group.Add(new VocabularyKey(nameof(Goal), "Goal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedEndDate = group.Add(new VocabularyKey(nameof(PlannedEndDate), "Planned End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedStartDate = group.Add(new VocabularyKey(nameof(PlannedStartDate), "Planned Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Scope = group.Add(new VocabularyKey(nameof(Scope), "Scope", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="DonorId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="DonorId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Account"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="DonorId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
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
            ///Property <see cref="ContactType"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="DeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
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
            ///Property <see cref="DeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            ///Property <see cref="TypeId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="BudgetNotProvidedId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="CollaborationTypeId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="LoanRepaymentPeriodId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="LoanRepaymentTypeId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="DefaultFinanceTypeId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="DefaultFlowTypeId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="DefaultLanguageId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="ScopeId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="BudgetIdentifierVocabularyId"/> to Vocab 'NonEmbeddedCodelistVocabulary.cdm.json/NonEmbeddedCodelistVocabulary' with Property 'NonEmbeddedCodelistVocabularyId'
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
            ///Property <see cref="ObjectiveId"/> to Vocab 'Objective.cdm.json/Objective' with Property 'ObjectiveId'
            ///Property <see cref="ParentDeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DefaultCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ReviewerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ParentDeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            ///Property <see cref="ObjectiveId"/> to Vocab 'Objective.cdm.json/Objective' with Property 'ObjectiveId'
            ///Property <see cref="ObjectiveId"/> to Vocab 'Objective.cdm.json/Objective' with Property 'ObjectiveId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'AidType.cdm.json/AidType' with Property 'DeliveryFramework'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Condition.cdm.json/Condition' with Property 'DeliveryFramework'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'CrsOtherFlag.cdm.json/CrsOtherFlag' with Property 'DeliveryFramework'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'DeliveryFrameworkContact.cdm.json/DeliveryFrameworkContact' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'DeliveryFrameworkDescription.cdm.json/DeliveryFrameworkDescription' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkDescriptionId"/> from Vocab 'NarrativeTranslation.cdm.json/NarrativeTranslation' with Property 'DeliveryFrameworkDescriptionId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Expenditure.cdm.json/Expenditure' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'FssForecast.cdm.json/FssForecast' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'HumanitarianScope.cdm.json/HumanitarianScope' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Identifier.cdm.json/Identifier' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Location.cdm.json/Location' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'NarrativeTranslation.cdm.json/NarrativeTranslation' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'ParticipatingOrganization.cdm.json/ParticipatingOrganization' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'PolicyMarker.cdm.json/PolicyMarker' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'RecipientCountry.cdm.json/RecipientCountry' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'RecipientRegion.cdm.json/RecipientRegion' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Sector.cdm.json/Sector' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Tag.cdm.json/Tag' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Budget.cdm.json/Budget' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'ParentDeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Budget.cdm.json/Budget' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DeliveryFramework.cdm.json/DeliveryFramework' with Property 'ParentDeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DisbursementDistribution.cdm.json/DisbursementDistribution' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/ProgramItemRelationship.cdm.json/ProgramItemRelationship' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Result.cdm.json/Result' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/TheoryOfChangeRelationship.cdm.json/TheoryOfChangeRelationship' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/WorkItem.cdm.json/WorkItem' with Property 'RelatedDeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Project.cdm.json/Project' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'DisbursementDistribution.cdm.json/DisbursementDistribution' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Result.cdm.json/Result' with Property 'DeliveryFrameworkId'
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey CapitalSpend { get; private set; }
        public VocabularyKey CollaborationType { get; private set; }
        public VocabularyKey CrsChannelId { get; private set; }
        public VocabularyKey CommitmentDate { get; private set; }
        public VocabularyKey InterestArrears { get; private set; }
        public VocabularyKey CrsInterestArrears_Base { get; private set; }
        public VocabularyKey InterestReceived { get; private set; }
        public VocabularyKey CrsInterestReceived_Base { get; private set; }
        public VocabularyKey LoanRate1 { get; private set; }
        public VocabularyKey LoanRate2 { get; private set; }
        public VocabularyKey PrincipalArrears { get; private set; }
        public VocabularyKey CrsPrincipalArrears_Base { get; private set; }
        public VocabularyKey PrincipalOutstanding { get; private set; }
        public VocabularyKey CrsPrincipalOutstanding_Base { get; private set; }
        public VocabularyKey FinalRepaymentDate { get; private set; }
        public VocabularyKey FirstRepaymentDate { get; private set; }
        public VocabularyKey ReportingYear { get; private set; }
        public VocabularyKey CurrencyValueDate { get; private set; }
        public VocabularyKey DefaultTiedStatusIdId { get; private set; }
        public VocabularyKey ExtractionDate { get; private set; }
        public VocabularyKey PhaseoutYear { get; private set; }
        public VocabularyKey FssPriority { get; private set; }
        public VocabularyKey HierarchyLevel { get; private set; }
        public VocabularyKey HumanitarianScope { get; private set; }
        public VocabularyKey IatiActivityId { get; private set; }
        public VocabularyKey SecondaryReporter { get; private set; }
        public VocabularyKey DeliveryFrameworkId { get; private set; }
        public VocabularyKey DeliveryFrameworkType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Goal { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PlannedEndDate { get; private set; }
        public VocabularyKey PlannedStartDate { get; private set; }
        public VocabularyKey Scope { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}