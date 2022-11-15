using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityProblemTypeEntityVocabulary : SimpleVocabulary
    {
        public InventQualityProblemTypeEntityVocabulary()
        {
            VocabularyName = "Invent Quality Problem Type Entity";
            KeyPrefix = "commonDataModel.inventqualityproblemtypeentity";
            KeySeparator = ".";
            Grouping = "/InventQualityProblemTypeEntity";

            AddGroup("InventQualityProblemTypeEntity Details", group =>
            {
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeId { get; private set; }
        public VocabularyKey TypeDescription { get; private set; }
    }
}