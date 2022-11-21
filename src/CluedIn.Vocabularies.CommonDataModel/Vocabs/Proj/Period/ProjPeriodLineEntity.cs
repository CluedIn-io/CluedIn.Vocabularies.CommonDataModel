using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjPeriodLineEntityVocabulary : SimpleVocabulary
    {
        public ProjPeriodLineEntityVocabulary()
        {
            VocabularyName = "Proj Period Line Entity";
            KeyPrefix = "commonDataModel.projperiodlineentity";
            KeySeparator = ".";
            Grouping = "/ProjPeriodLineEntity";

            AddGroup("ProjPeriodLineEntity Details", group =>
            {
                ModelId = group.Add(new VocabularyKey(nameof(ModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodFrom = group.Add(new VocabularyKey(nameof(PeriodFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodId = group.Add(new VocabularyKey(nameof(PeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodName = group.Add(new VocabularyKey(nameof(PeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodTo = group.Add(new VocabularyKey(nameof(PeriodTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ModelId { get; private set; }
        public VocabularyKey PeriodFrom { get; private set; }
        public VocabularyKey PeriodId { get; private set; }
        public VocabularyKey PeriodName { get; private set; }
        public VocabularyKey PeriodTo { get; private set; }
    }
}