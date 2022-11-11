using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailBarcodeMaskCharacterEntityVocabulary : SimpleVocabulary
    {
        public RetailBarcodeMaskCharacterEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailBarcodeMaskCharacterEntity";
            KeyPrefix = "commonDataModel.retailbarcodemaskcharacterentity";
            KeySeparator = ".";
            Grouping = "/RetailBarcodeMaskCharacterEntity";

            AddGroup("Common Data Model RetailBarcodeMaskCharacterEntity Details", group =>
            {
                Character = group.Add(new VocabularyKey(nameof(Character), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CharacterType = group.Add(new VocabularyKey(nameof(CharacterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Character { get; private set; }
        public VocabularyKey CharacterType { get; private set; }
        public VocabularyKey Comment { get; private set; }


    }
}