using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAttributeMetadataEntityVocabulary : SimpleVocabulary
    {
        public RetailAttributeMetadataEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailAttributeMetadataEntity";
            KeyPrefix = "commonDataModel.retailattributemetadataentity";
            KeySeparator = ".";
            Grouping = "/RetailAttributeMetadataEntity";

            AddGroup("Common Data Model RetailAttributeMetadataEntity Details", group =>
            {
                TypeName = group.Add(new VocabularyKey(nameof(TypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeName = group.Add(new VocabularyKey(nameof(AttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
XmlMetadata = group.Add(new VocabularyKey(nameof(XmlMetadata), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
XmlMetadataVersionNumber = group.Add(new VocabularyKey(nameof(XmlMetadataVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TypeName { get; private set; }
public VocabularyKey AttributeName { get; private set; }
public VocabularyKey XmlMetadata { get; private set; }
public VocabularyKey XmlMetadataVersionNumber { get; private set; }


    }
}