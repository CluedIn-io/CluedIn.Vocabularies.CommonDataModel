using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollTaxRegionEntityVocabulary : SimpleVocabulary
    {
        public PayrollTaxRegionEntityVocabulary()
        {
            VocabularyName = "Payroll Tax Region Entity";
            KeyPrefix = "commonDataModel.payrolltaxregionentity";
            KeySeparator = ".";
            Grouping = "/PayrollTaxRegionEntity";

            AddGroup("PayrollTaxRegionEntity Details", group =>
            {
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey(nameof(ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionISOCode = group.Add(new VocabularyKey(nameof(CountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegionName = group.Add(new VocabularyKey(nameof(TaxRegionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey ZipCode { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey CountryRegionISOCode { get; private set; }
        public VocabularyKey TaxRegionName { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
    }
}