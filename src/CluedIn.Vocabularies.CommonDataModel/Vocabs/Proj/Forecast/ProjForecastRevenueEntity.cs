using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjForecastRevenueEntityVocabulary : SimpleVocabulary
    {
        public ProjForecastRevenueEntityVocabulary()
        {
            VocabularyName = "ProjForecastRevenueEntity";
            KeyPrefix = "commonDataModel.projforecastrevenueentity";
            KeySeparator = ".";
            Grouping = "/ProjForecastRevenueEntity";

            AddGroup("ProjForecastRevenueEntity Details", group =>
            {
                Active = group.Add(new VocabularyKey(nameof(Active), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Method = group.Add(new VocabularyKey(nameof(Method), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCurrency = group.Add(new VocabularyKey(nameof(SalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EliminationDate = group.Add(new VocabularyKey(nameof(EliminationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                End = group.Add(new VocabularyKey(nameof(End), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Unit = group.Add(new VocabularyKey(nameof(Unit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineProperty = group.Add(new VocabularyKey(nameof(LineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastModel = group.Add(new VocabularyKey(nameof(ForecastModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodKey = group.Add(new VocabularyKey(nameof(PeriodKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetType = group.Add(new VocabularyKey(nameof(BudgetType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPaymentDate = group.Add(new VocabularyKey(nameof(SalesPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectDate = group.Add(new VocabularyKey(nameof(ProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Stop = group.Add(new VocabularyKey(nameof(Stop), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionID = group.Add(new VocabularyKey(nameof(TransactionID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCompanyId = group.Add(new VocabularyKey(nameof(ResourceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingSource = group.Add(new VocabularyKey(nameof(FundingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingSourceID = group.Add(new VocabularyKey(nameof(FundingSourceID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategory = group.Add(new VocabularyKey(nameof(ResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategoryId = group.Add(new VocabularyKey(nameof(ResourceCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Active { get; private set; }
        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey Method { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey SalesCurrency { get; private set; }
        public VocabularyKey EliminationDate { get; private set; }
        public VocabularyKey End { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey Unit { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey LineProperty { get; private set; }
        public VocabularyKey ForecastModel { get; private set; }
        public VocabularyKey PeriodKey { get; private set; }
        public VocabularyKey BudgetType { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey SalesPaymentDate { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey ProjectDate { get; private set; }
        public VocabularyKey Stop { get; private set; }
        public VocabularyKey TransactionID { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey ResourceCompanyId { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey FundingSource { get; private set; }
        public VocabularyKey ProjectContractID { get; private set; }
        public VocabularyKey FundingSourceID { get; private set; }
        public VocabularyKey ResourceCategory { get; private set; }
        public VocabularyKey ResourceCategoryId { get; private set; }


    }
}