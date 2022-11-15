using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRateBreakValueEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRateBreakValueEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Rate Break Value Entity";
            KeyPrefix = "commonDataModel.tmstransportationratebreakvalueentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRateBreakValueEntity";

            AddGroup("TMSTransportationRateBreakValueEntity Details", group =>
            {
                TransportationRateBreakMasterCode = group.Add(new VocabularyKey(nameof(TransportationRateBreakMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakIntegerValue = group.Add(new VocabularyKey(nameof(BreakIntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakRealValue = group.Add(new VocabularyKey(nameof(BreakRealValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakStringValue = group.Add(new VocabularyKey(nameof(BreakStringValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakValue = group.Add(new VocabularyKey(nameof(BreakValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TransportationRateBreakMasterCode { get; private set; }
        public VocabularyKey BreakIntegerValue { get; private set; }
        public VocabularyKey BreakRealValue { get; private set; }
        public VocabularyKey BreakStringValue { get; private set; }
        public VocabularyKey BreakValue { get; private set; }
    }
}