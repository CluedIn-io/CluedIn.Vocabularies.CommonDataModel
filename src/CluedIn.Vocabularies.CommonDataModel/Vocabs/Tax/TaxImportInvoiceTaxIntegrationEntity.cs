using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxImportInvoiceTaxIntegrationEntityVocabulary : SimpleVocabulary
    {
        public TaxImportInvoiceTaxIntegrationEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxImportInvoiceTaxIntegrationEntity";
            KeyPrefix = "commonDataModel.taximportinvoicetaxintegrationentity";
            KeySeparator = ".";
            Grouping = "/TaxImportInvoiceTaxIntegrationEntity";

            AddGroup("Common Data Model TaxImportInvoiceTaxIntegrationEntity Details", group =>
            {
                ExternalInvoiceId = group.Add(new VocabularyKey(nameof(ExternalInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Id = group.Add(new VocabularyKey(nameof(Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ExternalInvoiceId { get; private set; }
        public VocabularyKey Id { get; private set; }


    }
}