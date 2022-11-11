using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCDSEstimateExpensesImportEntityVocabulary : SimpleVocabulary
    {
        public ProjCDSEstimateExpensesImportEntityVocabulary()
        {
            VocabularyName = "ProjCDSEstimateExpensesImportEntity";
            KeyPrefix = "commonDataModel.projcdsestimateexpensesimportentity";
            KeySeparator = ".";
            Grouping = "/ProjCDSEstimateExpensesImportEntity";

            AddGroup("ProjCDSEstimateExpensesImportEntity Details", group =>
            {
                TaskId = group.Add(new VocabularyKey(nameof(TaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Price = group.Add(new VocabularyKey(nameof(Price), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyId = group.Add(new VocabularyKey(nameof(CurrencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelId = group.Add(new VocabularyKey(nameof(ModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransType = group.Add(new VocabularyKey(nameof(TransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingType = group.Add(new VocabularyKey(nameof(BillingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCategory = group.Add(new VocabularyKey(nameof(TransactionCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimateLineId = group.Add(new VocabularyKey(nameof(EstimateLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaskId { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey CurrencyId { get; private set; }
        public VocabularyKey ModelId { get; private set; }
        public VocabularyKey TransType { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey TransactionCategory { get; private set; }
        public VocabularyKey EstimateLineId { get; private set; }


    }
}