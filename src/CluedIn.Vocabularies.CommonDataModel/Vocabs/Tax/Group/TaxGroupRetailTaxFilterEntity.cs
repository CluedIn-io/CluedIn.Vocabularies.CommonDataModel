using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxGroupRetailTaxFilterEntityVocabulary : SimpleVocabulary
    {
        public TaxGroupRetailTaxFilterEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxGroupRetailTaxFilterEntity";
            KeyPrefix = "commonDataModel.taxgroupretailtaxfilterentity";
            KeySeparator = ".";
            Grouping = "/TaxGroupRetailTaxFilterEntity";

            AddGroup("Common Data Model TaxGroupRetailTaxFilterEntity Details", group =>
            {
                TaxGroupId = group.Add(new VocabularyKey(nameof(TaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                District = group.Add(new VocabularyKey(nameof(District), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey(nameof(ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CityId = group.Add(new VocabularyKey(nameof(CityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistrictId = group.Add(new VocabularyKey(nameof(DistrictId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCodeId = group.Add(new VocabularyKey(nameof(ZipCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxGroupId { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey District { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey ZipCode { get; private set; }
        public VocabularyKey CityId { get; private set; }
        public VocabularyKey DistrictId { get; private set; }
        public VocabularyKey ZipCodeId { get; private set; }


    }
}