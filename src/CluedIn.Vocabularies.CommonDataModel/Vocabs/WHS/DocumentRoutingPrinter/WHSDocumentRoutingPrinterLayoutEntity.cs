using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSDocumentRoutingPrinterLayoutEntityVocabulary : SimpleVocabulary
    {
        public WHSDocumentRoutingPrinterLayoutEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSDocumentRoutingPrinterLayoutEntity";
            KeyPrefix = "commonDataModel.whsdocumentroutingprinterlayoutentity";
            KeySeparator = ".";
            Grouping = "/WHSDocumentRoutingPrinterLayoutEntity";

            AddGroup("Common Data Model WHSDocumentRoutingPrinterLayoutEntity Details", group =>
            {
                DocumentRoutingPrinterLayoutDescription = group.Add(new VocabularyKey(nameof(DocumentRoutingPrinterLayoutDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingPrinterLayoutId = group.Add(new VocabularyKey(nameof(DocumentRoutingPrinterLayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterLayoutTemplate = group.Add(new VocabularyKey(nameof(PrinterLayoutTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DocumentRoutingPrinterLayoutDescription { get; private set; }
        public VocabularyKey DocumentRoutingPrinterLayoutId { get; private set; }
        public VocabularyKey PrinterLayoutTemplate { get; private set; }


    }
}