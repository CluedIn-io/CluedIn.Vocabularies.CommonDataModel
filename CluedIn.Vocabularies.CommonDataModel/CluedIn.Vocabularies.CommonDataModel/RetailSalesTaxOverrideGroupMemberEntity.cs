using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSalesTaxOverrideGroupMemberEntityVocabulary : SimpleVocabulary
    {
        public RetailSalesTaxOverrideGroupMemberEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailSalesTaxOverrideGroupMemberEntity";
            KeyPrefix = "commonDataModel.retailsalestaxoverridegroupmemberentity";
            KeySeparator = ".";
            Grouping = "/RetailSalesTaxOverrideGroupMemberEntity";

            AddGroup("Common Data Model RetailSalesTaxOverrideGroupMemberEntity Details", group =>
            {
                SalesTaxOverrideCode = group.Add(new VocabularyKey(nameof(SalesTaxOverrideCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxOverrideGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxOverrideGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SalesTaxOverrideCode { get; private set; }
public VocabularyKey SalesTaxOverrideGroupCode { get; private set; }


    }
}