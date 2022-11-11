using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentShipmentStatEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentShipmentStatEntityVocabulary()
        {
            VocabularyName = "FiscalDocumentShipmentStatEntity";
            KeyPrefix = "commonDataModel.fiscaldocumentshipmentstatentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentShipmentStatEntity";

            AddGroup("FiscalDocumentShipmentStatEntity Details", group =>
            {
                FiscalDocument = group.Add(new VocabularyKey(nameof(FiscalDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentDirection = group.Add(new VocabularyKey(nameof(FiscalDocumentDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentFiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalDocumentFiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentSeries = group.Add(new VocabularyKey(nameof(FiscalDocumentSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentStatus = group.Add(new VocabularyKey(nameof(FiscalDocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentThirdPartyCNPJorCPF = group.Add(new VocabularyKey(nameof(FiscalDocumentThirdPartyCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentVoucher = group.Add(new VocabularyKey(nameof(FiscalDocumentVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossWeight = group.Add(new VocabularyKey(nameof(GrossWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetWeight = group.Add(new VocabularyKey(nameof(NetWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VolumeQuantity = group.Add(new VocabularyKey(nameof(VolumeQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VolumeType = group.Add(new VocabularyKey(nameof(VolumeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FiscalDocument { get; private set; }
        public VocabularyKey FiscalDocumentDirection { get; private set; }
        public VocabularyKey FiscalDocumentFiscalEstablishmentId { get; private set; }
        public VocabularyKey FiscalDocumentNumber { get; private set; }
        public VocabularyKey FiscalDocumentSeries { get; private set; }
        public VocabularyKey FiscalDocumentStatus { get; private set; }
        public VocabularyKey FiscalDocumentThirdPartyCNPJorCPF { get; private set; }
        public VocabularyKey FiscalDocumentVoucher { get; private set; }
        public VocabularyKey GrossWeight { get; private set; }
        public VocabularyKey NetWeight { get; private set; }
        public VocabularyKey VolumeQuantity { get; private set; }
        public VocabularyKey VolumeType { get; private set; }


    }
}