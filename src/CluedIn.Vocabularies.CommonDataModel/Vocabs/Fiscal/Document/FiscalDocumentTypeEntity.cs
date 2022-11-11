using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentTypeEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentTypeEntityVocabulary()
        {
            VocabularyName = "FiscalDocumentTypeEntity";
            KeyPrefix = "commonDataModel.fiscaldocumenttypeentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentTypeEntity";

            AddGroup("FiscalDocumentTypeEntity Details", group =>
            {
                FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentType = group.Add(new VocabularyKey(nameof(FiscalDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Series = group.Add(new VocabularyKey(nameof(Series), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentIssueDate = group.Add(new VocabularyKey(nameof(FiscalDocumentIssueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentModel = group.Add(new VocabularyKey(nameof(DocumentModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Specie = group.Add(new VocabularyKey(nameof(Specie), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFiscalDocumentForServices = group.Add(new VocabularyKey(nameof(ElectronicFiscalDocumentForServices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERExportFormatMappingName = group.Add(new VocabularyKey(nameof(ERExportFormatMappingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERExportFormatSolutionName = group.Add(new VocabularyKey(nameof(ERExportFormatSolutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERExportFormatVendorUrl = group.Add(new VocabularyKey(nameof(ERExportFormatVendorUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportFileLayoutGroup = group.Add(new VocabularyKey(nameof(ExportFileLayoutGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnFileLayoutGroup = group.Add(new VocabularyKey(nameof(ReturnFileLayoutGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxItemLines = group.Add(new VocabularyKey(nameof(MaxItemLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxItemDescriptionSize = group.Add(new VocabularyKey(nameof(MaxItemDescriptionSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CutOffItemDescription = group.Add(new VocabularyKey(nameof(CutOffItemDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxServiceItemLines = group.Add(new VocabularyKey(nameof(MaxServiceItemLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxServiceItemDescription = group.Add(new VocabularyKey(nameof(MaxServiceItemDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CutOffServiceItemDescription = group.Add(new VocabularyKey(nameof(CutOffServiceItemDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxMemoLines = group.Add(new VocabularyKey(nameof(MaxMemoLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxMemoDescriptionSize = group.Add(new VocabularyKey(nameof(MaxMemoDescriptionSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CutoffMemoDescription = group.Add(new VocabularyKey(nameof(CutoffMemoDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintDeliveryAddressAtMemo = group.Add(new VocabularyKey(nameof(PrintDeliveryAddressAtMemo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxInstallments = group.Add(new VocabularyKey(nameof(MaxInstallments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishment_BR = group.Add(new VocabularyKey(nameof(FiscalEstablishment_BR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeBR = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeBR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentModel = group.Add(new VocabularyKey(nameof(FiscalDocumentModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeNumberSequence = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeNumberSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentNumberSequence = group.Add(new VocabularyKey(nameof(FiscalDocumentNumberSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FiscalEstablishmentId { get; private set; }
        public VocabularyKey FiscalDocumentType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Series { get; private set; }
        public VocabularyKey FiscalDocumentIssueDate { get; private set; }
        public VocabularyKey DocumentModel { get; private set; }
        public VocabularyKey Specie { get; private set; }
        public VocabularyKey ElectronicFiscalDocumentForServices { get; private set; }
        public VocabularyKey ERExportFormatMappingName { get; private set; }
        public VocabularyKey ERExportFormatSolutionName { get; private set; }
        public VocabularyKey ERExportFormatVendorUrl { get; private set; }
        public VocabularyKey ExportFileLayoutGroup { get; private set; }
        public VocabularyKey ReturnFileLayoutGroup { get; private set; }
        public VocabularyKey MaxItemLines { get; private set; }
        public VocabularyKey MaxItemDescriptionSize { get; private set; }
        public VocabularyKey CutOffItemDescription { get; private set; }
        public VocabularyKey MaxServiceItemLines { get; private set; }
        public VocabularyKey MaxServiceItemDescription { get; private set; }
        public VocabularyKey CutOffServiceItemDescription { get; private set; }
        public VocabularyKey MaxMemoLines { get; private set; }
        public VocabularyKey MaxMemoDescriptionSize { get; private set; }
        public VocabularyKey CutoffMemoDescription { get; private set; }
        public VocabularyKey PrintDeliveryAddressAtMemo { get; private set; }
        public VocabularyKey MaxInstallments { get; private set; }
        public VocabularyKey FiscalEstablishment_BR { get; private set; }
        public VocabularyKey FiscalDocumentTypeBR { get; private set; }
        public VocabularyKey FiscalDocumentModel { get; private set; }
        public VocabularyKey FiscalDocumentTypeNumberSequence { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey FiscalDocumentNumberSequence { get; private set; }


    }
}