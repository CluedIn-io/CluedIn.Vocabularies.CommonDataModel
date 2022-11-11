using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationMileageEngineDetailEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationMileageEngineDetailEntityVocabulary()
        {
            VocabularyName = "TMSTransportationMileageEngineDetailEntity";
            KeyPrefix = "commonDataModel.tmstransportationmileageenginedetailentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationMileageEngineDetailEntity";

            AddGroup("TMSTransportationMileageEngineDetailEntity Details", group =>
            {
                FirstField = group.Add(new VocabularyKey(nameof(FirstField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondField = group.Add(new VocabularyKey(nameof(SecondField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdField = group.Add(new VocabularyKey(nameof(ThirdField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FourthField = group.Add(new VocabularyKey(nameof(FourthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FifthField = group.Add(new VocabularyKey(nameof(FifthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SixthField = group.Add(new VocabularyKey(nameof(SixthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeventhField = group.Add(new VocabularyKey(nameof(SeventhField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EighthField = group.Add(new VocabularyKey(nameof(EighthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationMileageEngineId = group.Add(new VocabularyKey(nameof(TransportationMileageEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistanceMiles = group.Add(new VocabularyKey(nameof(DistanceMiles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

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
        public VocabularyKey TransportationMileageEngineId { get; private set; }
        public VocabularyKey DistanceMiles { get; private set; }


    }
}