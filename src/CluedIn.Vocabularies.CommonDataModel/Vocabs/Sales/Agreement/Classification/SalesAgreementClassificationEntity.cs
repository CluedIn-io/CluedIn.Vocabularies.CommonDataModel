using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesAgreementClassificationEntityVocabulary : SimpleVocabulary
    {
        public SalesAgreementClassificationEntityVocabulary()
        {
            VocabularyName = "Sales Agreement Classification Entity";
            KeyPrefix = "commonDataModel.salesagreementclassificationentity";
            KeySeparator = ".";
            Grouping = "/SalesAgreementClassificationEntity";

            AddGroup("SalesAgreementClassificationEntity Details", group =>
            {
                ClassificationDescription = group.Add(new VocabularyKey(nameof(ClassificationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassificationName = group.Add(new VocabularyKey(nameof(ClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ClassificationDescription { get; private set; }
        public VocabularyKey ClassificationName { get; private set; }
    }
}