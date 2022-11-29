using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class ConfigurationVocabulary : SimpleVocabulary
    {
        public ConfigurationVocabulary()
        {
            VocabularyName = "Configuration";
            KeyPrefix = "commonDataModel.configuration.scheduling";
            KeySeparator = ".";
            Grouping = "/Configuration";

            AddGroup("Configuration Details for Scheduling", group =>
            {
			    ConfigurationId = group.Add(new VocabularyKey(nameof(ConfigurationId), "Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ConfigurationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Value { get; private set; }
    }
}