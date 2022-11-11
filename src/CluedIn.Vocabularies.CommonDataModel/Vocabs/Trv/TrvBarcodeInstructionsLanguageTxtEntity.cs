using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvBarcodeInstructionsLanguageTxtEntityVocabulary : SimpleVocabulary
    {
        public TrvBarcodeInstructionsLanguageTxtEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvBarcodeInstructionsLanguageTxtEntity";
            KeyPrefix = "commonDataModel.trvbarcodeinstructionslanguagetxtentity";
            KeySeparator = ".";
            Grouping = "/TrvBarcodeInstructionsLanguageTxtEntity";

            AddGroup("Common Data Model TrvBarcodeInstructionsLanguageTxtEntity Details", group =>
            {
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Language { get; private set; }
        public VocabularyKey Text { get; private set; }


    }
}