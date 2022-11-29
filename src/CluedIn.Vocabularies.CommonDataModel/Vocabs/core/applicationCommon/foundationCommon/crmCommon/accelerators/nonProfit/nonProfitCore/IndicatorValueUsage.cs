using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class IndicatorValueUsageVocabulary : SimpleVocabulary
    {
        public IndicatorValueUsageVocabulary()
        {
            VocabularyName = "Indicator Value Usage";
            KeyPrefix = "commonDataModel.indicatorvalueusage.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/IndicatorValueUsage";

            AddGroup("IndicatorValueUsage Details for NonProfitCore", group =>
            {
			    IndicatorValueUsageId = group.Add(new VocabularyKey(nameof(IndicatorValueUsageId), "Indicator Value Usage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Usage Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UsageType = group.Add(new VocabularyKey(nameof(UsageType), "Usage Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IndicatorValueUsageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey UsageType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}