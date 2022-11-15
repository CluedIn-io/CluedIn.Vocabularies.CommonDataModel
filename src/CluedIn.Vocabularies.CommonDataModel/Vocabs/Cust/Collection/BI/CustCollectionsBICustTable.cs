using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBICustTableVocabulary : SimpleVocabulary
    {
        public CustCollectionsBICustTableVocabulary()
        {
            VocabularyName = "Cust Collections BI Cust Table";
            KeyPrefix = "commonDataModel.custcollectionsbicusttable";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBICustTable";

            AddGroup("CustCollectionsBICustTable Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustGroup = group.Add(new VocabularyKey(nameof(CustGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Party = group.Add(new VocabularyKey(nameof(Party), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditRating = group.Add(new VocabularyKey(nameof(CreditRating), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Blocked = group.Add(new VocabularyKey(nameof(Blocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistrictName = group.Add(new VocabularyKey(nameof(DistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey(nameof(ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey CustGroup { get; private set; }
        public VocabularyKey Party { get; private set; }
        public VocabularyKey CreditRating { get; private set; }
        public VocabularyKey Blocked { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey DistrictName { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ZipCode { get; private set; }
    }
}