using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxSalesTaxRegistrationNumberEntityVocabulary : SimpleVocabulary
    {
        public TaxSalesTaxRegistrationNumberEntityVocabulary()
        {
            VocabularyName = "Tax Sales Tax Registration Number Entity";
            KeyPrefix = "commonDataModel.taxsalestaxregistrationnumberentity";
            KeySeparator = ".";
            Grouping = "/TaxSalesTaxRegistrationNumberEntity";

            AddGroup("TaxSalesTaxRegistrationNumberEntity Details", group =>
            {
                Shared = group.Add(new VocabularyKey(nameof(Shared), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefCompanyId = group.Add(new VocabularyKey(nameof(RefCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumberType = group.Add(new VocabularyKey(nameof(RegistrationNumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAlert = group.Add(new VocabularyKey(nameof(ReturnAlert), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnBasis = group.Add(new VocabularyKey(nameof(ReturnBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesDuration = group.Add(new VocabularyKey(nameof(SalesDuration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnit = group.Add(new VocabularyKey(nameof(SalesUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnDuration = group.Add(new VocabularyKey(nameof(ReturnDuration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnUnit = group.Add(new VocabularyKey(nameof(ReturnUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Shared { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RefCompanyId { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey RegistrationNumberType { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey ReturnAlert { get; private set; }
        public VocabularyKey ReturnBasis { get; private set; }
        public VocabularyKey SalesDuration { get; private set; }
        public VocabularyKey SalesUnit { get; private set; }
        public VocabularyKey ReturnDuration { get; private set; }
        public VocabularyKey ReturnUnit { get; private set; }
    }
}