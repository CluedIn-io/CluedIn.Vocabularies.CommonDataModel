using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AdvancedLedgerEntryEntityVocabulary : SimpleVocabulary
    {
        public AdvancedLedgerEntryEntityVocabulary()
        {
            VocabularyName = "Common Data Model AdvancedLedgerEntryEntity";
            KeyPrefix = "commonDataModel.advancedledgerentryentity";
            KeySeparator = ".";
            Grouping = "/AdvancedLedgerEntryEntity";

            AddGroup("Common Data Model AdvancedLedgerEntryEntity Details", group =>
            {
                LineCurrency = group.Add(new VocabularyKey(nameof(LineCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderId = group.Add(new VocabularyKey(nameof(HeaderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Credit = group.Add(new VocabularyKey(nameof(Credit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Debit = group.Add(new VocabularyKey(nameof(Debit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPrice = group.Add(new VocabularyKey(nameof(CostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineJournalizingDefinitionId = group.Add(new VocabularyKey(nameof(LineJournalizingDefinitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccount = group.Add(new VocabularyKey(nameof(LedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategory = group.Add(new VocabularyKey(nameof(ProjectCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectFundingSourceId = group.Add(new VocabularyKey(nameof(ProjectFundingSourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLineProperty = group.Add(new VocabularyKey(nameof(ProjectLineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesCurrency = group.Add(new VocabularyKey(nameof(ProjectSalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesTaxGroup = group.Add(new VocabularyKey(nameof(ProjectSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ProjectItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTransactionID = group.Add(new VocabularyKey(nameof(ProjectTransactionID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategoryId = group.Add(new VocabularyKey(nameof(ResourceCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionTextLine = group.Add(new VocabularyKey(nameof(TransactionTextLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderAccountingDate = group.Add(new VocabularyKey(nameof(HeaderAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalPeriodId = group.Add(new VocabularyKey(nameof(FiscalPeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderJournalizingDefinitionId = group.Add(new VocabularyKey(nameof(HeaderJournalizingDefinitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonId = group.Add(new VocabularyKey(nameof(ReasonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversingDate = group.Add(new VocabularyKey(nameof(ReversingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversingEntry = group.Add(new VocabularyKey(nameof(ReversingEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderCurrency = group.Add(new VocabularyKey(nameof(HeaderCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderTransactionNumber = group.Add(new VocabularyKey(nameof(HeaderTransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderTransactionText = group.Add(new VocabularyKey(nameof(HeaderTransactionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarYearId = group.Add(new VocabularyKey(nameof(FiscalCalendarYearId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarPeriodName = group.Add(new VocabularyKey(nameof(FiscalCalendarPeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarId = group.Add(new VocabularyKey(nameof(FiscalCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarYearName = group.Add(new VocabularyKey(nameof(FiscalCalendarYearName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendar = group.Add(new VocabularyKey(nameof(FiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderPostingDefinition = group.Add(new VocabularyKey(nameof(HeaderPostingDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinePostingDefinition = group.Add(new VocabularyKey(nameof(LinePostingDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjFundingSourceContract = group.Add(new VocabularyKey(nameof(ProjFundingSourceContract), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjFundingSource = group.Add(new VocabularyKey(nameof(ProjFundingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(LedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderTransactionStatus = group.Add(new VocabularyKey(nameof(HeaderTransactionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNBankTransactionType = group.Add(new VocabularyKey(nameof(PSNBankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNDoUpdateBank = group.Add(new VocabularyKey(nameof(PSNDoUpdateBank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNIsCorrection = group.Add(new VocabularyKey(nameof(PSNIsCorrection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LineCurrency { get; private set; }
        public VocabularyKey HeaderId { get; private set; }
        public VocabularyKey Credit { get; private set; }
        public VocabularyKey Debit { get; private set; }
        public VocabularyKey CostPrice { get; private set; }
        public VocabularyKey LineJournalizingDefinitionId { get; private set; }
        public VocabularyKey LedgerAccount { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ProjectActivityNumber { get; private set; }
        public VocabularyKey ProjectCategory { get; private set; }
        public VocabularyKey ProjectFundingSourceId { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey ProjectLineProperty { get; private set; }
        public VocabularyKey ProjectSalesCurrency { get; private set; }
        public VocabularyKey ProjectSalesTaxGroup { get; private set; }
        public VocabularyKey ProjectItemSalesTaxGroup { get; private set; }
        public VocabularyKey ProjectTransactionID { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ResourceCategoryId { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey TransactionTextLine { get; private set; }
        public VocabularyKey HeaderAccountingDate { get; private set; }
        public VocabularyKey FiscalPeriodId { get; private set; }
        public VocabularyKey HeaderJournalizingDefinitionId { get; private set; }
        public VocabularyKey ReasonId { get; private set; }
        public VocabularyKey ReversingDate { get; private set; }
        public VocabularyKey ReversingEntry { get; private set; }
        public VocabularyKey HeaderCurrency { get; private set; }
        public VocabularyKey HeaderTransactionNumber { get; private set; }
        public VocabularyKey HeaderTransactionText { get; private set; }
        public VocabularyKey FiscalCalendarYearId { get; private set; }
        public VocabularyKey FiscalCalendarPeriodName { get; private set; }
        public VocabularyKey FiscalCalendarId { get; private set; }
        public VocabularyKey FiscalCalendarYearName { get; private set; }
        public VocabularyKey FiscalCalendar { get; private set; }
        public VocabularyKey HeaderPostingDefinition { get; private set; }
        public VocabularyKey LinePostingDefinition { get; private set; }
        public VocabularyKey ProjFundingSourceContract { get; private set; }
        public VocabularyKey ProjFundingSource { get; private set; }
        public VocabularyKey LedgerAccountDisplayValue { get; private set; }
        public VocabularyKey HeaderTransactionStatus { get; private set; }
        public VocabularyKey PSNBankTransactionType { get; private set; }
        public VocabularyKey PSNDoUpdateBank { get; private set; }
        public VocabularyKey PSNIsCorrection { get; private set; }


    }
}