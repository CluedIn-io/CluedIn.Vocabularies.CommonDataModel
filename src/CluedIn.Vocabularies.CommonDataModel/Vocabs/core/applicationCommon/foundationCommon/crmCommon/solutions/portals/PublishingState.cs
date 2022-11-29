using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class PublishingStateVocabulary : SimpleVocabulary
    {
        public PublishingStateVocabulary()
        {
            VocabularyName = "Publishing State";
            KeyPrefix = "commonDataModel.publishingstate.portals";
            KeySeparator = ".";
            Grouping = "/PublishingState";

            AddGroup("PublishingState Details for Portals", group =>
            {
			    PublishingStateId = group.Add(new VocabularyKey(nameof(PublishingStateId), "Publishing State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), "Display Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsVisible = group.Add(new VocabularyKey(nameof(IsVisible), "Select whether the publishing state is visible.", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PublishingStateId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey IsVisible { get; private set; }
    }
}