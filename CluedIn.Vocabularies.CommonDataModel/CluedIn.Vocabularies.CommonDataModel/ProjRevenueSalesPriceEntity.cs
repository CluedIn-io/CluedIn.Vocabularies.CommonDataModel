using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjRevenueSalesPriceEntityVocabulary : SimpleVocabulary
    {
        public ProjRevenueSalesPriceEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjRevenueSalesPriceEntity";
            KeyPrefix = "commonDataModel.projrevenuesalespriceentity";
            KeySeparator = ".";
            Grouping = "/ProjRevenueSalesPriceEntity";

            AddGroup("Common Data Model ProjRevenueSalesPriceEntity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesCurrency = group.Add(new VocabularyKey(nameof(SalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceGroup = group.Add(new VocabularyKey(nameof(PriceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Role = group.Add(new VocabularyKey(nameof(Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjValidFor = group.Add(new VocabularyKey(nameof(ProjValidFor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CategoryId { get; private set; }
public VocabularyKey SalesCurrency { get; private set; }
public VocabularyKey ProjectID { get; private set; }
public VocabularyKey PriceGroup { get; private set; }
public VocabularyKey CustomerAccount { get; private set; }
public VocabularyKey ProjectContractID { get; private set; }
public VocabularyKey Resource { get; private set; }
public VocabularyKey Role { get; private set; }
public VocabularyKey SalesPrice { get; private set; }
public VocabularyKey EffectiveDate { get; private set; }
public VocabularyKey ProjValidFor { get; private set; }
public VocabularyKey ResourceId { get; private set; }


    }
}