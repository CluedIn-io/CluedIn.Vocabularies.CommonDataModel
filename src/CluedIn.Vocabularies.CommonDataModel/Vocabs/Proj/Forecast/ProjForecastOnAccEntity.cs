using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjForecastOnAccEntityVocabulary : SimpleVocabulary
    {
        public ProjForecastOnAccEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjForecastOnAccEntity";
            KeyPrefix = "commonDataModel.projforecastonaccentity";
            KeySeparator = ".";
            Grouping = "/ProjForecastOnAccEntity";

            AddGroup("Common Data Model ProjForecastOnAccEntity Details", group =>
            {
                SalesCurrency = group.Add(new VocabularyKey(nameof(SalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EliminationDate = group.Add(new VocabularyKey(nameof(EliminationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastModel = group.Add(new VocabularyKey(nameof(ForecastModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetType = group.Add(new VocabularyKey(nameof(BudgetType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FundingSource = group.Add(new VocabularyKey(nameof(FundingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPaymentDate = group.Add(new VocabularyKey(nameof(SalesPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectDate = group.Add(new VocabularyKey(nameof(ProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionID = group.Add(new VocabularyKey(nameof(TransactionID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FundingSourceID = group.Add(new VocabularyKey(nameof(FundingSourceID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SalesCurrency { get; private set; }
public VocabularyKey DefaultDimension { get; private set; }
public VocabularyKey EliminationDate { get; private set; }
public VocabularyKey ExchangeRate { get; private set; }
public VocabularyKey InvoiceDate { get; private set; }
public VocabularyKey ForecastModel { get; private set; }
public VocabularyKey BudgetType { get; private set; }
public VocabularyKey FundingSource { get; private set; }
public VocabularyKey ProjectID { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey SalesPaymentDate { get; private set; }
public VocabularyKey SalesPrice { get; private set; }
public VocabularyKey ProjectDate { get; private set; }
public VocabularyKey TransactionID { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey ProjectContractID { get; private set; }
public VocabularyKey FundingSourceID { get; private set; }
public VocabularyKey DefaultDimensionDisplayValue { get; private set; }


    }
}