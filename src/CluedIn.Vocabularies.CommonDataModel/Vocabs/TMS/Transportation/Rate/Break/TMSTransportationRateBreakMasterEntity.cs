using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRateBreakMasterEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRateBreakMasterEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Rate Break Master Entity";
            KeyPrefix = "commonDataModel.tmstransportationratebreakmasterentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRateBreakMasterEntity";

            AddGroup("TMSTransportationRateBreakMasterEntity Details", group =>
            {
                MasterCode = group.Add(new VocabularyKey(nameof(MasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakUnitSymbol = group.Add(new VocabularyKey(nameof(BreakUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComparisonSign = group.Add(new VocabularyKey(nameof(ComparisonSign), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BreakDataType = group.Add(new VocabularyKey(nameof(BreakDataType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MasterDescription = group.Add(new VocabularyKey(nameof(MasterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MasterCode { get; private set; }
        public VocabularyKey BreakUnitSymbol { get; private set; }
        public VocabularyKey ComparisonSign { get; private set; }
        public VocabularyKey BreakDataType { get; private set; }
        public VocabularyKey MasterDescription { get; private set; }
    }
}