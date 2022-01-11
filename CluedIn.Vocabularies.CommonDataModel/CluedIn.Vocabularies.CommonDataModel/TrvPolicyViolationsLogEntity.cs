using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvPolicyViolationsLogEntityVocabulary : SimpleVocabulary
    {
        public TrvPolicyViolationsLogEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvPolicyViolationsLogEntity";
            KeyPrefix = "commonDataModel.trvpolicyviolationslogentity";
            KeySeparator = ".";
            Grouping = "/TrvPolicyViolationsLogEntity";

            AddGroup("Common Data Model TrvPolicyViolationsLogEntity Details", group =>
            {
                ViolationsLogId = group.Add(new VocabularyKey(nameof(ViolationsLogId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Action = group.Add(new VocabularyKey(nameof(Action), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Header = group.Add(new VocabularyKey(nameof(Header), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HeaderId = group.Add(new VocabularyKey(nameof(HeaderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HeaderLegalEntity = group.Add(new VocabularyKey(nameof(HeaderLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Line = group.Add(new VocabularyKey(nameof(Line), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Rule = group.Add(new VocabularyKey(nameof(Rule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TrvPolicyRule_Policy = group.Add(new VocabularyKey(nameof(TrvPolicyRule_Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Policy_PolicyType = group.Add(new VocabularyKey(nameof(Policy_PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TrvPolicyRule_PolicyRuleType = group.Add(new VocabularyKey(nameof(TrvPolicyRule_PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyRuleTypeName = group.Add(new VocabularyKey(nameof(PolicyRuleTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyRules_PolicyType = group.Add(new VocabularyKey(nameof(PolicyRules_PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyRuleValidFrom = group.Add(new VocabularyKey(nameof(PolicyRuleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ViolationDate = group.Add(new VocabularyKey(nameof(ViolationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ViolationsLogId { get; private set; }
public VocabularyKey Action { get; private set; }
public VocabularyKey Header { get; private set; }
public VocabularyKey HeaderId { get; private set; }
public VocabularyKey HeaderLegalEntity { get; private set; }
public VocabularyKey Line { get; private set; }
public VocabularyKey LineId { get; private set; }
public VocabularyKey PolicyType { get; private set; }
public VocabularyKey Rule { get; private set; }
public VocabularyKey TrvPolicyRule_Policy { get; private set; }
public VocabularyKey PolicyName { get; private set; }
public VocabularyKey Policy_PolicyType { get; private set; }
public VocabularyKey TrvPolicyRule_PolicyRuleType { get; private set; }
public VocabularyKey PolicyRuleTypeName { get; private set; }
public VocabularyKey PolicyRules_PolicyType { get; private set; }
public VocabularyKey PolicyRuleValidFrom { get; private set; }
public VocabularyKey ViolationDate { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }


    }
}