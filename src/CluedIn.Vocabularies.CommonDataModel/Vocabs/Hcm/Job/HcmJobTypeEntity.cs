using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobTypeEntityVocabulary : SimpleVocabulary
    {
        public HcmJobTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmJobTypeEntity";
            KeyPrefix = "commonDataModel.hcmjobtypeentity";
            KeySeparator = ".";
            Grouping = "/HcmJobTypeEntity";

            AddGroup("Common Data Model HcmJobTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExemptStatus = group.Add(new VocabularyKey(nameof(ExemptStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTypeId = group.Add(new VocabularyKey(nameof(JobTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaidHourly = group.Add(new VocabularyKey(nameof(PaidHourly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExemptStatus { get; private set; }
        public VocabularyKey JobTypeId { get; private set; }
        public VocabularyKey PaidHourly { get; private set; }


    }
}