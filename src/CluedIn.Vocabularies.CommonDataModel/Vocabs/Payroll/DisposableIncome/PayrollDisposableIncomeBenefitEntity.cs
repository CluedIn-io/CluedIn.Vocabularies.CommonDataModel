using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollDisposableIncomeBenefitEntityVocabulary : SimpleVocabulary
    {
        public PayrollDisposableIncomeBenefitEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollDisposableIncomeBenefitEntity";
            KeyPrefix = "commonDataModel.payrolldisposableincomebenefitentity";
            KeySeparator = ".";
            Grouping = "/PayrollDisposableIncomeBenefitEntity";

            AddGroup("Common Data Model PayrollDisposableIncomeBenefitEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposableIncome = group.Add(new VocabularyKey(nameof(DisposableIncome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey BenefitId { get; private set; }
        public VocabularyKey DisposableIncome { get; private set; }
        public VocabularyKey Benefit { get; private set; }


    }
}