using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTenderDiscountEntityVocabulary : SimpleVocabulary
    {
        public RetailTenderDiscountEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTenderDiscountEntity";
            KeyPrefix = "commonDataModel.retailtenderdiscountentity";
            KeySeparator = ".";
            Grouping = "/RetailTenderDiscountEntity";

            AddGroup("Common Data Model RetailTenderDiscountEntity Details", group =>
            {
                RetailTenderType = group.Add(new VocabularyKey(nameof(RetailTenderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferId = group.Add(new VocabularyKey(nameof(OfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateValidationType = group.Add(new VocabularyKey(nameof(DateValidationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidationPeriodId = group.Add(new VocabularyKey(nameof(ValidationPeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailDiscountValidationPeriod = group.Add(new VocabularyKey(nameof(RetailDiscountValidationPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardTypeId = group.Add(new VocabularyKey(nameof(CardTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountLedgerDimension = group.Add(new VocabularyKey(nameof(DiscountLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderTypeId = group.Add(new VocabularyKey(nameof(TenderTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DiscountLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RetailTenderType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OfferId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey DateValidationType { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey ValidationPeriodId { get; private set; }
        public VocabularyKey RetailDiscountValidationPeriod { get; private set; }
        public VocabularyKey CardTypeId { get; private set; }
        public VocabularyKey DiscountLedgerDimension { get; private set; }
        public VocabularyKey TenderTypeId { get; private set; }
        public VocabularyKey DiscountLedgerDimensionDisplayValue { get; private set; }


    }
}