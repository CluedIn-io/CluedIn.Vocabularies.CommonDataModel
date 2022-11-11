using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRateBaseEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRateBaseEntityVocabulary()
        {
            VocabularyName = "TMSTransportationRateBaseEntity";
            KeyPrefix = "commonDataModel.tmstransportationratebaseentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRateBaseEntity";

            AddGroup("TMSTransportationRateBaseEntity Details", group =>
            {
                MasterCode = group.Add(new VocabularyKey(nameof(MasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeCurrencyCode = group.Add(new VocabularyKey(nameof(ChargeCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumCharge = group.Add(new VocabularyKey(nameof(MaximumCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumCharge = group.Add(new VocabularyKey(nameof(MinimumCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseDescription = group.Add(new VocabularyKey(nameof(BaseDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseCode = group.Add(new VocabularyKey(nameof(BaseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRateMasterCode = group.Add(new VocabularyKey(nameof(TransportationRateMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MasterCode { get; private set; }
        public VocabularyKey ChargeCurrencyCode { get; private set; }
        public VocabularyKey MaximumCharge { get; private set; }
        public VocabularyKey MinimumCharge { get; private set; }
        public VocabularyKey BaseDescription { get; private set; }
        public VocabularyKey BaseCode { get; private set; }
        public VocabularyKey TransportationRateMasterCode { get; private set; }


    }
}