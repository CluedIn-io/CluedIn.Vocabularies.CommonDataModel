using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetBookSpecialDepreciationAllowanceEntityVocabulary : SimpleVocabulary
    {
        public AssetBookSpecialDepreciationAllowanceEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetBookSpecialDepreciationAllowanceEntity";
            KeyPrefix = "commonDataModel.assetbookspecialdepreciationallowanceentity";
            KeySeparator = ".";
            Grouping = "/AssetBookSpecialDepreciationAllowanceEntity";

            AddGroup("Common Data Model AssetBookSpecialDepreciationAllowanceEntity Details", group =>
            {
                FixedAssetId = group.Add(new VocabularyKey(nameof(FixedAssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BookId = group.Add(new VocabularyKey(nameof(BookId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SpecialDepreciationAllowanceId = group.Add(new VocabularyKey(nameof(SpecialDepreciationAllowanceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Percentage = group.Add(new VocabularyKey(nameof(Percentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FixedAssetId { get; private set; }
public VocabularyKey BookId { get; private set; }
public VocabularyKey SpecialDepreciationAllowanceId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey Amount { get; private set; }
public VocabularyKey Percentage { get; private set; }
public VocabularyKey Priority { get; private set; }


    }
}