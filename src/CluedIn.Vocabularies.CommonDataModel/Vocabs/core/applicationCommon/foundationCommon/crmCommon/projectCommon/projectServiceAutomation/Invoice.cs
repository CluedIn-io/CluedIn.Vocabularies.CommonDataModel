using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class InvoiceVocabulary : SimpleVocabulary
    {
        public InvoiceVocabulary()
        {
            VocabularyName = "Invoice";
            KeyPrefix = "commonDataModel.invoice.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/Invoice";

            AddGroup("Invoice Details for ProjectServiceAutomation", group =>
            {
			    SalesOrderId = group.Add(new VocabularyKey(nameof(SalesOrderId), "Contract", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillToContactName = group.Add(new VocabularyKey(nameof(BillToContactName), "Bill To Contact Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HasCorrections = group.Add(new VocabularyKey(nameof(HasCorrections), "Has Corrections", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    OrderType = group.Add(new VocabularyKey(nameof(OrderType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProjectInvoiceStatus = group.Add(new VocabularyKey(nameof(ProjectInvoiceStatus), "Project Invoice Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SalesOrderId { get; private set; }
        public VocabularyKey BillToContactName { get; private set; }
        public VocabularyKey HasCorrections { get; private set; }
        public VocabularyKey OrderType { get; private set; }
        public VocabularyKey ProjectInvoiceStatus { get; private set; }
    }
}