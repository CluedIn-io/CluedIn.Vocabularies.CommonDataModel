using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class AttributeGroupVocabulary : SimpleVocabulary
    {
        public AttributeGroupVocabulary()
        {
            VocabularyName = "Attribute Group";
            KeyPrefix = "commonDataModel.attributegroup.automotive";
            KeySeparator = ".";
            Grouping = "/AttributeGroup";

            AddGroup("AttributeGroup Details for Automotive", group =>
            {
			    AttributeGroupId = group.Add(new VocabularyKey(nameof(AttributeGroupId), "Attribute Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), "Line Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AttributeGroupId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}