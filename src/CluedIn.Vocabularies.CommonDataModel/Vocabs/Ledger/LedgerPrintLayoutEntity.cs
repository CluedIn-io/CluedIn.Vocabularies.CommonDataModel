using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerPrintLayoutEntityVocabulary : SimpleVocabulary
    {
        public LedgerPrintLayoutEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerPrintLayoutEntity";
            KeyPrefix = "commonDataModel.ledgerprintlayoutentity";
            KeySeparator = ".";
            Grouping = "/LedgerPrintLayoutEntity";

            AddGroup("Common Data Model LedgerPrintLayoutEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintLayoutGroup = group.Add(new VocabularyKey(nameof(PrintLayoutGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintLayoutCode = group.Add(new VocabularyKey(nameof(PrintLayoutCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CodeDescription = group.Add(new VocabularyKey(nameof(CodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey PrintLayoutGroup { get; private set; }
        public VocabularyKey PrintLayoutCode { get; private set; }
        public VocabularyKey CodeDescription { get; private set; }


    }
}