using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTenderDiscountPriceGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailTenderDiscountPriceGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTenderDiscountPriceGroupEntity";
            KeyPrefix = "commonDataModel.retailtenderdiscountpricegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailTenderDiscountPriceGroupEntity";

            AddGroup("Common Data Model RetailTenderDiscountPriceGroupEntity Details", group =>
            {
                PriceDiscGroup = group.Add(new VocabularyKey(nameof(PriceDiscGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailTenderDiscount = group.Add(new VocabularyKey(nameof(RetailTenderDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceGroupId = group.Add(new VocabularyKey(nameof(PriceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OfferId = group.Add(new VocabularyKey(nameof(OfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PriceDiscGroup { get; private set; }
public VocabularyKey RetailTenderDiscount { get; private set; }
public VocabularyKey PriceGroupId { get; private set; }
public VocabularyKey OfferId { get; private set; }


    }
}