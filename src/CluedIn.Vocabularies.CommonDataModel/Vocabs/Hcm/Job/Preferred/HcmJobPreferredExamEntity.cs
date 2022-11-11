using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobPreferredExamEntityVocabulary : SimpleVocabulary
    {
        public HcmJobPreferredExamEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmJobPreferredExamEntity";
            KeyPrefix = "commonDataModel.hcmjobpreferredexamentity";
            KeySeparator = ".";
            Grouping = "/HcmJobPreferredExamEntity";

            AddGroup("Common Data Model HcmJobPreferredExamEntity Details", group =>
            {
                Test = group.Add(new VocabularyKey(nameof(Test), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestId = group.Add(new VocabularyKey(nameof(TestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Test { get; private set; }
        public VocabularyKey TestId { get; private set; }
        public VocabularyKey Job { get; private set; }
        public VocabularyKey JobId { get; private set; }


    }
}