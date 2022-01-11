using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetPostingProfileDisposalEntityVocabulary : SimpleVocabulary
    {
        public AssetPostingProfileDisposalEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetPostingProfileDisposalEntity";
            KeyPrefix = "commonDataModel.assetpostingprofiledisposalentity";
            KeySeparator = ".";
            Grouping = "/AssetPostingProfileDisposalEntity";

            AddGroup("Common Data Model AssetPostingProfileDisposalEntity Details", group =>
            {
                PostingProfileId = group.Add(new VocabularyKey(nameof(PostingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SaleOrScrap = group.Add(new VocabularyKey(nameof(SaleOrScrap), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValueModelId = group.Add(new VocabularyKey(nameof(ValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountGroupings = group.Add(new VocabularyKey(nameof(AccountGroupings), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostValue = group.Add(new VocabularyKey(nameof(PostValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesValueType = group.Add(new VocabularyKey(nameof(SalesValueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetMainAccountId = group.Add(new VocabularyKey(nameof(OffsetMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(OffsetMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PostingProfileId { get; private set; }
public VocabularyKey SaleOrScrap { get; private set; }
public VocabularyKey ValueModelId { get; private set; }
public VocabularyKey AccountGroupings { get; private set; }
public VocabularyKey AccountRelation { get; private set; }
public VocabularyKey PostValue { get; private set; }
public VocabularyKey SalesValueType { get; private set; }
public VocabularyKey MainAccountId { get; private set; }
public VocabularyKey MainAccountIdDisplayValue { get; private set; }
public VocabularyKey OffsetMainAccountId { get; private set; }
public VocabularyKey OffsetMainAccountIdDisplayValue { get; private set; }


    }
}