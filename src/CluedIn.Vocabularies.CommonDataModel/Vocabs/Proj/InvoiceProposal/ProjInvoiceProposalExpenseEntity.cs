using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjInvoiceProposalExpenseEntityVocabulary : SimpleVocabulary
    {
        public ProjInvoiceProposalExpenseEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjInvoiceProposalExpenseEntity";
            KeyPrefix = "commonDataModel.projinvoiceproposalexpenseentity";
            KeySeparator = ".";
            Grouping = "/ProjInvoiceProposalExpenseEntity";

            AddGroup("Common Data Model ProjInvoiceProposalExpenseEntity Details", group =>
            {
                InvoiceProposalId = group.Add(new VocabularyKey(nameof(InvoiceProposalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectTransactionId = group.Add(new VocabularyKey(nameof(ProjectTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectDate = group.Add(new VocabularyKey(nameof(ProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectLineProperty = group.Add(new VocabularyKey(nameof(ProjectLineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludedTaxPercentage = group.Add(new VocabularyKey(nameof(IncludedTaxPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InvoiceProposalId { get; private set; }
public VocabularyKey SalesTaxGroup { get; private set; }
public VocabularyKey ItemSalesTaxGroup { get; private set; }
public VocabularyKey ProjectTransactionId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey ProjectDate { get; private set; }
public VocabularyKey ProjectLineProperty { get; private set; }
public VocabularyKey ProjectCategoryId { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey ActivityNumber { get; private set; }
public VocabularyKey Resource { get; private set; }
public VocabularyKey ResourceId { get; private set; }
public VocabularyKey SalesPrice { get; private set; }
public VocabularyKey LineAmount { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey IncludedTaxPercentage { get; private set; }


    }
}