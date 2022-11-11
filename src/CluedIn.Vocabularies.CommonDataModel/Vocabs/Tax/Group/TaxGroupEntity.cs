using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxGroupEntityVocabulary : SimpleVocabulary
    {
        public TaxGroupEntityVocabulary()
        {
            VocabularyName = "TaxGroupEntity";
            KeyPrefix = "commonDataModel.taxgroupentity";
            KeySeparator = ".";
            Grouping = "/TaxGroupEntity";

            AddGroup("TaxGroupEntity Details", group =>
            {
                TaxGroupCode = group.Add(new VocabularyKey(nameof(TaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingBy = group.Add(new VocabularyKey(nameof(RoundingBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicePrintDetails = group.Add(new VocabularyKey(nameof(InvoicePrintDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxReverseOnCashDiscount = group.Add(new VocabularyKey(nameof(TaxReverseOnCashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCriteriaCityId = group.Add(new VocabularyKey(nameof(DefaultCriteriaCityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCriteriaCountryId = group.Add(new VocabularyKey(nameof(DefaultCriteriaCountryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCriteriaCountyId = group.Add(new VocabularyKey(nameof(DefaultCriteriaCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCriteriaStateId = group.Add(new VocabularyKey(nameof(DefaultCriteriaStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCriteriaZipCodeId = group.Add(new VocabularyKey(nameof(DefaultCriteriaZipCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfVATRegisterFilling = group.Add(new VocabularyKey(nameof(DateOfVATRegisterFilling), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EUTrade_W = group.Add(new VocabularyKey(nameof(EUTrade_W), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FillSalesDate_W = group.Add(new VocabularyKey(nameof(FillSalesDate_W), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MandatorySalesDate_W = group.Add(new VocabularyKey(nameof(MandatorySalesDate_W), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxGroupCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RoundingBy { get; private set; }
        public VocabularyKey InvoicePrintDetails { get; private set; }
        public VocabularyKey TaxReverseOnCashDiscount { get; private set; }
        public VocabularyKey DefaultCriteriaCityId { get; private set; }
        public VocabularyKey DefaultCriteriaCountryId { get; private set; }
        public VocabularyKey DefaultCriteriaCountyId { get; private set; }
        public VocabularyKey DefaultCriteriaStateId { get; private set; }
        public VocabularyKey DefaultCriteriaZipCodeId { get; private set; }
        public VocabularyKey DateOfVATRegisterFilling { get; private set; }
        public VocabularyKey EUTrade_W { get; private set; }
        public VocabularyKey FillSalesDate_W { get; private set; }
        public VocabularyKey MandatorySalesDate_W { get; private set; }


    }
}