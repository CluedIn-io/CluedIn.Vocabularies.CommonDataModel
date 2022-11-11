using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankReconciliationMatchingRuleEntityVocabulary : SimpleVocabulary
    {
        public BankReconciliationMatchingRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankReconciliationMatchingRuleEntity";
            KeyPrefix = "commonDataModel.bankreconciliationmatchingruleentity";
            KeySeparator = ".";
            Grouping = "/BankReconciliationMatchingRuleEntity";

            AddGroup("Common Data Model BankReconciliationMatchingRuleEntity Details", group =>
            {
                MatchActionType = group.Add(new VocabularyKey(nameof(MatchActionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingRule = group.Add(new VocabularyKey(nameof(MatchingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchBankDocuments = group.Add(new VocabularyKey(nameof(SearchBankDocuments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldId = group.Add(new VocabularyKey(nameof(FieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareFieldId = group.Add(new VocabularyKey(nameof(CompareFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Operator = group.Add(new VocabularyKey(nameof(Operator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceTableId = group.Add(new VocabularyKey(nameof(SourceTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Field = group.Add(new VocabularyKey(nameof(Field), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareField = group.Add(new VocabularyKey(nameof(CompareField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompareFieldExpression = group.Add(new VocabularyKey(nameof(CompareFieldExpression), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemGeneratedType = group.Add(new VocabularyKey(nameof(SystemGeneratedType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MatchActionType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey MatchingRule { get; private set; }
        public VocabularyKey SearchBankDocuments { get; private set; }
        public VocabularyKey FieldId { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey CompareFieldId { get; private set; }
        public VocabularyKey LineId { get; private set; }
        public VocabularyKey Operator { get; private set; }
        public VocabularyKey SourceTableId { get; private set; }
        public VocabularyKey Field { get; private set; }
        public VocabularyKey CompareField { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey CompareFieldExpression { get; private set; }
        public VocabularyKey SystemGeneratedType { get; private set; }


    }
}