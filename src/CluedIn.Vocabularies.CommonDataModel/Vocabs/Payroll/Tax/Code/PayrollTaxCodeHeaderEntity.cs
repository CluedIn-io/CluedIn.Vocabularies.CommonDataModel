using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollTaxCodeHeaderEntityVocabulary : SimpleVocabulary
    {
        public PayrollTaxCodeHeaderEntityVocabulary()
        {
            VocabularyName = "Payroll Tax Code Header Entity";
            KeyPrefix = "commonDataModel.payrolltaxcodeheaderentity";
            KeySeparator = ".";
            Grouping = "/PayrollTaxCodeHeaderEntity";

            AddGroup("PayrollTaxCodeHeaderEntity Details", group =>
            {
                CodeId = group.Add(new VocabularyKey(nameof(CodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEmployerTax = group.Add(new VocabularyKey(nameof(IsEmployerTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPayStatementLineLocked = group.Add(new VocabularyKey(nameof(IsPayStatementLineLocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CodeId { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsEmployerTax { get; private set; }
        public VocabularyKey IsPayStatementLineLocked { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}