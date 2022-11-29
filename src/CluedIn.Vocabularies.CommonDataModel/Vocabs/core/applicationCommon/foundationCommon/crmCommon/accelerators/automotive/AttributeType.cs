using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class AttributeTypeVocabulary : SimpleVocabulary
    {
        public AttributeTypeVocabulary()
        {
            VocabularyName = "Attribute Type";
            KeyPrefix = "commonDataModel.attributetype.automotive";
            KeySeparator = ".";
            Grouping = "/AttributeType";

            AddGroup("AttributeType Details for Automotive", group =>
            {
			    AttributeTypeId = group.Add(new VocabularyKey(nameof(AttributeTypeId), "Attribute Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), "Line Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AttributeTypeId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}