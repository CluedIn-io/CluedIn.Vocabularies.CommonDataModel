using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPublishedRequestForQuotationDeliveryPaymentTermsEntityVocabulary : SimpleVocabulary
    {
        public PurchPublishedRequestForQuotationDeliveryPaymentTermsEntityVocabulary()
        {
            VocabularyName = "Purch Published Request For Quotation Delivery Payment Terms Entity";
            KeyPrefix = "commonDataModel.purchpublishedrequestforquotationdeliverypaymenttermsentity";
            KeySeparator = ".";
            Grouping = "/PurchPublishedRequestForQuotationDeliveryPaymentTermsEntity";

            AddGroup("PurchPublishedRequestForQuotationDeliveryPaymentTermsEntity Details", group =>
            {
                RFQCaseNumber = group.Add(new VocabularyKey(nameof(RFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseTitle = group.Add(new VocabularyKey(nameof(RFQCaseTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedDeliveryDate = group.Add(new VocabularyKey(nameof(RequestedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsId = group.Add(new VocabularyKey(nameof(DeliveryTermsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeId = group.Add(new VocabularyKey(nameof(DeliveryModeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentMethodName = group.Add(new VocabularyKey(nameof(VendorPaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RFQCaseNumber { get; private set; }
        public VocabularyKey RFQCaseTitle { get; private set; }
        public VocabularyKey RequestedDeliveryDate { get; private set; }
        public VocabularyKey DeliveryTermsId { get; private set; }
        public VocabularyKey DeliveryModeId { get; private set; }
        public VocabularyKey VendorPaymentMethodName { get; private set; }
    }
}