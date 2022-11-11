using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPublishedRequestForQuotationHeaderEntityVocabulary : SimpleVocabulary
    {
        public PurchPublishedRequestForQuotationHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPublishedRequestForQuotationHeaderEntity";
            KeyPrefix = "commonDataModel.purchpublishedrequestforquotationheaderentity";
            KeySeparator = ".";
            Grouping = "/PurchPublishedRequestForQuotationHeaderEntity";

            AddGroup("Common Data Model PurchPublishedRequestForQuotationHeaderEntity Details", group =>
            {
                RFQCaseNumber = group.Add(new VocabularyKey(nameof(RFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseRecId = group.Add(new VocabularyKey(nameof(RFQCaseRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseTitle = group.Add(new VocabularyKey(nameof(RFQCaseTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequesterName = group.Add(new VocabularyKey(nameof(RequesterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequesterRecId = group.Add(new VocabularyKey(nameof(RequesterRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestingDepartmentName = group.Add(new VocabularyKey(nameof(RequestingDepartmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQSolicitationTypeName = group.Add(new VocabularyKey(nameof(RFQSolicitationTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQBidType = group.Add(new VocabularyKey(nameof(RFQBidType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreOnlyInvitedVendorBidsAllowed = group.Add(new VocabularyKey(nameof(AreOnlyInvitedVendorBidsAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreAlternateProductsAllowed = group.Add(new VocabularyKey(nameof(AreAlternateProductsAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQDeliveryDate = group.Add(new VocabularyKey(nameof(RFQDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQExpirationDateTime = group.Add(new VocabularyKey(nameof(RFQExpirationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCancellationDateTime = group.Add(new VocabularyKey(nameof(RFQCancellationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCancellationReasonDescription = group.Add(new VocabularyKey(nameof(RFQCancellationReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RFQCaseNumber { get; private set; }
        public VocabularyKey RFQCaseRecId { get; private set; }
        public VocabularyKey RFQCaseTitle { get; private set; }
        public VocabularyKey RequesterName { get; private set; }
        public VocabularyKey RequesterRecId { get; private set; }
        public VocabularyKey RequestingDepartmentName { get; private set; }
        public VocabularyKey RFQSolicitationTypeName { get; private set; }
        public VocabularyKey RFQBidType { get; private set; }
        public VocabularyKey AreOnlyInvitedVendorBidsAllowed { get; private set; }
        public VocabularyKey AreAlternateProductsAllowed { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey RFQDeliveryDate { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey RFQExpirationDateTime { get; private set; }
        public VocabularyKey RFQCancellationDateTime { get; private set; }
        public VocabularyKey RFQCancellationReasonDescription { get; private set; }


    }
}