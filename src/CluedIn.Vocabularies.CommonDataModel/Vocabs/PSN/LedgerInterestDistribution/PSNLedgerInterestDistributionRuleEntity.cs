using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSNLedgerInterestDistributionRuleEntityVocabulary : SimpleVocabulary
    {
        public PSNLedgerInterestDistributionRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model PSNLedgerInterestDistributionRuleEntity";
            KeyPrefix = "commonDataModel.psnledgerinterestdistributionruleentity";
            KeySeparator = ".";
            Grouping = "/PSNLedgerInterestDistributionRuleEntity";

            AddGroup("Common Data Model PSNLedgerInterestDistributionRuleEntity Details", group =>
            {
                CashAccount = group.Add(new VocabularyKey(nameof(CashAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashAccountDisplayValue = group.Add(new VocabularyKey(nameof(CashAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashAccountName = group.Add(new VocabularyKey(nameof(CashAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterestAccount = group.Add(new VocabularyKey(nameof(InterestAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterestAccountDisplayValue = group.Add(new VocabularyKey(nameof(InterestAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterestAccountName = group.Add(new VocabularyKey(nameof(InterestAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Grant = group.Add(new VocabularyKey(nameof(Grant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GrantID = group.Add(new VocabularyKey(nameof(GrantID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FundingSourceForPosting = group.Add(new VocabularyKey(nameof(FundingSourceForPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FundingSourceID = group.Add(new VocabularyKey(nameof(FundingSourceID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NegativeInterest = group.Add(new VocabularyKey(nameof(NegativeInterest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Rounding = group.Add(new VocabularyKey(nameof(Rounding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RuleId = group.Add(new VocabularyKey(nameof(RuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CashAccount { get; private set; }
public VocabularyKey CashAccountDisplayValue { get; private set; }
public VocabularyKey CashAccountName { get; private set; }
public VocabularyKey InterestAccount { get; private set; }
public VocabularyKey InterestAccountDisplayValue { get; private set; }
public VocabularyKey InterestAccountName { get; private set; }
public VocabularyKey Grant { get; private set; }
public VocabularyKey GrantID { get; private set; }
public VocabularyKey ProjectID { get; private set; }
public VocabularyKey FundingSourceForPosting { get; private set; }
public VocabularyKey ProjectContractID { get; private set; }
public VocabularyKey FundingSourceID { get; private set; }
public VocabularyKey NegativeInterest { get; private set; }
public VocabularyKey Rounding { get; private set; }
public VocabularyKey RuleId { get; private set; }


    }
}