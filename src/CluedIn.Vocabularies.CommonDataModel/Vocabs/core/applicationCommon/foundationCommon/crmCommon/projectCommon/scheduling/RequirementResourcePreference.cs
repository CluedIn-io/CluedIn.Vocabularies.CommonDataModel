using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class RequirementResourcePreferenceVocabulary : SimpleVocabulary
    {
        public RequirementResourcePreferenceVocabulary()
        {
            VocabularyName = "Requirement Resource Preference";
            KeyPrefix = "commonDataModel.requirementresourcepreference.scheduling";
            KeySeparator = ".";
            Grouping = "/RequirementResourcePreference";

            AddGroup("RequirementResourcePreference Details for Scheduling", group =>
            {
			    RequirementResourcePreferenceId = group.Add(new VocabularyKey(nameof(RequirementResourcePreferenceId), "Requirement Resource Preference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreferenceType = group.Add(new VocabularyKey(nameof(PreferenceType), "Preference Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RequirementResourcePreferenceId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey PreferenceType { get; private set; }
    }
}