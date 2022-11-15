using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmPersonalCharacterTypeEntityVocabulary : SimpleVocabulary
    {
        public SmmPersonalCharacterTypeEntityVocabulary()
        {
            VocabularyName = "Smm Personal Character Type Entity";
            KeyPrefix = "commonDataModel.smmpersonalcharactertypeentity";
            KeySeparator = ".";
            Grouping = "/SmmPersonalCharacterTypeEntity";

            AddGroup("SmmPersonalCharacterTypeEntity Details", group =>
            {
                TypeName = group.Add(new VocabularyKey(nameof(TypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeName { get; private set; }
        public VocabularyKey TypeDescription { get; private set; }
    }
}