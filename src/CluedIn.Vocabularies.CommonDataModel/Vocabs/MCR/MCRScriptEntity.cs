using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRScriptEntityVocabulary : SimpleVocabulary
    {
        public MCRScriptEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRScriptEntity";
            KeyPrefix = "commonDataModel.mcrscriptentity";
            KeySeparator = ".";
            Grouping = "/MCRScriptEntity";

            AddGroup("Common Data Model MCRScriptEntity Details", group =>
            {
                AssociationTypes = group.Add(new VocabularyKey(nameof(AssociationTypes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScriptUse = group.Add(new VocabularyKey(nameof(ScriptUse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScriptTitle = group.Add(new VocabularyKey(nameof(ScriptTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssociationTypes { get; private set; }
        public VocabularyKey ScriptUse { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey ScriptTitle { get; private set; }


    }
}