using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceSubscriptionSalesPriceEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceSubscriptionSalesPriceEntityVocabulary()
        {
            VocabularyName = "SMA Service Subscription Sales Price Entity";
            KeyPrefix = "commonDataModel.smaservicesubscriptionsalespriceentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceSubscriptionSalesPriceEntity";

            AddGroup("SMAServiceSubscriptionSalesPriceEntity Details", group =>
            {
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceCurrencyCode = group.Add(new VocabularyKey(nameof(SalesPriceCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicingPeriodTypeCode = group.Add(new VocabularyKey(nameof(InvoicingPeriodTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCustomerGroupCode = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjValidFor = group.Add(new VocabularyKey(nameof(ProjValidFor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceSubscriptionId = group.Add(new VocabularyKey(nameof(ServiceSubscriptionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey SalesPriceCurrencyCode { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey InvoicingPeriodTypeCode { get; private set; }
        public VocabularyKey PriceCustomerGroupCode { get; private set; }
        public VocabularyKey ProjValidFor { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey ServiceSubscriptionId { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
    }
}