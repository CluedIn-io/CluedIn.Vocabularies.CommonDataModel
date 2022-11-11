using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRateBaseDetailEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRateBaseDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationRateBaseDetailEntity";
            KeyPrefix = "commonDataModel.tmstransportationratebasedetailentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRateBaseDetailEntity";

            AddGroup("Common Data Model TMSTransportationRateBaseDetailEntity Details", group =>
            {
                FirstField = group.Add(new VocabularyKey(nameof(FirstField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondField = group.Add(new VocabularyKey(nameof(SecondField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdField = group.Add(new VocabularyKey(nameof(ThirdField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FourthField = group.Add(new VocabularyKey(nameof(FourthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FifthField = group.Add(new VocabularyKey(nameof(FifthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SixthField = group.Add(new VocabularyKey(nameof(SixthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStartDateTime = group.Add(new VocabularyKey(nameof(EffectiveStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEndDateTime = group.Add(new VocabularyKey(nameof(EffectiveEndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierMaximumChargeRate = group.Add(new VocabularyKey(nameof(ShippingCarrierMaximumChargeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierMinimumChargeRate = group.Add(new VocabularyKey(nameof(ShippingCarrierMinimumChargeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierBreakDefaultRate = group.Add(new VocabularyKey(nameof(ShippingCarrierBreakDefaultRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRateBaseCode = group.Add(new VocabularyKey(nameof(TransportationRateBaseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FirstField { get; private set; }
        public VocabularyKey SecondField { get; private set; }
        public VocabularyKey ThirdField { get; private set; }
        public VocabularyKey FourthField { get; private set; }
        public VocabularyKey FifthField { get; private set; }
        public VocabularyKey SixthField { get; private set; }
        public VocabularyKey EffectiveStartDateTime { get; private set; }
        public VocabularyKey EffectiveEndDateTime { get; private set; }
        public VocabularyKey ShippingCarrierMaximumChargeRate { get; private set; }
        public VocabularyKey ShippingCarrierMinimumChargeRate { get; private set; }
        public VocabularyKey ShippingCarrierBreakDefaultRate { get; private set; }
        public VocabularyKey TransportationRateBaseCode { get; private set; }


    }
}