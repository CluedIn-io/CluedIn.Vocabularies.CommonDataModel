using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorInvoiceDeclarationEntityVocabulary : SimpleVocabulary
    {
        public VendVendorInvoiceDeclarationEntityVocabulary()
        {
            VocabularyName = "VendVendorInvoiceDeclarationEntity";
            KeyPrefix = "commonDataModel.vendvendorinvoicedeclarationentity";
            KeySeparator = ".";
            Grouping = "/VendVendorInvoiceDeclarationEntity";

            AddGroup("VendVendorInvoiceDeclarationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDeclarationId = group.Add(new VocabularyKey(nameof(InvoiceDeclarationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordType = group.Add(new VocabularyKey(nameof(RecordType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCode = group.Add(new VocabularyKey(nameof(ReportingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey InvoiceDeclarationId { get; private set; }
        public VocabularyKey RecordType { get; private set; }
        public VocabularyKey ReportingCode { get; private set; }


    }
}