using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetProvisionTypeEntityVocabulary : SimpleVocabulary
    {
        public AssetProvisionTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetProvisionTypeEntity";
            KeyPrefix = "commonDataModel.assetprovisiontypeentity";
            KeySeparator = ".";
            Grouping = "/AssetProvisionTypeEntity";

            AddGroup("Common Data Model AssetProvisionTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LengthOfOwnership = group.Add(new VocabularyKey(nameof(LengthOfOwnership), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Months = group.Add(new VocabularyKey(nameof(Months), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey LengthOfOwnership { get; private set; }
public VocabularyKey TypeId { get; private set; }
public VocabularyKey Months { get; private set; }


    }
}