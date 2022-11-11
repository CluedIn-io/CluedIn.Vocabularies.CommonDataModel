using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPositivePayExportEntityVocabulary : SimpleVocabulary
    {
        public PayrollPositivePayExportEntityVocabulary()
        {
            VocabularyName = "PayrollPositivePayExportEntity";
            KeyPrefix = "commonDataModel.payrollpositivepayexportentity";
            KeySeparator = ".";
            Grouping = "/PayrollPositivePayExportEntity";

            AddGroup("PayrollPositivePayExportEntity Details", group =>
            {
                CompanyId = group.Add(new VocabularyKey(nameof(CompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositivePayNumber = group.Add(new VocabularyKey(nameof(PositivePayNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoidedDate = group.Add(new VocabularyKey(nameof(VoidedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoidedUser = group.Add(new VocabularyKey(nameof(VoidedUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChequeNum = group.Add(new VocabularyKey(nameof(ChequeNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountCur = group.Add(new VocabularyKey(nameof(AmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankNegInstRecipientName = group.Add(new VocabularyKey(nameof(BankNegInstRecipientName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChequeStatus = group.Add(new VocabularyKey(nameof(ChequeStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNum = group.Add(new VocabularyKey(nameof(RegistrationNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyPaymId = group.Add(new VocabularyKey(nameof(CompanyPaymId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey(nameof(FirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey(nameof(LastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumber = group.Add(new VocabularyKey(nameof(StreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street = group.Add(new VocabularyKey(nameof(Street), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey(nameof(ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey(nameof(Phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecipientType = group.Add(new VocabularyKey(nameof(RecipientType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountID = group.Add(new VocabularyKey(nameof(BankAccountID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CompanyId { get; private set; }
        public VocabularyKey PositivePayNumber { get; private set; }
        public VocabularyKey VoidedDate { get; private set; }
        public VocabularyKey VoidedUser { get; private set; }
        public VocabularyKey ChequeNum { get; private set; }
        public VocabularyKey AmountCur { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey BankNegInstRecipientName { get; private set; }
        public VocabularyKey ChequeStatus { get; private set; }
        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey RegistrationNum { get; private set; }
        public VocabularyKey CompanyPaymId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey StreetNumber { get; private set; }
        public VocabularyKey Street { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey ZipCode { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey RecipientType { get; private set; }
        public VocabularyKey BankAccountID { get; private set; }


    }
}