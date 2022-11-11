using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxPovertyFundSetupEntityVocabulary : SimpleVocabulary
    {
        public TaxPovertyFundSetupEntityVocabulary()
        {
            VocabularyName = "TaxPovertyFundSetupEntity";
            KeyPrefix = "commonDataModel.taxpovertyfundsetupentity";
            KeySeparator = ".";
            Grouping = "/TaxPovertyFundSetupEntity";

            AddGroup("TaxPovertyFundSetupEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustVendType = group.Add(new VocabularyKey(nameof(CustVendType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxFromDate = group.Add(new VocabularyKey(nameof(TaxFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPercentage = group.Add(new VocabularyKey(nameof(TaxPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxToDate = group.Add(new VocabularyKey(nameof(TaxToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnlyFinalUserTrans = group.Add(new VocabularyKey(nameof(OnlyFinalUserTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey CustVendType { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey TaxFromDate { get; private set; }
        public VocabularyKey TaxPercentage { get; private set; }
        public VocabularyKey TaxToDate { get; private set; }
        public VocabularyKey OnlyFinalUserTrans { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey StateId { get; private set; }


    }
}