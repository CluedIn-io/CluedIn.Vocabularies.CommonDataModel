using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationZoneDetailEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationZoneDetailEntityVocabulary()
        {
            VocabularyName = "TMSTransportationZoneDetailEntity";
            KeyPrefix = "commonDataModel.tmstransportationzonedetailentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationZoneDetailEntity";

            AddGroup("TMSTransportationZoneDetailEntity Details", group =>
            {
                FirstField = group.Add(new VocabularyKey(nameof(FirstField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondField = group.Add(new VocabularyKey(nameof(SecondField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdField = group.Add(new VocabularyKey(nameof(ThirdField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FourthField = group.Add(new VocabularyKey(nameof(FourthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FifthField = group.Add(new VocabularyKey(nameof(FifthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SixthField = group.Add(new VocabularyKey(nameof(SixthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeventhField = group.Add(new VocabularyKey(nameof(SeventhField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EighthField = group.Add(new VocabularyKey(nameof(EighthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationZoneId = group.Add(new VocabularyKey(nameof(TransportationZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationZoneMasterCode = group.Add(new VocabularyKey(nameof(TransportationZoneMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FirstField { get; private set; }
        public VocabularyKey SecondField { get; private set; }
        public VocabularyKey ThirdField { get; private set; }
        public VocabularyKey FourthField { get; private set; }
        public VocabularyKey FifthField { get; private set; }
        public VocabularyKey SixthField { get; private set; }
        public VocabularyKey SeventhField { get; private set; }
        public VocabularyKey EighthField { get; private set; }
        public VocabularyKey TransportationZoneId { get; private set; }
        public VocabularyKey TransportationZoneMasterCode { get; private set; }


    }
}