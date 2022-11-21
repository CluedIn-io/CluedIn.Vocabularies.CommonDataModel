using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInfoCodeFiscalTextEntityVocabulary : SimpleVocabulary
    {
        public RetailInfoCodeFiscalTextEntityVocabulary()
        {
            VocabularyName = "Retail Info Code Fiscal Text Entity";
            KeyPrefix = "commonDataModel.retailinfocodefiscaltextentity";
            KeySeparator = ".";
            Grouping = "/RetailInfoCodeFiscalTextEntity";

            AddGroup("RetailInfoCodeFiscalTextEntity Details", group =>
            {
                InfoCodeNumber = group.Add(new VocabularyKey(nameof(InfoCodeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubcodeNumber = group.Add(new VocabularyKey(nameof(SubcodeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TextForFiscalReceipt = group.Add(new VocabularyKey(nameof(TextForFiscalReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintUserInputOnFiscalReceipt = group.Add(new VocabularyKey(nameof(PrintUserInputOnFiscalReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConnectorGroupNumber = group.Add(new VocabularyKey(nameof(ConnectorGroupNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey InfoCodeNumber { get; private set; }
        public VocabularyKey SubcodeNumber { get; private set; }
        public VocabularyKey TextForFiscalReceipt { get; private set; }
        public VocabularyKey PrintUserInputOnFiscalReceipt { get; private set; }
        public VocabularyKey ConnectorGroupNumber { get; private set; }
    }
}