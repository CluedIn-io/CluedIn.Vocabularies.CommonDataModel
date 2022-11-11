using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollBankAccountDisbursementEntityVocabulary : SimpleVocabulary
    {
        public PayrollBankAccountDisbursementEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollBankAccountDisbursementEntity";
            KeyPrefix = "commonDataModel.payrollbankaccountdisbursemententity";
            KeySeparator = ".";
            Grouping = "/PayrollBankAccountDisbursementEntity";

            AddGroup("Common Data Model PayrollBankAccountDisbursementEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Remainder = group.Add(new VocabularyKey(nameof(Remainder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountIdentification = group.Add(new VocabularyKey(nameof(AccountIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountIdentificationId = group.Add(new VocabularyKey(nameof(AccountIdentificationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InPrenoteStatus = group.Add(new VocabularyKey(nameof(InPrenoteStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Remainder { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey AccountIdentification { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey AccountIdentificationId { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey InPrenoteStatus { get; private set; }


    }
}