using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorFormSetupEntityVocabulary : SimpleVocabulary
    {
        public VendorFormSetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorFormSetupEntity";
            KeyPrefix = "commonDataModel.vendorformsetupentity";
            KeySeparator = ".";
            Grouping = "/VendorFormSetupEntity";

            AddGroup("Common Data Model VendorFormSetupEntity Details", group =>
            {
                InventoryDimensionsForPrintingInvoice = group.Add(new VocabularyKey(nameof(InventoryDimensionsForPrintingInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintAmountInEuroCurrency = group.Add(new VocabularyKey(nameof(PrintAmountInEuroCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintTaxExemptNumberOnInvoice = group.Add(new VocabularyKey(nameof(PrintTaxExemptNumberOnInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSeparateTaxExemptBalanceInForms = group.Add(new VocabularyKey(nameof(IsSeparateTaxExemptBalanceInForms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxSpecification = group.Add(new VocabularyKey(nameof(SalesTaxSpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Totals = group.Add(new VocabularyKey(nameof(Totals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InventoryDimensionsForPrintingInvoice { get; private set; }
public VocabularyKey PrintAmountInEuroCurrency { get; private set; }
public VocabularyKey PrintTaxExemptNumberOnInvoice { get; private set; }
public VocabularyKey IsSeparateTaxExemptBalanceInForms { get; private set; }
public VocabularyKey SalesTaxSpecification { get; private set; }
public VocabularyKey Totals { get; private set; }


    }
}