using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailBarcodeMaskEntityVocabulary : SimpleVocabulary
    {
        public RetailBarcodeMaskEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailBarcodeMaskEntity";
            KeyPrefix = "commonDataModel.retailbarcodemaskentity";
            KeySeparator = ".";
            Grouping = "/RetailBarcodeMaskEntity";

            AddGroup("Common Data Model RetailBarcodeMaskEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mask = group.Add(new VocabularyKey(nameof(Mask), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaskId = group.Add(new VocabularyKey(nameof(MaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Prefix = group.Add(new VocabularyKey(nameof(Prefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Symbology = group.Add(new VocabularyKey(nameof(Symbology), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Mask { get; private set; }
        public VocabularyKey MaskId { get; private set; }
        public VocabularyKey Prefix { get; private set; }
        public VocabularyKey Symbology { get; private set; }
        public VocabularyKey Type { get; private set; }


    }
}