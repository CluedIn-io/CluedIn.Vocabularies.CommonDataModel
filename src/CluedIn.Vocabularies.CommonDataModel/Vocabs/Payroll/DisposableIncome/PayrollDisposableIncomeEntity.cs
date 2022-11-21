using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollDisposableIncomeEntityVocabulary : SimpleVocabulary
    {
        public PayrollDisposableIncomeEntityVocabulary()
        {
            VocabularyName = "Payroll Disposable Income Entity";
            KeyPrefix = "commonDataModel.payrolldisposableincomeentity";
            KeySeparator = ".";
            Grouping = "/PayrollDisposableIncomeEntity";

            AddGroup("PayrollDisposableIncomeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}