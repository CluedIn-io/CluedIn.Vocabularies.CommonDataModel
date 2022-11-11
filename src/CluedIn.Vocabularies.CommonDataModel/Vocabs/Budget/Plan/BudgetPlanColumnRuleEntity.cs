using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanColumnRuleEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanColumnRuleEntityVocabulary()
        {
            VocabularyName = "BudgetPlanColumnRuleEntity";
            KeyPrefix = "commonDataModel.budgetplancolumnruleentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanColumnRuleEntity";

            AddGroup("BudgetPlanColumnRuleEntity Details", group =>
            {
                Column = group.Add(new VocabularyKey(nameof(Column), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Operator = group.Add(new VocabularyKey(nameof(Operator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RightSideValueOne = group.Add(new VocabularyKey(nameof(RightSideValueOne), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RightSideValueTwo = group.Add(new VocabularyKey(nameof(RightSideValueTwo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnName = group.Add(new VocabularyKey(nameof(ColumnName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Column { get; private set; }
        public VocabularyKey TableName { get; private set; }
        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey Operator { get; private set; }
        public VocabularyKey RightSideValueOne { get; private set; }
        public VocabularyKey RightSideValueTwo { get; private set; }
        public VocabularyKey ColumnName { get; private set; }


    }
}