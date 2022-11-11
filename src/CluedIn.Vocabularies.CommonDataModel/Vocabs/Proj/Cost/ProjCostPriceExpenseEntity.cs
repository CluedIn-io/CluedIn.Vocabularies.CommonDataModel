using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCostPriceExpenseEntityVocabulary : SimpleVocabulary
    {
        public ProjCostPriceExpenseEntityVocabulary()
        {
            VocabularyName = "ProjCostPriceExpenseEntity";
            KeyPrefix = "commonDataModel.projcostpriceexpenseentity";
            KeySeparator = ".";
            Grouping = "/ProjCostPriceExpenseEntity";

            AddGroup("ProjCostPriceExpenseEntity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPrice = group.Add(new VocabularyKey(nameof(CostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjId = group.Add(new VocabularyKey(nameof(ProjId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceGroup = group.Add(new VocabularyKey(nameof(PriceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractId = group.Add(new VocabularyKey(nameof(ProjectContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey CostPrice { get; private set; }
        public VocabularyKey ProjId { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey PriceGroup { get; private set; }
        public VocabularyKey ProjectContractId { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey ResourceId { get; private set; }


    }
}