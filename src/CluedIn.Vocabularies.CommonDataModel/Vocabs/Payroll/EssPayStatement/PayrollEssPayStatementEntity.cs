using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEssPayStatementEntityVocabulary : SimpleVocabulary
    {
        public PayrollEssPayStatementEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollEssPayStatementEntity";
            KeyPrefix = "commonDataModel.payrollesspaystatemententity";
            KeySeparator = ".";
            Grouping = "/PayrollEssPayStatementEntity";

            AddGroup("Common Data Model PayrollEssPayStatementEntity Details", group =>
            {
                PayCycle = group.Add(new VocabularyKey(nameof(PayCycle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodStartDate = group.Add(new VocabularyKey(nameof(PeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodEndDate = group.Add(new VocabularyKey(nameof(PeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossPay = group.Add(new VocabularyKey(nameof(GrossPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetPay = group.Add(new VocabularyKey(nameof(NetPay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDate = group.Add(new VocabularyKey(nameof(PaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMethodType = group.Add(new VocabularyKey(nameof(PaymentMethodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PayCycle { get; private set; }
        public VocabularyKey PeriodStartDate { get; private set; }
        public VocabularyKey PeriodEndDate { get; private set; }
        public VocabularyKey GrossPay { get; private set; }
        public VocabularyKey NetPay { get; private set; }
        public VocabularyKey PayStatementNumber { get; private set; }
        public VocabularyKey PaymentDate { get; private set; }
        public VocabularyKey PaymentMethodType { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey Worker { get; private set; }


    }
}