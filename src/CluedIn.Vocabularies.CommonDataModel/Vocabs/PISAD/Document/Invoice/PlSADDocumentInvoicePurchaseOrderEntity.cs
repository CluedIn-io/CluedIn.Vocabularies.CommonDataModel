using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PlSADDocumentInvoicePurchaseOrderEntityVocabulary : SimpleVocabulary
    {
        public PlSADDocumentInvoicePurchaseOrderEntityVocabulary()
        {
            VocabularyName = "PlSADDocumentInvoicePurchaseOrderEntity";
            KeyPrefix = "commonDataModel.plsaddocumentinvoicepurchaseorderentity";
            KeySeparator = ".";
            Grouping = "/PlSADDocumentInvoicePurchaseOrderEntity";

            AddGroup("PlSADDocumentInvoicePurchaseOrderEntity Details", group =>
            {
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Insurance = group.Add(new VocabularyKey(nameof(Insurance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceMiscCharg = group.Add(new VocabularyKey(nameof(InvoiceMiscCharg), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transport = group.Add(new VocabularyKey(nameof(Transport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purchase = group.Add(new VocabularyKey(nameof(Purchase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentCode = group.Add(new VocabularyKey(nameof(DocumentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey Insurance { get; private set; }
        public VocabularyKey InvoiceMiscCharg { get; private set; }
        public VocabularyKey Transport { get; private set; }
        public VocabularyKey Purchase { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey DocumentCode { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }


    }
}