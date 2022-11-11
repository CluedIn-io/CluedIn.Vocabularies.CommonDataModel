using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEssPayStatementLineEntityVocabulary : SimpleVocabulary
    {
        public PayrollEssPayStatementLineEntityVocabulary()
        {
            VocabularyName = "PayrollEssPayStatementLineEntity";
            KeyPrefix = "commonDataModel.payrollesspaystatementlineentity";
            KeySeparator = ".";
            Grouping = "/PayrollEssPayStatementLineEntity";

            AddGroup("PayrollEssPayStatementLineEntity Details", group =>
            {
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDate = group.Add(new VocabularyKey(nameof(PaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Type { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey PayStatementNumber { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PaymentDate { get; private set; }


    }
}