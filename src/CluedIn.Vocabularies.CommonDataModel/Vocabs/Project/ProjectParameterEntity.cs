using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjectParameterEntityVocabulary : SimpleVocabulary
    {
        public ProjectParameterEntityVocabulary()
        {
            VocabularyName = "Project Parameter Entity";
            KeyPrefix = "commonDataModel.projectparameterentity";
            KeySeparator = ".";
            Grouping = "/ProjectParameterEntity";

            AddGroup("ProjectParameterEntity Details", group =>
            {
                ItemLumpSumAllocationKey = group.Add(new VocabularyKey(nameof(ItemLumpSumAllocationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPaymentForHours = group.Add(new VocabularyKey(nameof(TermsOfPaymentForHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualCostAfterEstimateDate = group.Add(new VocabularyKey(nameof(ActualCostAfterEstimateDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommittedCostAfterEstimateDate = group.Add(new VocabularyKey(nameof(CommittedCostAfterEstimateDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommittedCostUpToEstimateDate = group.Add(new VocabularyKey(nameof(CommittedCostUpToEstimateDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutoupdateField = group.Add(new VocabularyKey(nameof(IsAutoupdateField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBudgetControlOutsideTheProjectHierarchyAllowed = group.Add(new VocabularyKey(nameof(IsBudgetControlOutsideTheProjectHierarchyAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDateCorrectionsOnTimesheetsAllowed = group.Add(new VocabularyKey(nameof(IsDateCorrectionsOnTimesheetsAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEliminationWithoutPostingEstimatesAllowed = group.Add(new VocabularyKey(nameof(IsEliminationWithoutPostingEstimatesAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanAlwaysCreateAdjustmentTransaction = group.Add(new VocabularyKey(nameof(CanAlwaysCreateAdjustmentTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountInMillions = group.Add(new VocabularyKey(nameof(AmountInMillions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountInThousands = group.Add(new VocabularyKey(nameof(AmountInThousands), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroup = group.Add(new VocabularyKey(nameof(UserGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemConsumption = group.Add(new VocabularyKey(nameof(IsItemConsumption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BeginningBalances = group.Add(new VocabularyKey(nameof(BeginningBalances), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommittedCost = group.Add(new VocabularyKey(nameof(CommittedCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingRuleFeeJournal = group.Add(new VocabularyKey(nameof(BillingRuleFeeJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCategoryExpense = group.Add(new VocabularyKey(nameof(DefaultCategoryExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCostTemplate = group.Add(new VocabularyKey(nameof(DefaultCostTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreateItemRequirement = group.Add(new VocabularyKey(nameof(IsCreateItemRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLineError = group.Add(new VocabularyKey(nameof(CreditLineError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetTheCostPriceAsTheSalesPriceByDefault = group.Add(new VocabularyKey(nameof(SetTheCostPriceAsTheSalesPriceByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultItemAllocationKey = group.Add(new VocabularyKey(nameof(DefaultItemAllocationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCategory = group.Add(new VocabularyKey(nameof(DefaultCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSubprojectIDFormat = group.Add(new VocabularyKey(nameof(DefaultSubprojectIDFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayTransactions = group.Add(new VocabularyKey(nameof(DisplayTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProjectType = group.Add(new VocabularyKey(nameof(DefaultProjectType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Eliminated = group.Add(new VocabularyKey(nameof(Eliminated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCategoryHour = group.Add(new VocabularyKey(nameof(DefaultCategoryHour), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultJournalNamesHour = group.Add(new VocabularyKey(nameof(DefaultJournalNamesHour), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckBudgetOnDocumentLineSave = group.Add(new VocabularyKey(nameof(CheckBudgetOnDocumentLineSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanyResourceSchedulingAndTimesheetsEnabled = group.Add(new VocabularyKey(nameof(IsIntercompanyResourceSchedulingAndTimesheetsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProcessingInvoiceProposalsInWorkflowEnabled = group.Add(new VocabularyKey(nameof(IsProcessingInvoiceProposalsInWorkflowEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Estimated = group.Add(new VocabularyKey(nameof(Estimated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseDeleteReducedToZero = group.Add(new VocabularyKey(nameof(ExpenseDeleteReducedToZero), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseJournalNameId = group.Add(new VocabularyKey(nameof(ExpenseJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseLumpSumAllocationKey = group.Add(new VocabularyKey(nameof(ExpenseLumpSumAllocationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseReduceCostPriority1 = group.Add(new VocabularyKey(nameof(ExpenseReduceCostPriority1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseReduceCostPriority2 = group.Add(new VocabularyKey(nameof(ExpenseReduceCostPriority2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseReduceCostPriority3 = group.Add(new VocabularyKey(nameof(ExpenseReduceCostPriority3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseReduceCostPriority4 = group.Add(new VocabularyKey(nameof(ExpenseReduceCostPriority4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseReduceCostPriority5 = group.Add(new VocabularyKey(nameof(ExpenseReduceCostPriority5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumRequirement = group.Add(new VocabularyKey(nameof(MinimumRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralBufferDays = group.Add(new VocabularyKey(nameof(GeneralBufferDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPaymentForExpenses = group.Add(new VocabularyKey(nameof(TermsOfPaymentForExpenses), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPaymentForItems = group.Add(new VocabularyKey(nameof(TermsOfPaymentForItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAllocationSettingsLocked = group.Add(new VocabularyKey(nameof(IsAllocationSettingsLocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplyPrioritySettingsFirstOrLastInFundingAllocationOrder = group.Add(new VocabularyKey(nameof(ApplyPrioritySettingsFirstOrLastInFundingAllocationOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossMarginDecimals = group.Add(new VocabularyKey(nameof(GrossMarginDecimals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossMarginRatio = group.Add(new VocabularyKey(nameof(GrossMarginRatio), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HideActivity = group.Add(new VocabularyKey(nameof(HideActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HideCategory = group.Add(new VocabularyKey(nameof(HideCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HideExternalComments = group.Add(new VocabularyKey(nameof(HideExternalComments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HideLineProperty = group.Add(new VocabularyKey(nameof(HideLineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourDeleteReducedToZero = group.Add(new VocabularyKey(nameof(HourDeleteReducedToZero), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourQtyDecimals = group.Add(new VocabularyKey(nameof(HourQtyDecimals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourReduceCostPriority1 = group.Add(new VocabularyKey(nameof(HourReduceCostPriority1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourReduceCostPriority2 = group.Add(new VocabularyKey(nameof(HourReduceCostPriority2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourReduceCostPriority3 = group.Add(new VocabularyKey(nameof(HourReduceCostPriority3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourReduceCostPriority4 = group.Add(new VocabularyKey(nameof(HourReduceCostPriority4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourReduceCostPriority5 = group.Add(new VocabularyKey(nameof(HourReduceCostPriority5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourReducedMinimumRequirement = group.Add(new VocabularyKey(nameof(HourReducedMinimumRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultJournalNameItem = group.Add(new VocabularyKey(nameof(DefaultJournalNameItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoiced = group.Add(new VocabularyKey(nameof(Invoiced), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceProposal = group.Add(new VocabularyKey(nameof(InvoiceProposal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCategoryItem = group.Add(new VocabularyKey(nameof(DefaultCategoryItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemDeleteReducedToZero = group.Add(new VocabularyKey(nameof(ItemDeleteReducedToZero), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNeverLedgerConsum = group.Add(new VocabularyKey(nameof(ItemNeverLedgerConsum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemNeverLedgerPL = group.Add(new VocabularyKey(nameof(IsItemNeverLedgerPL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemReduceCostPriority1 = group.Add(new VocabularyKey(nameof(ItemReduceCostPriority1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemReduceCostPriority2 = group.Add(new VocabularyKey(nameof(ItemReduceCostPriority2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemReduceCostPriority3 = group.Add(new VocabularyKey(nameof(ItemReduceCostPriority3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemReduceCostPriority4 = group.Add(new VocabularyKey(nameof(ItemReduceCostPriority4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemReduceCostPriority5 = group.Add(new VocabularyKey(nameof(ItemReduceCostPriority5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemMinimumRequirement = group.Add(new VocabularyKey(nameof(ItemMinimumRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrueRevenue = group.Add(new VocabularyKey(nameof(AccrueRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Adjustment = group.Add(new VocabularyKey(nameof(Adjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Estimate = group.Add(new VocabularyKey(nameof(Estimate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostCosts = group.Add(new VocabularyKey(nameof(PostCosts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Subscription = group.Add(new VocabularyKey(nameof(Subscription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovedTimesheetPosting = group.Add(new VocabularyKey(nameof(ApprovedTimesheetPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumNumberOfTimesheetsPerPeriod = group.Add(new VocabularyKey(nameof(MaximumNumberOfTimesheetsPerPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodOfPayment = group.Add(new VocabularyKey(nameof(MethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumTimeIncrement = group.Add(new VocabularyKey(nameof(MinimumTimeIncrement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MissingTimesheetsEmailId = group.Add(new VocabularyKey(nameof(MissingTimesheetsEmailId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastModel = group.Add(new VocabularyKey(nameof(ForecastModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FolderForMicrosoftProjectFiles = group.Add(new VocabularyKey(nameof(FolderForMicrosoftProjectFiles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaveMicrosoftProjectFilesTo = group.Add(new VocabularyKey(nameof(SaveMicrosoftProjectFilesTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPaymentCriteria = group.Add(new VocabularyKey(nameof(IsPaymentCriteria), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalBudget = group.Add(new VocabularyKey(nameof(OriginalBudget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPostingLevel = group.Add(new VocabularyKey(nameof(DefaultPostingLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingMethod = group.Add(new VocabularyKey(nameof(PostingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionTypesControlled = group.Add(new VocabularyKey(nameof(TransactionTypesControlled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetControlInterval = group.Add(new VocabularyKey(nameof(BudgetControlInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectBudgetManagement = group.Add(new VocabularyKey(nameof(ProjectBudgetManagement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetOverrunDefault = group.Add(new VocabularyKey(nameof(BudgetOverrunDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NegativeBudgetsToBeCarriedForwardAllowed = group.Add(new VocabularyKey(nameof(NegativeBudgetsToBeCarriedForwardAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCarryForwardRemainingBudgets = group.Add(new VocabularyKey(nameof(IsCarryForwardRemainingBudgets), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostControlMethods = group.Add(new VocabularyKey(nameof(CostControlMethods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetSubproductionToConsumed = group.Add(new VocabularyKey(nameof(SetSubproductionToConsumed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PromptForCustomerInformation = group.Add(new VocabularyKey(nameof(PromptForCustomerInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PromptForCustomerInformationOnProject = group.Add(new VocabularyKey(nameof(PromptForCustomerInformationOnProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingBudget = group.Add(new VocabularyKey(nameof(RemainingBudget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActivityExpenseForecastRequired = group.Add(new VocabularyKey(nameof(IsActivityExpenseForecastRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActivityExpenseJournalRequired = group.Add(new VocabularyKey(nameof(IsActivityExpenseJournalRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActivityHourForecastRequired = group.Add(new VocabularyKey(nameof(IsActivityHourForecastRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActivityHourJournalRequired = group.Add(new VocabularyKey(nameof(IsActivityHourJournalRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActivityItemForecastRequired = group.Add(new VocabularyKey(nameof(IsActivityItemForecastRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActivityItemJournalRequired = group.Add(new VocabularyKey(nameof(IsActivityItemJournalRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStartStopTimeRequired = group.Add(new VocabularyKey(nameof(IsStartStopTimeRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCategoryFee = group.Add(new VocabularyKey(nameof(DefaultCategoryFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultJournalNamesFee = group.Add(new VocabularyKey(nameof(DefaultJournalNamesFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasFinishedProjects = group.Add(new VocabularyKey(nameof(HasFinishedProjects), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasInactiveCategories = group.Add(new VocabularyKey(nameof(HasInactiveCategories), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasTerminatedWorkers = group.Add(new VocabularyKey(nameof(HasTerminatedWorkers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsHourCostInConsumptionStatementIncluded = group.Add(new VocabularyKey(nameof(IsHourCostInConsumptionStatementIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsHourQuantityInConsumptionStatementIncluded = group.Add(new VocabularyKey(nameof(IsHourQuantityInConsumptionStatementIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsHourCostInProfitLossStatementIncluded = group.Add(new VocabularyKey(nameof(IsHourCostInProfitLossStatementIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsHourQuantityInProfitLossStatementIncluded = group.Add(new VocabularyKey(nameof(IsHourQuantityInProfitLossStatementIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculationDateType = group.Add(new VocabularyKey(nameof(CalculationDateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupMethod = group.Add(new VocabularyKey(nameof(SalesTaxGroupMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroupMethod = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroupMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroupOnAcc = group.Add(new VocabularyKey(nameof(TaxItemGroupOnAcc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimesheetJournal = group.Add(new VocabularyKey(nameof(TimesheetJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowTimeRangeOverlap = group.Add(new VocabularyKey(nameof(AllowTimeRangeOverlap), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasTimeRegistration = group.Add(new VocabularyKey(nameof(HasTimeRegistration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbsenceProject = group.Add(new VocabularyKey(nameof(AbsenceProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTimesheetAuditTrailRequired = group.Add(new VocabularyKey(nameof(IsTimesheetAuditTrailRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFutureTimesheetEntriesBlocked = group.Add(new VocabularyKey(nameof(IsFutureTimesheetEntriesBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowTimesheetChangeReason = group.Add(new VocabularyKey(nameof(AllowTimesheetChangeReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireTimesheetChangeReason = group.Add(new VocabularyKey(nameof(RequireTimesheetChangeReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateAbsence = group.Add(new VocabularyKey(nameof(ValidateAbsence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalEstimatePostingTolerance = group.Add(new VocabularyKey(nameof(TotalEstimatePostingTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalBudget = group.Add(new VocabularyKey(nameof(TotalBudget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseReport = group.Add(new VocabularyKey(nameof(ExpenseReport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourJournal = group.Add(new VocabularyKey(nameof(HourJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemJournal = group.Add(new VocabularyKey(nameof(ItemJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRequirement = group.Add(new VocabularyKey(nameof(ItemRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Production = group.Add(new VocabularyKey(nameof(Production), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrder = group.Add(new VocabularyKey(nameof(PurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRequisition = group.Add(new VocabularyKey(nameof(PurchaseRequisition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrder = group.Add(new VocabularyKey(nameof(SalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Timesheets = group.Add(new VocabularyKey(nameof(Timesheets), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TravelRequisition = group.Add(new VocabularyKey(nameof(TravelRequisition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoice = group.Add(new VocabularyKey(nameof(VendorInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AfterEliminationDate = group.Add(new VocabularyKey(nameof(AfterEliminationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BeforeEliminationDate = group.Add(new VocabularyKey(nameof(BeforeEliminationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseAdjustmentDateAsNewProjectDate = group.Add(new VocabularyKey(nameof(UseAdjustmentDateAsNewProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseBudgetControl = group.Add(new VocabularyKey(nameof(UseBudgetControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseFavorites = group.Add(new VocabularyKey(nameof(UseFavorites), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UtilizationRate = group.Add(new VocabularyKey(nameof(UtilizationRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidationWorkerCategory = group.Add(new VocabularyKey(nameof(ValidationWorkerCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidationWorkerProject = group.Add(new VocabularyKey(nameof(ValidationWorkerProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidationProjectCategory = group.Add(new VocabularyKey(nameof(ValidationProjectCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueAddedDecimals = group.Add(new VocabularyKey(nameof(ValueAddedDecimals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueAddedDisplay = group.Add(new VocabularyKey(nameof(ValueAddedDisplay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetVoucherDateTo = group.Add(new VocabularyKey(nameof(SetVoucherDateTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DayWeekStarts = group.Add(new VocabularyKey(nameof(DayWeekStarts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutomaticallySetAccountingDateToOpenLedgerPeriod = group.Add(new VocabularyKey(nameof(AutomaticallySetAccountingDateToOpenLedgerPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeMaterialBillable = group.Add(new VocabularyKey(nameof(TimeMaterialBillable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeMaterialEfficiency = group.Add(new VocabularyKey(nameof(TimeMaterialEfficiency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedPriceBillable = group.Add(new VocabularyKey(nameof(FixedPriceBillable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedPriceEfficiency = group.Add(new VocabularyKey(nameof(FixedPriceEfficiency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvestmentBillable = group.Add(new VocabularyKey(nameof(InvestmentBillable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvestmentEfficiency = group.Add(new VocabularyKey(nameof(InvestmentEfficiency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalCostBillable = group.Add(new VocabularyKey(nameof(InternalCostBillable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalCostEfficiency = group.Add(new VocabularyKey(nameof(InternalCostEfficiency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProjectsBillable = group.Add(new VocabularyKey(nameof(TimeProjectsBillable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProjectsEfficiency = group.Add(new VocabularyKey(nameof(TimeProjectsEfficiency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapacityPlanningPlannedOrder = group.Add(new VocabularyKey(nameof(CapacityPlanningPlannedOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapacityPlanningProduction = group.Add(new VocabularyKey(nameof(CapacityPlanningProduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultWorkingCalendar = group.Add(new VocabularyKey(nameof(DefaultWorkingCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsHourSchedulingEnabled = group.Add(new VocabularyKey(nameof(IsHourSchedulingEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableCancelSettledProjectInvoice = group.Add(new VocabularyKey(nameof(EnableCancelSettledProjectInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEnableAlternativeAccountForCancellation = group.Add(new VocabularyKey(nameof(IsEnableAlternativeAccountForCancellation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthorizedSignatory = group.Add(new VocabularyKey(nameof(AuthorizedSignatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DesignationOfSignatory = group.Add(new VocabularyKey(nameof(DesignationOfSignatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableCancelSettledDebitNote = group.Add(new VocabularyKey(nameof(EnableCancelSettledDebitNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoicePrintingByCategory = group.Add(new VocabularyKey(nameof(IsInvoicePrintingByCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoicePrintingByTransactionText = group.Add(new VocabularyKey(nameof(IsInvoicePrintingByTransactionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoicePrintingByEmployee = group.Add(new VocabularyKey(nameof(IsInvoicePrintingByEmployee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoicePrintingByInvoiceType = group.Add(new VocabularyKey(nameof(IsInvoicePrintingByInvoiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoicePrintingByLineSpecific = group.Add(new VocabularyKey(nameof(IsInvoicePrintingByLineSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPSameState = group.Add(new VocabularyKey(nameof(CFOPSameState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPOtherState = group.Add(new VocabularyKey(nameof(CFOPOtherState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPOutsideCountryRegion = group.Add(new VocabularyKey(nameof(CFOPOutsideCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPIdSameState = group.Add(new VocabularyKey(nameof(CFOPIdSameState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPIdOtherState = group.Add(new VocabularyKey(nameof(CFOPIdOtherState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPIdOutsideCountryRegion = group.Add(new VocabularyKey(nameof(CFOPIdOutsideCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSplitInvoiceBasedOnServiceCode = group.Add(new VocabularyKey(nameof(IsSplitInvoiceBasedOnServiceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NoOneTimeCustomersForProjectContracts = group.Add(new VocabularyKey(nameof(NoOneTimeCustomersForProjectContracts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralBudgetReservation = group.Add(new VocabularyKey(nameof(GeneralBudgetReservation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeServiceEnableService = group.Add(new VocabularyKey(nameof(TimeServiceEnableService), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeServiceEnableDefaultLineProperty = group.Add(new VocabularyKey(nameof(TimeServiceEnableDefaultLineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeServiceVisibilityActivity = group.Add(new VocabularyKey(nameof(TimeServiceVisibilityActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeServiceVisibilityCategory = group.Add(new VocabularyKey(nameof(TimeServiceVisibilityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeServiceVisibilityCustomer = group.Add(new VocabularyKey(nameof(TimeServiceVisibilityCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeServiceVisibilityExternalComment = group.Add(new VocabularyKey(nameof(TimeServiceVisibilityExternalComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeServiceVisibilityInternalComment = group.Add(new VocabularyKey(nameof(TimeServiceVisibilityInternalComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeServiceVisibilityItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(TimeServiceVisibilityItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeServiceVisibilityLineProperty = group.Add(new VocabularyKey(nameof(TimeServiceVisibilityLineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeServiceVisibilitySalesTaxGroup = group.Add(new VocabularyKey(nameof(TimeServiceVisibilitySalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowSalesOrdersForMultipleFundingSources = group.Add(new VocabularyKey(nameof(AllowSalesOrdersForMultipleFundingSources), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ItemLumpSumAllocationKey { get; private set; }
        public VocabularyKey TermsOfPaymentForHours { get; private set; }
        public VocabularyKey ActualCostAfterEstimateDate { get; private set; }
        public VocabularyKey CommittedCostAfterEstimateDate { get; private set; }
        public VocabularyKey CommittedCostUpToEstimateDate { get; private set; }
        public VocabularyKey IsAutoupdateField { get; private set; }
        public VocabularyKey IsBudgetControlOutsideTheProjectHierarchyAllowed { get; private set; }
        public VocabularyKey IsDateCorrectionsOnTimesheetsAllowed { get; private set; }
        public VocabularyKey IsEliminationWithoutPostingEstimatesAllowed { get; private set; }
        public VocabularyKey CanAlwaysCreateAdjustmentTransaction { get; private set; }
        public VocabularyKey AmountInMillions { get; private set; }
        public VocabularyKey AmountInThousands { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey UserGroup { get; private set; }
        public VocabularyKey IsItemConsumption { get; private set; }
        public VocabularyKey BeginningBalances { get; private set; }
        public VocabularyKey CommittedCost { get; private set; }
        public VocabularyKey BillingRuleFeeJournal { get; private set; }
        public VocabularyKey DefaultCategoryExpense { get; private set; }
        public VocabularyKey DefaultCostTemplate { get; private set; }
        public VocabularyKey IsCreateItemRequirement { get; private set; }
        public VocabularyKey CreditLineError { get; private set; }
        public VocabularyKey SetTheCostPriceAsTheSalesPriceByDefault { get; private set; }
        public VocabularyKey DefaultItemAllocationKey { get; private set; }
        public VocabularyKey DefaultCategory { get; private set; }
        public VocabularyKey DefaultSubprojectIDFormat { get; private set; }
        public VocabularyKey DisplayTransactions { get; private set; }
        public VocabularyKey DefaultProjectType { get; private set; }
        public VocabularyKey Eliminated { get; private set; }
        public VocabularyKey DefaultCategoryHour { get; private set; }
        public VocabularyKey DefaultJournalNamesHour { get; private set; }
        public VocabularyKey CheckBudgetOnDocumentLineSave { get; private set; }
        public VocabularyKey IsIntercompanyResourceSchedulingAndTimesheetsEnabled { get; private set; }
        public VocabularyKey IsProcessingInvoiceProposalsInWorkflowEnabled { get; private set; }
        public VocabularyKey Estimated { get; private set; }
        public VocabularyKey ExpenseDeleteReducedToZero { get; private set; }
        public VocabularyKey ExpenseJournalNameId { get; private set; }
        public VocabularyKey ExpenseLumpSumAllocationKey { get; private set; }
        public VocabularyKey ExpenseReduceCostPriority1 { get; private set; }
        public VocabularyKey ExpenseReduceCostPriority2 { get; private set; }
        public VocabularyKey ExpenseReduceCostPriority3 { get; private set; }
        public VocabularyKey ExpenseReduceCostPriority4 { get; private set; }
        public VocabularyKey ExpenseReduceCostPriority5 { get; private set; }
        public VocabularyKey MinimumRequirement { get; private set; }
        public VocabularyKey GeneralBufferDays { get; private set; }
        public VocabularyKey TermsOfPaymentForExpenses { get; private set; }
        public VocabularyKey TermsOfPaymentForItems { get; private set; }
        public VocabularyKey IsAllocationSettingsLocked { get; private set; }
        public VocabularyKey ApplyPrioritySettingsFirstOrLastInFundingAllocationOrder { get; private set; }
        public VocabularyKey GrossMarginDecimals { get; private set; }
        public VocabularyKey GrossMarginRatio { get; private set; }
        public VocabularyKey HideActivity { get; private set; }
        public VocabularyKey HideCategory { get; private set; }
        public VocabularyKey HideExternalComments { get; private set; }
        public VocabularyKey HideLineProperty { get; private set; }
        public VocabularyKey HourDeleteReducedToZero { get; private set; }
        public VocabularyKey HourQtyDecimals { get; private set; }
        public VocabularyKey HourReduceCostPriority1 { get; private set; }
        public VocabularyKey HourReduceCostPriority2 { get; private set; }
        public VocabularyKey HourReduceCostPriority3 { get; private set; }
        public VocabularyKey HourReduceCostPriority4 { get; private set; }
        public VocabularyKey HourReduceCostPriority5 { get; private set; }
        public VocabularyKey HourReducedMinimumRequirement { get; private set; }
        public VocabularyKey DefaultJournalNameItem { get; private set; }
        public VocabularyKey Invoiced { get; private set; }
        public VocabularyKey InvoiceProposal { get; private set; }
        public VocabularyKey DefaultCategoryItem { get; private set; }
        public VocabularyKey ItemDeleteReducedToZero { get; private set; }
        public VocabularyKey ItemNeverLedgerConsum { get; private set; }
        public VocabularyKey IsItemNeverLedgerPL { get; private set; }
        public VocabularyKey ItemReduceCostPriority1 { get; private set; }
        public VocabularyKey ItemReduceCostPriority2 { get; private set; }
        public VocabularyKey ItemReduceCostPriority3 { get; private set; }
        public VocabularyKey ItemReduceCostPriority4 { get; private set; }
        public VocabularyKey ItemReduceCostPriority5 { get; private set; }
        public VocabularyKey ItemMinimumRequirement { get; private set; }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey AccrueRevenue { get; private set; }
        public VocabularyKey Adjustment { get; private set; }
        public VocabularyKey Estimate { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey PostCosts { get; private set; }
        public VocabularyKey Subscription { get; private set; }
        public VocabularyKey ApprovedTimesheetPosting { get; private set; }
        public VocabularyKey MaximumNumberOfTimesheetsPerPeriod { get; private set; }
        public VocabularyKey MethodOfPayment { get; private set; }
        public VocabularyKey MinimumTimeIncrement { get; private set; }
        public VocabularyKey MissingTimesheetsEmailId { get; private set; }
        public VocabularyKey ForecastModel { get; private set; }
        public VocabularyKey FolderForMicrosoftProjectFiles { get; private set; }
        public VocabularyKey SaveMicrosoftProjectFilesTo { get; private set; }
        public VocabularyKey IsPaymentCriteria { get; private set; }
        public VocabularyKey OriginalBudget { get; private set; }
        public VocabularyKey DefaultPostingLevel { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey PostingMethod { get; private set; }
        public VocabularyKey TransactionTypesControlled { get; private set; }
        public VocabularyKey BudgetControlInterval { get; private set; }
        public VocabularyKey ProjectBudgetManagement { get; private set; }
        public VocabularyKey BudgetOverrunDefault { get; private set; }
        public VocabularyKey NegativeBudgetsToBeCarriedForwardAllowed { get; private set; }
        public VocabularyKey IsCarryForwardRemainingBudgets { get; private set; }
        public VocabularyKey CostControlMethods { get; private set; }
        public VocabularyKey SetSubproductionToConsumed { get; private set; }
        public VocabularyKey PromptForCustomerInformation { get; private set; }
        public VocabularyKey PromptForCustomerInformationOnProject { get; private set; }
        public VocabularyKey RemainingBudget { get; private set; }
        public VocabularyKey IsActivityExpenseForecastRequired { get; private set; }
        public VocabularyKey IsActivityExpenseJournalRequired { get; private set; }
        public VocabularyKey IsActivityHourForecastRequired { get; private set; }
        public VocabularyKey IsActivityHourJournalRequired { get; private set; }
        public VocabularyKey IsActivityItemForecastRequired { get; private set; }
        public VocabularyKey IsActivityItemJournalRequired { get; private set; }
        public VocabularyKey IsStartStopTimeRequired { get; private set; }
        public VocabularyKey DefaultCategoryFee { get; private set; }
        public VocabularyKey DefaultJournalNamesFee { get; private set; }
        public VocabularyKey HasFinishedProjects { get; private set; }
        public VocabularyKey HasInactiveCategories { get; private set; }
        public VocabularyKey HasTerminatedWorkers { get; private set; }
        public VocabularyKey IsHourCostInConsumptionStatementIncluded { get; private set; }
        public VocabularyKey IsHourQuantityInConsumptionStatementIncluded { get; private set; }
        public VocabularyKey IsHourCostInProfitLossStatementIncluded { get; private set; }
        public VocabularyKey IsHourQuantityInProfitLossStatementIncluded { get; private set; }
        public VocabularyKey CalculationDateType { get; private set; }
        public VocabularyKey SalesTaxGroupMethod { get; private set; }
        public VocabularyKey ItemSalesTaxGroupMethod { get; private set; }
        public VocabularyKey TaxItemGroupOnAcc { get; private set; }
        public VocabularyKey TimesheetJournal { get; private set; }
        public VocabularyKey AllowTimeRangeOverlap { get; private set; }
        public VocabularyKey HasTimeRegistration { get; private set; }
        public VocabularyKey AbsenceProject { get; private set; }
        public VocabularyKey IsTimesheetAuditTrailRequired { get; private set; }
        public VocabularyKey IsFutureTimesheetEntriesBlocked { get; private set; }
        public VocabularyKey AllowTimesheetChangeReason { get; private set; }
        public VocabularyKey RequireTimesheetChangeReason { get; private set; }
        public VocabularyKey ValidateAbsence { get; private set; }
        public VocabularyKey TotalEstimatePostingTolerance { get; private set; }
        public VocabularyKey TotalBudget { get; private set; }
        public VocabularyKey ExpenseReport { get; private set; }
        public VocabularyKey HourJournal { get; private set; }
        public VocabularyKey ItemJournal { get; private set; }
        public VocabularyKey ItemRequirement { get; private set; }
        public VocabularyKey Production { get; private set; }
        public VocabularyKey PurchaseOrder { get; private set; }
        public VocabularyKey PurchaseRequisition { get; private set; }
        public VocabularyKey SalesOrder { get; private set; }
        public VocabularyKey Timesheets { get; private set; }
        public VocabularyKey TravelRequisition { get; private set; }
        public VocabularyKey VendorInvoice { get; private set; }
        public VocabularyKey AfterEliminationDate { get; private set; }
        public VocabularyKey BeforeEliminationDate { get; private set; }
        public VocabularyKey UseAdjustmentDateAsNewProjectDate { get; private set; }
        public VocabularyKey UseBudgetControl { get; private set; }
        public VocabularyKey UseFavorites { get; private set; }
        public VocabularyKey UtilizationRate { get; private set; }
        public VocabularyKey ValidationWorkerCategory { get; private set; }
        public VocabularyKey ValidationWorkerProject { get; private set; }
        public VocabularyKey ValidationProjectCategory { get; private set; }
        public VocabularyKey ValueAddedDecimals { get; private set; }
        public VocabularyKey ValueAddedDisplay { get; private set; }
        public VocabularyKey SetVoucherDateTo { get; private set; }
        public VocabularyKey DayWeekStarts { get; private set; }
        public VocabularyKey AutomaticallySetAccountingDateToOpenLedgerPeriod { get; private set; }
        public VocabularyKey CategoryHierarchy { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey TimeMaterialBillable { get; private set; }
        public VocabularyKey TimeMaterialEfficiency { get; private set; }
        public VocabularyKey FixedPriceBillable { get; private set; }
        public VocabularyKey FixedPriceEfficiency { get; private set; }
        public VocabularyKey InvestmentBillable { get; private set; }
        public VocabularyKey InvestmentEfficiency { get; private set; }
        public VocabularyKey InternalCostBillable { get; private set; }
        public VocabularyKey InternalCostEfficiency { get; private set; }
        public VocabularyKey TimeProjectsBillable { get; private set; }
        public VocabularyKey TimeProjectsEfficiency { get; private set; }
        public VocabularyKey CapacityPlanningPlannedOrder { get; private set; }
        public VocabularyKey CapacityPlanningProduction { get; private set; }
        public VocabularyKey DefaultWorkingCalendar { get; private set; }
        public VocabularyKey IsHourSchedulingEnabled { get; private set; }
        public VocabularyKey EnableCancelSettledProjectInvoice { get; private set; }
        public VocabularyKey IsEnableAlternativeAccountForCancellation { get; private set; }
        public VocabularyKey AuthorizedSignatory { get; private set; }
        public VocabularyKey DesignationOfSignatory { get; private set; }
        public VocabularyKey EnableCancelSettledDebitNote { get; private set; }
        public VocabularyKey IsInvoicePrintingByCategory { get; private set; }
        public VocabularyKey IsInvoicePrintingByTransactionText { get; private set; }
        public VocabularyKey IsInvoicePrintingByEmployee { get; private set; }
        public VocabularyKey IsInvoicePrintingByInvoiceType { get; private set; }
        public VocabularyKey IsInvoicePrintingByLineSpecific { get; private set; }
        public VocabularyKey CFOPSameState { get; private set; }
        public VocabularyKey CFOPOtherState { get; private set; }
        public VocabularyKey CFOPOutsideCountryRegion { get; private set; }
        public VocabularyKey CFOPIdSameState { get; private set; }
        public VocabularyKey CFOPIdOtherState { get; private set; }
        public VocabularyKey CFOPIdOutsideCountryRegion { get; private set; }
        public VocabularyKey IsSplitInvoiceBasedOnServiceCode { get; private set; }
        public VocabularyKey NoOneTimeCustomersForProjectContracts { get; private set; }
        public VocabularyKey GeneralBudgetReservation { get; private set; }
        public VocabularyKey TimeServiceEnableService { get; private set; }
        public VocabularyKey TimeServiceEnableDefaultLineProperty { get; private set; }
        public VocabularyKey TimeServiceVisibilityActivity { get; private set; }
        public VocabularyKey TimeServiceVisibilityCategory { get; private set; }
        public VocabularyKey TimeServiceVisibilityCustomer { get; private set; }
        public VocabularyKey TimeServiceVisibilityExternalComment { get; private set; }
        public VocabularyKey TimeServiceVisibilityInternalComment { get; private set; }
        public VocabularyKey TimeServiceVisibilityItemSalesTaxGroup { get; private set; }
        public VocabularyKey TimeServiceVisibilityLineProperty { get; private set; }
        public VocabularyKey TimeServiceVisibilitySalesTaxGroup { get; private set; }
        public VocabularyKey AllowSalesOrdersForMultipleFundingSources { get; private set; }
    }
}