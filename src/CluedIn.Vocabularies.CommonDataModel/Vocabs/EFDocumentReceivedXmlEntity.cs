using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EFDocumentReceivedXmlEntityVocabulary : SimpleVocabulary
    {
        public EFDocumentReceivedXmlEntityVocabulary()
        {
            VocabularyName = "EFDocumentReceivedXmlEntity";
            KeyPrefix = "commonDataModel.efdocumentreceivedxmlentity";
            KeySeparator = ".";
            Grouping = "/EFDocumentReceivedXmlEntity";

            AddGroup("EFDocumentReceivedXmlEntity Details", group =>
            {
                Accesskey = group.Add(new VocabularyKey(nameof(Accesskey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CNPJ = group.Add(new VocabularyKey(nameof(CNPJ), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentReference = group.Add(new VocabularyKey(nameof(FiscalDocumentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Number = group.Add(new VocabularyKey(nameof(Number), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Series = group.Add(new VocabularyKey(nameof(Series), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentReference = group.Add(new VocabularyKey(nameof(FiscalEstablishmentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IBGECode = group.Add(new VocabularyKey(nameof(IBGECode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusFromSEFAZ = group.Add(new VocabularyKey(nameof(StatusFromSEFAZ), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateAndTimeOfTheLastInquiry = group.Add(new VocabularyKey(nameof(DateAndTimeOfTheLastInquiry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualInsertion = group.Add(new VocabularyKey(nameof(ManualInsertion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnCode = group.Add(new VocabularyKey(nameof(ReturnCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Accesskey { get; private set; }
        public VocabularyKey CNPJ { get; private set; }
        public VocabularyKey FiscalDocumentReference { get; private set; }
        public VocabularyKey Number { get; private set; }
        public VocabularyKey Series { get; private set; }
        public VocabularyKey FiscalEstablishmentReference { get; private set; }
        public VocabularyKey IBGECode { get; private set; }
        public VocabularyKey StatusFromSEFAZ { get; private set; }
        public VocabularyKey DateAndTimeOfTheLastInquiry { get; private set; }
        public VocabularyKey ManualInsertion { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey ReturnCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FiscalEstablishmentId { get; private set; }


    }
}