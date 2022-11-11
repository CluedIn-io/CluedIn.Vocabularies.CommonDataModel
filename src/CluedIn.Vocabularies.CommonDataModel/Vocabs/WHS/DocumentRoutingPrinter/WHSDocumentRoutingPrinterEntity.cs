using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSDocumentRoutingPrinterEntityVocabulary : SimpleVocabulary
    {
        public WHSDocumentRoutingPrinterEntityVocabulary()
        {
            VocabularyName = "WHSDocumentRoutingPrinterEntity";
            KeyPrefix = "commonDataModel.whsdocumentroutingprinterentity";
            KeySeparator = ".";
            Grouping = "/WHSDocumentRoutingPrinterEntity";

            AddGroup("WHSDocumentRoutingPrinterEntity Details", group =>
            {
                DocumentRouting = group.Add(new VocabularyKey(nameof(DocumentRouting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingPrinterLayoutId = group.Add(new VocabularyKey(nameof(DocumentRoutingPrinterLayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingPrinterName = group.Add(new VocabularyKey(nameof(DocumentRoutingPrinterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingWarehouseId = group.Add(new VocabularyKey(nameof(DocumentRoutingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingSequence = group.Add(new VocabularyKey(nameof(DocumentRoutingSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentRoutingWorkOrderType = group.Add(new VocabularyKey(nameof(DocumentRoutingWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DocumentRouting { get; private set; }
        public VocabularyKey DocumentRoutingPrinterLayoutId { get; private set; }
        public VocabularyKey DocumentRoutingPrinterName { get; private set; }
        public VocabularyKey DocumentRoutingWarehouseId { get; private set; }
        public VocabularyKey DocumentRoutingSequence { get; private set; }
        public VocabularyKey DocumentRoutingWorkOrderType { get; private set; }


    }
}