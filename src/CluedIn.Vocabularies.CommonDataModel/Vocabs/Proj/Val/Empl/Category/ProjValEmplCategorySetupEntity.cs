using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjValEmplCategorySetupEntityVocabulary : SimpleVocabulary
    {
        public ProjValEmplCategorySetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjValEmplCategorySetupEntity";
            KeyPrefix = "commonDataModel.projvalemplcategorysetupentity";
            KeySeparator = ".";
            Grouping = "/ProjValEmplCategorySetupEntity";

            AddGroup("Common Data Model ProjValEmplCategorySetupEntity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceLegalEntityDataArea = group.Add(new VocabularyKey(nameof(ResourceLegalEntityDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceLegalEntity = group.Add(new VocabularyKey(nameof(ResourceLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceLegalEntityPartyNumber = group.Add(new VocabularyKey(nameof(ResourceLegalEntityPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CategoryId { get; private set; }
public VocabularyKey GroupId { get; private set; }
public VocabularyKey Resource { get; private set; }
public VocabularyKey ResourceLegalEntityDataArea { get; private set; }
public VocabularyKey ResourceLegalEntity { get; private set; }
public VocabularyKey ResourceLegalEntityPartyNumber { get; private set; }
public VocabularyKey ResourceId { get; private set; }


    }
}