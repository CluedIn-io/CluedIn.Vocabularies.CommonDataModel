using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationTransitTimeEngineDetailEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationTransitTimeEngineDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationTransitTimeEngineDetailEntity";
            KeyPrefix = "commonDataModel.tmstransportationtransittimeenginedetailentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationTransitTimeEngineDetailEntity";

            AddGroup("Common Data Model TMSTransportationTransitTimeEngineDetailEntity Details", group =>
            {
                FirstField = group.Add(new VocabularyKey(nameof(FirstField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenthField = group.Add(new VocabularyKey(nameof(TenthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondField = group.Add(new VocabularyKey(nameof(SecondField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdField = group.Add(new VocabularyKey(nameof(ThirdField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FourthField = group.Add(new VocabularyKey(nameof(FourthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FifthField = group.Add(new VocabularyKey(nameof(FifthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SixthField = group.Add(new VocabularyKey(nameof(SixthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeventhField = group.Add(new VocabularyKey(nameof(SeventhField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EighthField = group.Add(new VocabularyKey(nameof(EighthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NinthField = group.Add(new VocabularyKey(nameof(NinthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(EngineShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationTransitTimeEngineId = group.Add(new VocabularyKey(nameof(TransportationTransitTimeEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FirstField { get; private set; }
        public VocabularyKey TenthField { get; private set; }
        public VocabularyKey SecondField { get; private set; }
        public VocabularyKey ThirdField { get; private set; }
        public VocabularyKey FourthField { get; private set; }
        public VocabularyKey FifthField { get; private set; }
        public VocabularyKey SixthField { get; private set; }
        public VocabularyKey SeventhField { get; private set; }
        public VocabularyKey EighthField { get; private set; }
        public VocabularyKey NinthField { get; private set; }
        public VocabularyKey EngineShippingCarrierServiceId { get; private set; }
        public VocabularyKey TransportationTransitTimeEngineId { get; private set; }


    }
}