using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class CustomRegistrationFieldVocabulary : SimpleVocabulary
    {
        public CustomRegistrationFieldVocabulary()
        {
            VocabularyName = "Custom Registration Field";
            KeyPrefix = "commonDataModel.customregistrationfield.eventmanagement";
            KeySeparator = ".";
            Grouping = "/CustomRegistrationField";

            AddGroup("CustomRegistrationField Details for EventManagement", group =>
            {
			    CustomRegistrationFieldId = group.Add(new VocabularyKey(nameof(CustomRegistrationFieldId), "Custom Registration Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Text = group.Add(new VocabularyKey(nameof(Text), "Text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Choices = group.Add(new VocabularyKey(nameof(Choices), "Choices", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsRequired = group.Add(new VocabularyKey(nameof(IsRequired), "Is Required", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CustomRegistrationFieldId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey Choices { get; private set; }
        public VocabularyKey IsRequired { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}