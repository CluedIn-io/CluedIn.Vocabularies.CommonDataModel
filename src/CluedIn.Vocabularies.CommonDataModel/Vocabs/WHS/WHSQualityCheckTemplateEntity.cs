using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSQualityCheckTemplateEntityVocabulary : SimpleVocabulary
    {
        public WHSQualityCheckTemplateEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSQualityCheckTemplateEntity";
            KeyPrefix = "commonDataModel.whsqualitychecktemplateentity";
            KeySeparator = ".";
            Grouping = "/WHSQualityCheckTemplateEntity";

            AddGroup("Common Data Model WHSQualityCheckTemplateEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestGroupId = group.Add(new VocabularyKey(nameof(QualityTestGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceptancePolicy = group.Add(new VocabularyKey(nameof(AcceptancePolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessingPolicy = group.Add(new VocabularyKey(nameof(ProcessingPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey QualityTestGroupId { get; private set; }
        public VocabularyKey AcceptancePolicy { get; private set; }
        public VocabularyKey ProcessingPolicy { get; private set; }


    }
}