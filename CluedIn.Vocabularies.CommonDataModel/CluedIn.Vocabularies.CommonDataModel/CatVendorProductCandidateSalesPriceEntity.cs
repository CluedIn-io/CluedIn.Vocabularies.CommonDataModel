using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CatVendorProductCandidateSalesPriceEntityVocabulary : SimpleVocabulary
    {
        public CatVendorProductCandidateSalesPriceEntityVocabulary()
        {
            VocabularyName = "Common Data Model CatVendorProductCandidateSalesPriceEntity";
            KeyPrefix = "commonDataModel.catvendorproductcandidatesalespriceentity";
            KeySeparator = ".";
            Grouping = "/CatVendorProductCandidateSalesPriceEntity";

            AddGroup("Common Data Model CatVendorProductCandidateSalesPriceEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Price = group.Add(new VocabularyKey(nameof(Price), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SuggestedPrice = group.Add(new VocabularyKey(nameof(SuggestedPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitOfMeasureRecId = group.Add(new VocabularyKey(nameof(UnitOfMeasureRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCandidateRecId = group.Add(new VocabularyKey(nameof(ProductCandidateRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CatalogMaintenanceRequestRecId = group.Add(new VocabularyKey(nameof(CatalogMaintenanceRequestRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCandidateColorId = group.Add(new VocabularyKey(nameof(ProductCandidateColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCandidateConfigurationId = group.Add(new VocabularyKey(nameof(ProductCandidateConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCandidateProductSubtype = group.Add(new VocabularyKey(nameof(ProductCandidateProductSubtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCandidateSizeId = group.Add(new VocabularyKey(nameof(ProductCandidateSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCandidateProductNumber = group.Add(new VocabularyKey(nameof(ProductCandidateProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCandidateStyleId = group.Add(new VocabularyKey(nameof(ProductCandidateStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorCatalogMaintenanceRequestUploadDateTime = group.Add(new VocabularyKey(nameof(VendorCatalogMaintenanceRequestUploadDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey Price { get; private set; }
public VocabularyKey SuggestedPrice { get; private set; }
public VocabularyKey UnitOfMeasureRecId { get; private set; }
public VocabularyKey ProductCandidateRecId { get; private set; }
public VocabularyKey CatalogMaintenanceRequestRecId { get; private set; }
public VocabularyKey ProductCandidateColorId { get; private set; }
public VocabularyKey ProductCandidateConfigurationId { get; private set; }
public VocabularyKey ProductCandidateProductSubtype { get; private set; }
public VocabularyKey ProductCandidateSizeId { get; private set; }
public VocabularyKey ProductCandidateProductNumber { get; private set; }
public VocabularyKey ProductCandidateStyleId { get; private set; }
public VocabularyKey VendorCatalogMaintenanceRequestUploadDateTime { get; private set; }
public VocabularyKey UnitSymbol { get; private set; }


    }
}