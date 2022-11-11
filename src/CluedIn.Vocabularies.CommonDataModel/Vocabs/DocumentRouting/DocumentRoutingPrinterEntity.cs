using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DocumentRoutingPrinterEntityVocabulary : SimpleVocabulary
    {
        public DocumentRoutingPrinterEntityVocabulary()
        {
            VocabularyName = "DocumentRoutingPrinterEntity";
            KeyPrefix = "commonDataModel.documentroutingprinterentity";
            KeySeparator = ".";
            Grouping = "/DocumentRoutingPrinterEntity";

            AddGroup("DocumentRoutingPrinterEntity Details", group =>
            {
                ClientApp = group.Add(new VocabularyKey(nameof(ClientApp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer = group.Add(new VocabularyKey(nameof(Printer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterName = group.Add(new VocabularyKey(nameof(PrinterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterDescription = group.Add(new VocabularyKey(nameof(PrinterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterPath = group.Add(new VocabularyKey(nameof(PrinterPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterIsActive = group.Add(new VocabularyKey(nameof(PrinterIsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterId = group.Add(new VocabularyKey(nameof(PrinterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterCompanyId = group.Add(new VocabularyKey(nameof(PrinterCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClientApplicationId = group.Add(new VocabularyKey(nameof(ClientApplicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClientApplicationDescription = group.Add(new VocabularyKey(nameof(ClientApplicationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ClientApp { get; private set; }
        public VocabularyKey Printer { get; private set; }
        public VocabularyKey PrinterName { get; private set; }
        public VocabularyKey PrinterDescription { get; private set; }
        public VocabularyKey PrinterPath { get; private set; }
        public VocabularyKey PrinterIsActive { get; private set; }
        public VocabularyKey PrinterId { get; private set; }
        public VocabularyKey PrinterCompanyId { get; private set; }
        public VocabularyKey ClientApplicationId { get; private set; }
        public VocabularyKey ClientApplicationDescription { get; private set; }


    }
}