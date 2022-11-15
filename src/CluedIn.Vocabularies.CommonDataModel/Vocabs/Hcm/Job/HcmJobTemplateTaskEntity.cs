using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobTemplateTaskEntityVocabulary : SimpleVocabulary
    {
        public HcmJobTemplateTaskEntityVocabulary()
        {
            VocabularyName = "Hcm Job Template Task Entity";
            KeyPrefix = "commonDataModel.hcmjobtemplatetaskentity";
            KeySeparator = ".";
            Grouping = "/HcmJobTemplateTaskEntity";

            AddGroup("HcmJobTemplateTaskEntity Details", group =>
            {
                JobTask = group.Add(new VocabularyKey(nameof(JobTask), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTemplate = group.Add(new VocabularyKey(nameof(JobTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTaskId = group.Add(new VocabularyKey(nameof(JobTaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTemplateId = group.Add(new VocabularyKey(nameof(JobTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey JobTask { get; private set; }
        public VocabularyKey JobTemplate { get; private set; }
        public VocabularyKey Note { get; private set; }
        public VocabularyKey JobTaskId { get; private set; }
        public VocabularyKey JobTemplateId { get; private set; }
    }
}