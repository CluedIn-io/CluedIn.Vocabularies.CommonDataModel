using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobPreferredEducationDisciplineEntityVocabulary : SimpleVocabulary
    {
        public HcmJobPreferredEducationDisciplineEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmJobPreferredEducationDisciplineEntity";
            KeyPrefix = "commonDataModel.hcmjobpreferrededucationdisciplineentity";
            KeySeparator = ".";
            Grouping = "/HcmJobPreferredEducationDisciplineEntity";

            AddGroup("Common Data Model HcmJobPreferredEducationDisciplineEntity Details", group =>
            {
                Education = group.Add(new VocabularyKey(nameof(Education), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EducationId = group.Add(new VocabularyKey(nameof(EducationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Importance = group.Add(new VocabularyKey(nameof(Importance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Education { get; private set; }
        public VocabularyKey EducationId { get; private set; }
        public VocabularyKey Importance { get; private set; }
        public VocabularyKey Job { get; private set; }
        public VocabularyKey JobId { get; private set; }


    }
}