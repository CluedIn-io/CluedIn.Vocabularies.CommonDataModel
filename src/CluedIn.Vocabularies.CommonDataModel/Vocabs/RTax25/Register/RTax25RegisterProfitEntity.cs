using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25RegisterProfitEntityVocabulary : SimpleVocabulary
    {
        public RTax25RegisterProfitEntityVocabulary()
        {
            VocabularyName = "R Tax 25 Register Profit Entity";
            KeyPrefix = "commonDataModel.rtax25registerprofitentity";
            KeySeparator = ".";
            Grouping = "/RTax25RegisterProfitEntity";

            AddGroup("RTax25RegisterProfitEntity Details", group =>
            {
                Condition = group.Add(new VocabularyKey(nameof(Condition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentCondition = group.Add(new VocabularyKey(nameof(PaymentCondition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionAsset = group.Add(new VocabularyKey(nameof(ProductionAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterId = group.Add(new VocabularyKey(nameof(RegisterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25ProfitTable = group.Add(new VocabularyKey(nameof(RTax25ProfitTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCode = group.Add(new VocabularyKey(nameof(ExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Condition { get; private set; }
        public VocabularyKey PaymentCondition { get; private set; }
        public VocabularyKey ProductionAsset { get; private set; }
        public VocabularyKey RegisterId { get; private set; }
        public VocabularyKey RTax25ProfitTable { get; private set; }
        public VocabularyKey ExpenseCode { get; private set; }
    }
}