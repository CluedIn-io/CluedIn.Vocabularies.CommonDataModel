using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentLineTextEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentLineTextEntityVocabulary()
        {
            VocabularyName = "Fiscal Document Line Text Entity";
            KeyPrefix = "commonDataModel.fiscaldocumentlinetextentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentLineTextEntity";

            AddGroup("FiscalDocumentLineTextEntity Details", group =>
            {
                DocuRef = group.Add(new VocabularyKey(nameof(DocuRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentDirection = group.Add(new VocabularyKey(nameof(FiscalDocumentDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentFiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalDocumentFiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentLineNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentSeries = group.Add(new VocabularyKey(nameof(FiscalDocumentSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentStatus = group.Add(new VocabularyKey(nameof(FiscalDocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentThirdPartyCNPJorCPF = group.Add(new VocabularyKey(nameof(FiscalDocumentThirdPartyCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentVoucher = group.Add(new VocabularyKey(nameof(FiscalDocumentVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalInformation = group.Add(new VocabularyKey(nameof(FiscalInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Restriction = group.Add(new VocabularyKey(nameof(Restriction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TextId = group.Add(new VocabularyKey(nameof(TextId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefCompanyId = group.Add(new VocabularyKey(nameof(RefCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefTableId = group.Add(new VocabularyKey(nameof(RefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DocuRef { get; private set; }
        public VocabularyKey FiscalDocumentDirection { get; private set; }
        public VocabularyKey FiscalDocumentFiscalEstablishmentId { get; private set; }
        public VocabularyKey FiscalDocumentLineNumber { get; private set; }
        public VocabularyKey FiscalDocumentNumber { get; private set; }
        public VocabularyKey FiscalDocumentSeries { get; private set; }
        public VocabularyKey FiscalDocumentStatus { get; private set; }
        public VocabularyKey FiscalDocumentThirdPartyCNPJorCPF { get; private set; }
        public VocabularyKey FiscalDocumentVoucher { get; private set; }
        public VocabularyKey FiscalInformation { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey Restriction { get; private set; }
        public VocabularyKey TextId { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey RefCompanyId { get; private set; }
        public VocabularyKey RefRecId { get; private set; }
        public VocabularyKey RefTableId { get; private set; }
    }
}