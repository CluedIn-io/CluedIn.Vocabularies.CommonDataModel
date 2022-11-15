using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentHeaderTextReferencedProcessEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentHeaderTextReferencedProcessEntityVocabulary()
        {
            VocabularyName = "Fiscal Document Header Text Referenced Process Entity";
            KeyPrefix = "commonDataModel.fiscaldocumentheadertextreferencedprocessentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentHeaderTextReferencedProcessEntity";

            AddGroup("FiscalDocumentHeaderTextReferencedProcessEntity Details", group =>
            {
                Agency = group.Add(new VocabularyKey(nameof(Agency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocuRef = group.Add(new VocabularyKey(nameof(DocuRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentDirection = group.Add(new VocabularyKey(nameof(FiscalDocumentDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentFiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalDocumentFiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentHeaderTextId = group.Add(new VocabularyKey(nameof(FiscalDocumentHeaderTextId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentSeries = group.Add(new VocabularyKey(nameof(FiscalDocumentSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentStatus = group.Add(new VocabularyKey(nameof(FiscalDocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentThirdPartyCNPJorCPF = group.Add(new VocabularyKey(nameof(FiscalDocumentThirdPartyCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentVoucher = group.Add(new VocabularyKey(nameof(FiscalDocumentVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessNumber = group.Add(new VocabularyKey(nameof(ProcessNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefCompanyId = group.Add(new VocabularyKey(nameof(RefCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefTableId = group.Add(new VocabularyKey(nameof(RefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Agency { get; private set; }
        public VocabularyKey DocuRef { get; private set; }
        public VocabularyKey FiscalDocumentDirection { get; private set; }
        public VocabularyKey FiscalDocumentFiscalEstablishmentId { get; private set; }
        public VocabularyKey FiscalDocumentHeaderTextId { get; private set; }
        public VocabularyKey FiscalDocumentNumber { get; private set; }
        public VocabularyKey FiscalDocumentSeries { get; private set; }
        public VocabularyKey FiscalDocumentStatus { get; private set; }
        public VocabularyKey FiscalDocumentThirdPartyCNPJorCPF { get; private set; }
        public VocabularyKey FiscalDocumentVoucher { get; private set; }
        public VocabularyKey ProcessNumber { get; private set; }
        public VocabularyKey RefCompanyId { get; private set; }
        public VocabularyKey RefRecId { get; private set; }
        public VocabularyKey RefTableId { get; private set; }
    }
}