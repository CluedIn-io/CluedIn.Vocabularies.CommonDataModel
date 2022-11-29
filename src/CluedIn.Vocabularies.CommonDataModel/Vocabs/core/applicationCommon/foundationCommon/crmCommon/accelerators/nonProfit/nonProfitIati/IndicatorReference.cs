using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class IndicatorReferenceVocabulary : SimpleVocabulary
    {
        public IndicatorReferenceVocabulary()
        {
            VocabularyName = "Indicator Reference";
            KeyPrefix = "commonDataModel.indicatorreference.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/IndicatorReference";

            AddGroup("IndicatorReference Details for NonProfitIati", group =>
            {
			    IndicatorReferenceId = group.Add(new VocabularyKey(nameof(IndicatorReferenceId), "Indicator Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IndicatorReferenceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}