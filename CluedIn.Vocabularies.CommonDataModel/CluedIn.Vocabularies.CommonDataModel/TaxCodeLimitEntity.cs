using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxCodeLimitEntityVocabulary : SimpleVocabulary
    {
        public TaxCodeLimitEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxCodeLimitEntity";
            KeyPrefix = "commonDataModel.taxcodelimitentity";
            KeySeparator = ".";
            Grouping = "/TaxCodeLimitEntity";

            AddGroup("Common Data Model TaxCodeLimitEntity Details", group =>
            {
                TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumSalesTax = group.Add(new VocabularyKey(nameof(MaximumSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumSalesTax = group.Add(new VocabularyKey(nameof(MinimumSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TaxCodeId { get; private set; }
public VocabularyKey FromDate { get; private set; }
public VocabularyKey MaximumSalesTax { get; private set; }
public VocabularyKey MinimumSalesTax { get; private set; }
public VocabularyKey ToDate { get; private set; }


    }
}