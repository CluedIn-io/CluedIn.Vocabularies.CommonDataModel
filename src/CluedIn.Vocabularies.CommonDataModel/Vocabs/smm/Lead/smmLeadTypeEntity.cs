using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmLeadTypeEntityVocabulary : SimpleVocabulary
    {
        public SmmLeadTypeEntityVocabulary()
        {
            VocabularyName = "Smm Lead Type Entity";
            KeyPrefix = "commonDataModel.smmleadtypeentity";
            KeySeparator = ".";
            Grouping = "/SmmLeadTypeEntity";

            AddGroup("SmmLeadTypeEntity Details", group =>
            {
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey TypeId { get; private set; }
    }
}