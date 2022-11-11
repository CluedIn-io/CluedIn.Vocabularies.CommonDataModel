using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerOpeningSheetEntityVocabulary : SimpleVocabulary
    {
        public LedgerOpeningSheetEntityVocabulary()
        {
            VocabularyName = "LedgerOpeningSheetEntity";
            KeyPrefix = "commonDataModel.ledgeropeningsheetentity";
            KeySeparator = ".";
            Grouping = "/LedgerOpeningSheetEntity";

            AddGroup("LedgerOpeningSheetEntity Details", group =>
            {
                Sheet = group.Add(new VocabularyKey(nameof(Sheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostDate = group.Add(new VocabularyKey(nameof(PostDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcknowledgementDate = group.Add(new VocabularyKey(nameof(AcknowledgementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentOperationsTax = group.Add(new VocabularyKey(nameof(CurrentOperationsTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodCode = group.Add(new VocabularyKey(nameof(PeriodCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarPeriodName = group.Add(new VocabularyKey(nameof(FiscalCalendarPeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarYearName = group.Add(new VocabularyKey(nameof(FiscalCalendarYearName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarCalendarId = group.Add(new VocabularyKey(nameof(FiscalCalendarCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SumTrialBalance = group.Add(new VocabularyKey(nameof(SumTrialBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SumTransfer = group.Add(new VocabularyKey(nameof(SumTransfer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SumResult = group.Add(new VocabularyKey(nameof(SumResult), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SumBalance = group.Add(new VocabularyKey(nameof(SumBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SumCapital = group.Add(new VocabularyKey(nameof(SumCapital), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerOpeningTableMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(LedgerOpeningTableMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerOpeningTableChartOfAccountsName = group.Add(new VocabularyKey(nameof(LedgerOpeningTableChartOfAccountsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transfer = group.Add(new VocabularyKey(nameof(Transfer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrialBalance = group.Add(new VocabularyKey(nameof(TrialBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reconciled = group.Add(new VocabularyKey(nameof(Reconciled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Result = group.Add(new VocabularyKey(nameof(Result), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balance = group.Add(new VocabularyKey(nameof(Balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Capital = group.Add(new VocabularyKey(nameof(Capital), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsTax = group.Add(new VocabularyKey(nameof(OperationsTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Txt = group.Add(new VocabularyKey(nameof(Txt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerOpeningTransMainAccountMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(LedgerOpeningTransMainAccountMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerOpeningTransMainAccountChartOfAccountName = group.Add(new VocabularyKey(nameof(LedgerOpeningTransMainAccountChartOfAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(LedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerOpeningTransOffsetAccountMainAccountId = group.Add(new VocabularyKey(nameof(LedgerOpeningTransOffsetAccountMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerOpeningTransOffsetAccountChartOfAccountName = group.Add(new VocabularyKey(nameof(LedgerOpeningTransOffsetAccountChartOfAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Sheet { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey PostDate { get; private set; }
        public VocabularyKey AcknowledgementDate { get; private set; }
        public VocabularyKey CurrentOperationsTax { get; private set; }
        public VocabularyKey PeriodCode { get; private set; }
        public VocabularyKey FiscalCalendarPeriodName { get; private set; }
        public VocabularyKey FiscalCalendarYearName { get; private set; }
        public VocabularyKey FiscalCalendarCalendarId { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey SumTrialBalance { get; private set; }
        public VocabularyKey SumTransfer { get; private set; }
        public VocabularyKey SumResult { get; private set; }
        public VocabularyKey SumBalance { get; private set; }
        public VocabularyKey SumCapital { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey LedgerOpeningTableMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey LedgerOpeningTableChartOfAccountsName { get; private set; }
        public VocabularyKey Transfer { get; private set; }
        public VocabularyKey TrialBalance { get; private set; }
        public VocabularyKey Reconciled { get; private set; }
        public VocabularyKey Result { get; private set; }
        public VocabularyKey Balance { get; private set; }
        public VocabularyKey Capital { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey OperationsTax { get; private set; }
        public VocabularyKey Txt { get; private set; }
        public VocabularyKey LedgerOpeningTransMainAccountMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey LedgerOpeningTransMainAccountChartOfAccountName { get; private set; }
        public VocabularyKey LedgerAccountDisplayValue { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey LedgerOpeningTransOffsetAccountMainAccountId { get; private set; }
        public VocabularyKey LedgerOpeningTransOffsetAccountChartOfAccountName { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }


    }
}