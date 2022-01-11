using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTSLLedgerTransRuleEntityVocabulary : SimpleVocabulary
    {
        public RTSLLedgerTransRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTSLLedgerTransRuleEntity";
            KeyPrefix = "commonDataModel.rtslledgertransruleentity";
            KeySeparator = ".";
            Grouping = "/RTSLLedgerTransRuleEntity";

            AddGroup("Common Data Model RTSLLedgerTransRuleEntity Details", group =>
            {
                Crediting = group.Add(new VocabularyKey(nameof(Crediting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyRuleGroupId = group.Add(new VocabularyKey(nameof(CurrencyRuleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionRuleGroupId = group.Add(new VocabularyKey(nameof(DimensionRuleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountNum = group.Add(new VocabularyKey(nameof(MainAccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountNumOffset = group.Add(new VocabularyKey(nameof(MainAccountNumOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RuleGroupId = group.Add(new VocabularyKey(nameof(RuleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToMainAccountNum = group.Add(new VocabularyKey(nameof(ToMainAccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToAccount = group.Add(new VocabularyKey(nameof(ToAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Crediting { get; private set; }
public VocabularyKey CurrencyRuleGroupId { get; private set; }
public VocabularyKey DimensionRuleGroupId { get; private set; }
public VocabularyKey MainAccountNum { get; private set; }
public VocabularyKey MainAccountNumOffset { get; private set; }
public VocabularyKey Priority { get; private set; }
public VocabularyKey RuleGroupId { get; private set; }
public VocabularyKey ToMainAccountNum { get; private set; }
public VocabularyKey LineId { get; private set; }
public VocabularyKey MainAccount { get; private set; }
public VocabularyKey OffsetAccount { get; private set; }
public VocabularyKey ToAccount { get; private set; }


    }
}