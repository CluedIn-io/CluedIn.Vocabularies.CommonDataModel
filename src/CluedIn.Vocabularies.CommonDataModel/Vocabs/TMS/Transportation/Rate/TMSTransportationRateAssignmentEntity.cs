using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRateAssignmentEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRateAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationRateAssignmentEntity";
            KeyPrefix = "commonDataModel.tmstransportationrateassignmententity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRateAssignmentEntity";

            AddGroup("Common Data Model TMSTransportationRateAssignmentEntity Details", group =>
            {
                FirstField = group.Add(new VocabularyKey(nameof(FirstField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondField = group.Add(new VocabularyKey(nameof(SecondField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdField = group.Add(new VocabularyKey(nameof(ThirdField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FourthField = group.Add(new VocabularyKey(nameof(FourthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FifthField = group.Add(new VocabularyKey(nameof(FifthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SixthField = group.Add(new VocabularyKey(nameof(SixthField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStartDateTime = group.Add(new VocabularyKey(nameof(EffectiveStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEndDateTime = group.Add(new VocabularyKey(nameof(EffectiveEndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignmentName = group.Add(new VocabularyKey(nameof(AssignmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRateBaseCode = group.Add(new VocabularyKey(nameof(TransportationRateBaseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRateMasterCode = group.Add(new VocabularyKey(nameof(TransportationRateMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

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
        public VocabularyKey AssignmentName { get; private set; }
        public VocabularyKey TransportationRateBaseCode { get; private set; }
        public VocabularyKey TransportationRateMasterCode { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }


    }
}