using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FieldMappingVocabulary : SimpleVocabulary
    {
        public FieldMappingVocabulary()
        {
            VocabularyName = "Common Data Model FieldMapping";
            KeyPrefix = "commonDataModel.fieldmapping";
            KeySeparator = ".";
            Grouping = "/FieldMapping";

            AddGroup("Common Data Model FieldMapping Details", group =>
            {
                leadField = group.Add(new VocabularyKey(nameof(leadField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
linkedinfieldmappingId = group.Add(new VocabularyKey(nameof(linkedinfieldmappingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
linkedInPredefinedField = group.Add(new VocabularyKey(nameof(linkedInPredefinedField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey leadField { get; private set; }
public VocabularyKey linkedinfieldmappingId { get; private set; }
public VocabularyKey linkedInPredefinedField { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}