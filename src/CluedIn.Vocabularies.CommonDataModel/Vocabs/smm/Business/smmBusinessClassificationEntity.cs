using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmBusinessClassificationEntityVocabulary : SimpleVocabulary
    {
        public SmmBusinessClassificationEntityVocabulary()
        {
            VocabularyName = "Smm Business Classification Entity";
            KeyPrefix = "commonDataModel.smmbusinessclassificationentity";
            KeySeparator = ".";
            Grouping = "/SmmBusinessClassificationEntity";

            AddGroup("SmmBusinessClassificationEntity Details", group =>
            {
                ClassificationCode = group.Add(new VocabularyKey(nameof(ClassificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassificationDescription = group.Add(new VocabularyKey(nameof(ClassificationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ClassificationCode { get; private set; }
        public VocabularyKey ClassificationDescription { get; private set; }
    }
}