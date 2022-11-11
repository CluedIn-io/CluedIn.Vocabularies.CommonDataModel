using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankPositivePayExportEntityVocabulary : SimpleVocabulary
    {
        public BankPositivePayExportEntityVocabulary()
        {
            VocabularyName = "BankPositivePayExportEntity";
            KeyPrefix = "commonDataModel.bankpositivepayexportentity";
            KeySeparator = ".";
            Grouping = "/BankPositivePayExportEntity";

            AddGroup("BankPositivePayExportEntity Details", group =>
            {
                CompanyId = group.Add(new VocabularyKey(nameof(CompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositivePayNumber = group.Add(new VocabularyKey(nameof(PositivePayNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoidedDate = group.Add(new VocabularyKey(nameof(VoidedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoidedUser = group.Add(new VocabularyKey(nameof(VoidedUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChequeNum = group.Add(new VocabularyKey(nameof(ChequeNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountCur = group.Add(new VocabularyKey(nameof(AmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChequeStatus = group.Add(new VocabularyKey(nameof(ChequeStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankNegInstRecipientName = group.Add(new VocabularyKey(nameof(BankNegInstRecipientName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecipientAccountNum = group.Add(new VocabularyKey(nameof(RecipientAccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNum = group.Add(new VocabularyKey(nameof(RegistrationNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyPaymId = group.Add(new VocabularyKey(nameof(CompanyPaymId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustGroup = group.Add(new VocabularyKey(nameof(CustGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendGroup = group.Add(new VocabularyKey(nameof(VendGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecipientType = group.Add(new VocabularyKey(nameof(RecipientType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CompanyId { get; private set; }
        public VocabularyKey PositivePayNumber { get; private set; }
        public VocabularyKey VoidedDate { get; private set; }
        public VocabularyKey VoidedUser { get; private set; }
        public VocabularyKey ChequeNum { get; private set; }
        public VocabularyKey AmountCur { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey ChequeStatus { get; private set; }
        public VocabularyKey BankNegInstRecipientName { get; private set; }
        public VocabularyKey RecipientAccountNum { get; private set; }
        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey RegistrationNum { get; private set; }
        public VocabularyKey CompanyPaymId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustGroup { get; private set; }
        public VocabularyKey VendGroup { get; private set; }
        public VocabularyKey RecipientType { get; private set; }
        public VocabularyKey BankAccountId { get; private set; }


    }
}