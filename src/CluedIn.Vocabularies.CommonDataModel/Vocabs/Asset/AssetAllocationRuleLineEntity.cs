using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetAllocationRuleLineEntityVocabulary : SimpleVocabulary
    {
        public AssetAllocationRuleLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetAllocationRuleLineEntity";
            KeyPrefix = "commonDataModel.assetallocationrulelineentity";
            KeySeparator = ".";
            Grouping = "/AssetAllocationRuleLineEntity";

            AddGroup("Common Data Model AssetAllocationRuleLineEntity Details", group =>
            {
                AllocationRule = group.Add(new VocabularyKey(nameof(AllocationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RuleId = group.Add(new VocabularyKey(nameof(RuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionValue = group.Add(new VocabularyKey(nameof(DimensionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Percentage = group.Add(new VocabularyKey(nameof(Percentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetMainAccount = group.Add(new VocabularyKey(nameof(OffsetMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetMainAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetMainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AllocationRule { get; private set; }
public VocabularyKey LineId { get; private set; }
public VocabularyKey RuleId { get; private set; }
public VocabularyKey Key { get; private set; }
public VocabularyKey DimensionValue { get; private set; }
public VocabularyKey Percentage { get; private set; }
public VocabularyKey OffsetMainAccount { get; private set; }
public VocabularyKey OffsetMainAccountDisplayValue { get; private set; }


    }
}