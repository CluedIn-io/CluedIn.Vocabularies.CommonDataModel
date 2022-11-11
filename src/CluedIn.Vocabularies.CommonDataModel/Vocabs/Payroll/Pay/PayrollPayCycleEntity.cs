using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPayCycleEntityVocabulary : SimpleVocabulary
    {
        public PayrollPayCycleEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollPayCycleEntity";
            KeyPrefix = "commonDataModel.payrollpaycycleentity";
            KeySeparator = ".";
            Grouping = "/PayrollPayCycleEntity";

            AddGroup("Common Data Model PayrollPayCycleEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayCycleId = group.Add(new VocabularyKey(nameof(PayCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayCycleFrequency = group.Add(new VocabularyKey(nameof(PayCycleFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey PayCycleId { get; private set; }
        public VocabularyKey PayCycleFrequency { get; private set; }


    }
}