using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvPolicyViolationsCacheEntityVocabulary : SimpleVocabulary
    {
        public TrvPolicyViolationsCacheEntityVocabulary()
        {
            VocabularyName = "TrvPolicyViolationsCacheEntity";
            KeyPrefix = "commonDataModel.trvpolicyviolationscacheentity";
            KeySeparator = ".";
            Grouping = "/TrvPolicyViolationsCacheEntity";

            AddGroup("TrvPolicyViolationsCacheEntity Details", group =>
            {
                ViolationsCacheId = group.Add(new VocabularyKey(nameof(ViolationsCacheId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Header = group.Add(new VocabularyKey(nameof(Header), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderId = group.Add(new VocabularyKey(nameof(HeaderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderLegalEntity = group.Add(new VocabularyKey(nameof(HeaderLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Line = group.Add(new VocabularyKey(nameof(Line), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentRecId = group.Add(new VocabularyKey(nameof(ParentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentId = group.Add(new VocabularyKey(nameof(ParentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyViolationLevel = group.Add(new VocabularyKey(nameof(PolicyViolationLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rule = group.Add(new VocabularyKey(nameof(Rule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyPolicyType = group.Add(new VocabularyKey(nameof(PolicyPolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleTypeName = group.Add(new VocabularyKey(nameof(PolicyRuleTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleTypePolicyType = group.Add(new VocabularyKey(nameof(PolicyRuleTypePolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleValidFrom = group.Add(new VocabularyKey(nameof(PolicyRuleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaveDateTime = group.Add(new VocabularyKey(nameof(SaveDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ViolationDate = group.Add(new VocabularyKey(nameof(ViolationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ViolationsCacheId { get; private set; }
        public VocabularyKey Header { get; private set; }
        public VocabularyKey HeaderId { get; private set; }
        public VocabularyKey HeaderLegalEntity { get; private set; }
        public VocabularyKey Line { get; private set; }
        public VocabularyKey LineId { get; private set; }
        public VocabularyKey ParentRecId { get; private set; }
        public VocabularyKey ParentId { get; private set; }
        public VocabularyKey PolicyType { get; private set; }
        public VocabularyKey PolicyViolationLevel { get; private set; }
        public VocabularyKey Rule { get; private set; }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey PolicyPolicyType { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey PolicyRuleTypeName { get; private set; }
        public VocabularyKey PolicyRuleTypePolicyType { get; private set; }
        public VocabularyKey PolicyRuleValidFrom { get; private set; }
        public VocabularyKey SaveDateTime { get; private set; }
        public VocabularyKey ViolationDate { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }


    }
}