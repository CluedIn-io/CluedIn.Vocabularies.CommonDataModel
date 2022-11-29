using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class PreferenceVocabulary : SimpleVocabulary
    {
        public PreferenceVocabulary()
        {
            VocabularyName = "Preference";
            KeyPrefix = "commonDataModel.preference.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Preference";

            AddGroup("Preference Details for NonProfitCore", group =>
            {
			    Confidence = group.Add(new VocabularyKey(nameof(Confidence), "Confidence", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Key = group.Add(new VocabularyKey(nameof(Key), "Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreferenceId = group.Add(new VocabularyKey(nameof(PreferenceId), "Preference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Priority = group.Add(new VocabularyKey(nameof(Priority), "Priority", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Weight = group.Add(new VocabularyKey(nameof(Weight), "Weight", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Confidence { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PreferenceId { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Weight { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}