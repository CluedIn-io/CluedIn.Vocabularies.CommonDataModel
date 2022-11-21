using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionAgencyFeeEntityVocabulary : SimpleVocabulary
    {
        public CustCollectionAgencyFeeEntityVocabulary()
        {
            VocabularyName = "Cust Collection Agency Fee Entity";
            KeyPrefix = "commonDataModel.custcollectionagencyfeeentity";
            KeySeparator = ".";
            Grouping = "/CustCollectionAgencyFeeEntity";

            AddGroup("CustCollectionAgencyFeeEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumFee = group.Add(new VocabularyKey(nameof(MinimumFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumFee = group.Add(new VocabularyKey(nameof(MaximumFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromAmount = group.Add(new VocabularyKey(nameof(FromAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToAmount = group.Add(new VocabularyKey(nameof(ToAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey MinimumFee { get; private set; }
        public VocabularyKey MaximumFee { get; private set; }
        public VocabularyKey FromAmount { get; private set; }
        public VocabularyKey ToAmount { get; private set; }
        public VocabularyKey Percent { get; private set; }
    }
}