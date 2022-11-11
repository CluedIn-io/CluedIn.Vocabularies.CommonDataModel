using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25DebtPeriodEntityVocabulary : SimpleVocabulary
    {
        public RTax25DebtPeriodEntityVocabulary()
        {
            VocabularyName = "RTax25DebtPeriodEntity";
            KeyPrefix = "commonDataModel.rtax25debtperiodentity";
            KeySeparator = ".";
            Grouping = "/RTax25DebtPeriodEntity";

            AddGroup("RTax25DebtPeriodEntity Details", group =>
            {
                PeriodDebtType = group.Add(new VocabularyKey(nameof(PeriodDebtType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                From = group.Add(new VocabularyKey(nameof(From), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                By = group.Add(new VocabularyKey(nameof(By), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebtType = group.Add(new VocabularyKey(nameof(DebtType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterField = group.Add(new VocabularyKey(nameof(RegisterField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PeriodDebtType { get; private set; }
        public VocabularyKey From { get; private set; }
        public VocabularyKey By { get; private set; }
        public VocabularyKey DebtType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RegisterField { get; private set; }
        public VocabularyKey Percent { get; private set; }


    }
}