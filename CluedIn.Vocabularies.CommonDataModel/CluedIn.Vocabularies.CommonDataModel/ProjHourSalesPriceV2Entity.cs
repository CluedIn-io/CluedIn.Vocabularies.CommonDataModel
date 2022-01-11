using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjHourSalesPriceV2EntityVocabulary : SimpleVocabulary
    {
        public ProjHourSalesPriceV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjHourSalesPriceV2Entity";
            KeyPrefix = "commonDataModel.projhoursalespricev2entity";
            KeySeparator = ".";
            Grouping = "/ProjHourSalesPriceV2Entity";

            AddGroup("Common Data Model ProjHourSalesPriceV2Entity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyId = group.Add(new VocabularyKey(nameof(CurrencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceGroup = group.Add(new VocabularyKey(nameof(PriceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPriceModel = group.Add(new VocabularyKey(nameof(SalesPriceModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPricing = group.Add(new VocabularyKey(nameof(SalesPricing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFor = group.Add(new VocabularyKey(nameof(ValidFor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractId = group.Add(new VocabularyKey(nameof(ProjectContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceCategoryId = group.Add(new VocabularyKey(nameof(ResourceCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceCompanyId = group.Add(new VocabularyKey(nameof(ResourceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CategoryId { get; private set; }
public VocabularyKey CurrencyId { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey PriceGroup { get; private set; }
public VocabularyKey SalesPriceModel { get; private set; }
public VocabularyKey SalesPricing { get; private set; }
public VocabularyKey ValidFor { get; private set; }
public VocabularyKey CustomerAccount { get; private set; }
public VocabularyKey ProjectContractId { get; private set; }
public VocabularyKey Resource { get; private set; }
public VocabularyKey TransDate { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey ResourceId { get; private set; }
public VocabularyKey ResourceCategoryId { get; private set; }
public VocabularyKey ResourceCompanyId { get; private set; }


    }
}