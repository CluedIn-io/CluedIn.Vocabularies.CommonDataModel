using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetPostingProfileEntityVocabulary : SimpleVocabulary
    {
        public AssetPostingProfileEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetPostingProfileEntity";
            KeyPrefix = "commonDataModel.assetpostingprofileentity";
            KeySeparator = ".";
            Grouping = "/AssetPostingProfileEntity";

            AddGroup("Common Data Model AssetPostingProfileEntity Details", group =>
            {
                PostingProfileId = group.Add(new VocabularyKey(nameof(PostingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValueModelId = group.Add(new VocabularyKey(nameof(ValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountGroupings = group.Add(new VocabularyKey(nameof(AccountGroupings), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetMainAccountId = group.Add(new VocabularyKey(nameof(OffsetMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(OffsetMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllocationRule = group.Add(new VocabularyKey(nameof(AllocationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllocationRuleId = group.Add(new VocabularyKey(nameof(AllocationRuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PostingProfileId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey ValueModelId { get; private set; }
public VocabularyKey AccountGroupings { get; private set; }
public VocabularyKey AccountRelation { get; private set; }
public VocabularyKey MainAccountId { get; private set; }
public VocabularyKey MainAccountIdDisplayValue { get; private set; }
public VocabularyKey OffsetMainAccountId { get; private set; }
public VocabularyKey OffsetMainAccountIdDisplayValue { get; private set; }
public VocabularyKey AllocationRule { get; private set; }
public VocabularyKey AllocationRuleId { get; private set; }


    }
}