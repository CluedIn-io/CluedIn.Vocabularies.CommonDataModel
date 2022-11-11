using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPublishedRequestForQuotationAndReplyLineEntityVocabulary : SimpleVocabulary
    {
        public PurchPublishedRequestForQuotationAndReplyLineEntityVocabulary()
        {
            VocabularyName = "PurchPublishedRequestForQuotationAndReplyLineEntity";
            KeyPrefix = "commonDataModel.purchpublishedrequestforquotationandreplylineentity";
            KeySeparator = ".";
            Grouping = "/PurchPublishedRequestForQuotationAndReplyLineEntity";

            AddGroup("PurchPublishedRequestForQuotationAndReplyLineEntity Details", group =>
            {
                RFQNumber = group.Add(new VocabularyKey(nameof(RFQNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyLineNumber = group.Add(new VocabularyKey(nameof(ReplyLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAlternateProduct = group.Add(new VocabularyKey(nameof(IsAlternateProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyFixedPriceCharges = group.Add(new VocabularyKey(nameof(ReplyFixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyPurchaseQuantity = group.Add(new VocabularyKey(nameof(ReplyPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyPurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(ReplyPurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyPurchasePrice = group.Add(new VocabularyKey(nameof(ReplyPurchasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyLineAmount = group.Add(new VocabularyKey(nameof(ReplyLineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyLineDiscountAmount = group.Add(new VocabularyKey(nameof(ReplyLineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyLineDiscountPercentage = group.Add(new VocabularyKey(nameof(ReplyLineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyMultilineDiscountAmount = group.Add(new VocabularyKey(nameof(ReplyMultilineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyMultilineDiscountPercentage = group.Add(new VocabularyKey(nameof(ReplyMultilineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyComment = group.Add(new VocabularyKey(nameof(ReplyComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyLineValidFromDate = group.Add(new VocabularyKey(nameof(ReplyLineValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyLineValidToDate = group.Add(new VocabularyKey(nameof(ReplyLineValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyLineLeadTime = group.Add(new VocabularyKey(nameof(ReplyLineLeadTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyLineWorkingDays = group.Add(new VocabularyKey(nameof(ReplyLineWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseNumber = group.Add(new VocabularyKey(nameof(RFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQStatus = group.Add(new VocabularyKey(nameof(RFQStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseRequestingWorkerName = group.Add(new VocabularyKey(nameof(RFQCaseRequestingWorkerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedFixedPriceCharges = group.Add(new VocabularyKey(nameof(RequestedFixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedPurchaseQuantity = group.Add(new VocabularyKey(nameof(RequestedPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedPurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(RequestedPurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedPurchasePrice = group.Add(new VocabularyKey(nameof(RequestedPurchasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedLineAmount = group.Add(new VocabularyKey(nameof(RequestedLineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedLineDiscountAmount = group.Add(new VocabularyKey(nameof(RequestedLineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedLineDiscountPercentage = group.Add(new VocabularyKey(nameof(RequestedLineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedMultilineDiscountAmount = group.Add(new VocabularyKey(nameof(RequestedMultilineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedMultilineDiscountPercentage = group.Add(new VocabularyKey(nameof(RequestedMultilineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HighestRFQStatus = group.Add(new VocabularyKey(nameof(HighestRFQStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowestRFQStatus = group.Add(new VocabularyKey(nameof(LowestRFQStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorName = group.Add(new VocabularyKey(nameof(VendorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RFQNumber { get; private set; }
        public VocabularyKey ReplyLineNumber { get; private set; }
        public VocabularyKey IsAlternateProduct { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey ReplyFixedPriceCharges { get; private set; }
        public VocabularyKey ReplyPurchaseQuantity { get; private set; }
        public VocabularyKey ReplyPurchaseUnitSymbol { get; private set; }
        public VocabularyKey ReplyPurchasePrice { get; private set; }
        public VocabularyKey ReplyLineAmount { get; private set; }
        public VocabularyKey ReplyLineDiscountAmount { get; private set; }
        public VocabularyKey ReplyLineDiscountPercentage { get; private set; }
        public VocabularyKey ReplyMultilineDiscountAmount { get; private set; }
        public VocabularyKey ReplyMultilineDiscountPercentage { get; private set; }
        public VocabularyKey ReplyComment { get; private set; }
        public VocabularyKey ReplyLineValidFromDate { get; private set; }
        public VocabularyKey ReplyLineValidToDate { get; private set; }
        public VocabularyKey ReplyLineLeadTime { get; private set; }
        public VocabularyKey ReplyLineWorkingDays { get; private set; }
        public VocabularyKey RFQCaseNumber { get; private set; }
        public VocabularyKey RFQStatus { get; private set; }
        public VocabularyKey RFQCaseRequestingWorkerName { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey RequestedFixedPriceCharges { get; private set; }
        public VocabularyKey RequestedPurchaseQuantity { get; private set; }
        public VocabularyKey RequestedPurchaseUnitSymbol { get; private set; }
        public VocabularyKey RequestedPurchasePrice { get; private set; }
        public VocabularyKey RequestedLineAmount { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey RequestedLineDiscountAmount { get; private set; }
        public VocabularyKey RequestedLineDiscountPercentage { get; private set; }
        public VocabularyKey RequestedMultilineDiscountAmount { get; private set; }
        public VocabularyKey RequestedMultilineDiscountPercentage { get; private set; }
        public VocabularyKey HighestRFQStatus { get; private set; }
        public VocabularyKey LowestRFQStatus { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey VendorName { get; private set; }


    }
}