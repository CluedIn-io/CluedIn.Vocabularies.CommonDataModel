using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobBaseEntityVocabulary : SimpleVocabulary
    {
        public HcmJobBaseEntityVocabulary()
        {
            VocabularyName = "Hcm Job Base Entity";
            KeyPrefix = "commonDataModel.hcmjobbaseentity";
            KeySeparator = ".";
            Grouping = "/HcmJobBaseEntity";

            AddGroup("HcmJobBaseEntity Details", group =>
            {
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumNumberOfPositions = group.Add(new VocabularyKey(nameof(MaximumNumberOfPositions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowUnlimitedPositions = group.Add(new VocabularyKey(nameof(AllowUnlimitedPositions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey JobId { get; private set; }
        public VocabularyKey MaximumNumberOfPositions { get; private set; }
        public VocabularyKey AllowUnlimitedPositions { get; private set; }
    }
}