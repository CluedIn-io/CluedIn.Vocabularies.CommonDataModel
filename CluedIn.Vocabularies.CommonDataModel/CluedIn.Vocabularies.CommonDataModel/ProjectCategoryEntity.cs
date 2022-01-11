using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjectCategoryEntityVocabulary : SimpleVocabulary
    {
        public ProjectCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjectCategoryEntity";
            KeyPrefix = "commonDataModel.projectcategoryentity";
            KeySeparator = ".";
            Grouping = "/ProjectCategoryEntity";

            AddGroup("Common Data Model ProjectCategoryEntity Details", group =>
            {
                ActiveInJournals = group.Add(new VocabularyKey(nameof(ActiveInJournals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryGroup = group.Add(new VocabularyKey(nameof(CategoryGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerPaymentRetention = group.Add(new VocabularyKey(nameof(CustomerPaymentRetention), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IndirectCostComponent = group.Add(new VocabularyKey(nameof(IndirectCostComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Estimate = group.Add(new VocabularyKey(nameof(Estimate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Subscription = group.Add(new VocabularyKey(nameof(Subscription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Absence = group.Add(new VocabularyKey(nameof(Absence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalInformationServiceCode = group.Add(new VocabularyKey(nameof(FiscalInformationServiceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemWithholdingTaxGroup = group.Add(new VocabularyKey(nameof(ItemWithholdingTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemWithholdingTaxGroupId = group.Add(new VocabularyKey(nameof(ItemWithholdingTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxRateTypeName = group.Add(new VocabularyKey(nameof(TaxRateTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ActiveInJournals { get; private set; }
public VocabularyKey CategoryGroup { get; private set; }
public VocabularyKey Category { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey CategoryName { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey CustomerPaymentRetention { get; private set; }
public VocabularyKey IndirectCostComponent { get; private set; }
public VocabularyKey Estimate { get; private set; }
public VocabularyKey Subscription { get; private set; }
public VocabularyKey ItemSalesTaxGroup { get; private set; }
public VocabularyKey Absence { get; private set; }
public VocabularyKey FiscalInformationServiceCode { get; private set; }
public VocabularyKey ItemWithholdingTaxGroup { get; private set; }
public VocabularyKey ItemWithholdingTaxGroupId { get; private set; }
public VocabularyKey TaxRateTypeName { get; private set; }


    }
}