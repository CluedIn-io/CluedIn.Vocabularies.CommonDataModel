using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkAuditTemplateLineEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkAuditTemplateLineEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseWorkAuditTemplateLineEntity";
            KeyPrefix = "commonDataModel.whswarehouseworkaudittemplatelineentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkAuditTemplateLineEntity";

            AddGroup("WHSWarehouseWorkAuditTemplateLineEntity Details", group =>
            {
                LineFunctionType = group.Add(new VocabularyKey(nameof(LineFunctionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MobileDeviceMenuLabel = group.Add(new VocabularyKey(nameof(MobileDeviceMenuLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineSequenceNumber = group.Add(new VocabularyKey(nameof(LineSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinePrintFunctionPrintSettings = group.Add(new VocabularyKey(nameof(LinePrintFunctionPrintSettings), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineCustomMethod = group.Add(new VocabularyKey(nameof(LineCustomMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineEventFunctionEvent = group.Add(new VocabularyKey(nameof(LineEventFunctionEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkAuditTemplateId = group.Add(new VocabularyKey(nameof(WarehouseWorkAuditTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineReportFunctionReportName = group.Add(new VocabularyKey(nameof(LineReportFunctionReportName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LineFunctionType { get; private set; }
        public VocabularyKey MobileDeviceMenuLabel { get; private set; }
        public VocabularyKey LineSequenceNumber { get; private set; }
        public VocabularyKey LinePrintFunctionPrintSettings { get; private set; }
        public VocabularyKey LineCustomMethod { get; private set; }
        public VocabularyKey LineEventFunctionEvent { get; private set; }
        public VocabularyKey WarehouseWorkAuditTemplateId { get; private set; }
        public VocabularyKey LineReportFunctionReportName { get; private set; }


    }
}