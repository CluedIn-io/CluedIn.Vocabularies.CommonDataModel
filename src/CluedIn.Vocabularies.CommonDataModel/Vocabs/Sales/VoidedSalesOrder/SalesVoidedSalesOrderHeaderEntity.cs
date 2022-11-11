using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesVoidedSalesOrderHeaderEntityVocabulary : SimpleVocabulary
    {
        public SalesVoidedSalesOrderHeaderEntityVocabulary()
        {
            VocabularyName = "SalesVoidedSalesOrderHeaderEntity";
            KeyPrefix = "commonDataModel.salesvoidedsalesorderheaderentity";
            KeySeparator = ".";
            Grouping = "/SalesVoidedSalesOrderHeaderEntity";

            AddGroup("SalesVoidedSalesOrderHeaderEntity Details", group =>
            {
                OrderingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderName = group.Add(new VocabularyKey(nameof(SalesOrderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OrderingCustomerAccountNumber { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey SalesOrderName { get; private set; }


    }
}