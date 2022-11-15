using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmInterestTypeEntityVocabulary : SimpleVocabulary
    {
        public SmmInterestTypeEntityVocabulary()
        {
            VocabularyName = "Smm Interest Type Entity";
            KeyPrefix = "commonDataModel.smminteresttypeentity";
            KeySeparator = ".";
            Grouping = "/SmmInterestTypeEntity";

            AddGroup("SmmInterestTypeEntity Details", group =>
            {
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeName = group.Add(new VocabularyKey(nameof(TypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey TypeName { get; private set; }
    }
}