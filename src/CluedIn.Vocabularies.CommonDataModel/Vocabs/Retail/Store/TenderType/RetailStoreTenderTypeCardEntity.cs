using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailStoreTenderTypeCardEntityVocabulary : SimpleVocabulary
    {
        public RetailStoreTenderTypeCardEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailStoreTenderTypeCardEntity";
            KeyPrefix = "commonDataModel.retailstoretendertypecardentity";
            KeySeparator = ".";
            Grouping = "/RetailStoreTenderTypeCardEntity";

            AddGroup("Common Data Model RetailStoreTenderTypeCardEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowManualInput = group.Add(new VocabularyKey(nameof(AllowManualInput), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerId = group.Add(new VocabularyKey(nameof(BrokerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardFee = group.Add(new VocabularyKey(nameof(CardFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardFeeLedgerDimension = group.Add(new VocabularyKey(nameof(CardFeeLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardFeeMax = group.Add(new VocabularyKey(nameof(CardFeeMax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardFeeMin = group.Add(new VocabularyKey(nameof(CardFeeMin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardFeeOffsetLedgerDimension = group.Add(new VocabularyKey(nameof(CardFeeOffsetLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardInquiryFee = group.Add(new VocabularyKey(nameof(CardInquiryFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardNumberSwiped = group.Add(new VocabularyKey(nameof(CardNumberSwiped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardTypeId = group.Add(new VocabularyKey(nameof(CardTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashBackLimit = group.Add(new VocabularyKey(nameof(CashBackLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckExpiredDate = group.Add(new VocabularyKey(nameof(CheckExpiredDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckModulus = group.Add(new VocabularyKey(nameof(CheckModulus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingRequired = group.Add(new VocabularyKey(nameof(CountingRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiffAccBigDiffLedgerDimension = group.Add(new VocabularyKey(nameof(DiffAccBigDiffLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DifferenceAccLedgerDimension = group.Add(new VocabularyKey(nameof(DifferenceAccLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnterFleetInfo = group.Add(new VocabularyKey(nameof(EnterFleetInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualAuthorization = group.Add(new VocabularyKey(nameof(ManualAuthorization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxNormalDifferenceAmount = group.Add(new VocabularyKey(nameof(MaxNormalDifferenceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessLocally = group.Add(new VocabularyKey(nameof(ProcessLocally), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SameCardAllowed = group.Add(new VocabularyKey(nameof(SameCardAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderTypeId = group.Add(new VocabularyKey(nameof(TenderTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardFeeLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(CardFeeLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardFeeOffsetLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(CardFeeOffsetLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiffAccBigDiffLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DiffAccBigDiffLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DifferenceAccLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DifferenceAccLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnitNumber = group.Add(new VocabularyKey(nameof(OMOperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnitID = group.Add(new VocabularyKey(nameof(OMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExpirationDateRequired = group.Add(new VocabularyKey(nameof(IsExpirationDateRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPinRequired = group.Add(new VocabularyKey(nameof(IsPinRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey AllowManualInput { get; private set; }
        public VocabularyKey BrokerId { get; private set; }
        public VocabularyKey CardFee { get; private set; }
        public VocabularyKey CardFeeLedgerDimension { get; private set; }
        public VocabularyKey CardFeeMax { get; private set; }
        public VocabularyKey CardFeeMin { get; private set; }
        public VocabularyKey CardFeeOffsetLedgerDimension { get; private set; }
        public VocabularyKey CardInquiryFee { get; private set; }
        public VocabularyKey CardNumberSwiped { get; private set; }
        public VocabularyKey CardTypeId { get; private set; }
        public VocabularyKey CashBackLimit { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey CheckExpiredDate { get; private set; }
        public VocabularyKey CheckModulus { get; private set; }
        public VocabularyKey CountingRequired { get; private set; }
        public VocabularyKey DiffAccBigDiffLedgerDimension { get; private set; }
        public VocabularyKey DifferenceAccLedgerDimension { get; private set; }
        public VocabularyKey EnterFleetInfo { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey ManualAuthorization { get; private set; }
        public VocabularyKey MaxNormalDifferenceAmount { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessLocally { get; private set; }
        public VocabularyKey SameCardAllowed { get; private set; }
        public VocabularyKey TenderTypeId { get; private set; }
        public VocabularyKey CardFeeLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey CardFeeOffsetLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DiffAccBigDiffLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DifferenceAccLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey OMOperatingUnitNumber { get; private set; }
        public VocabularyKey OMOperatingUnitID { get; private set; }
        public VocabularyKey IsExpirationDateRequired { get; private set; }
        public VocabularyKey IsPinRequired { get; private set; }


    }
}