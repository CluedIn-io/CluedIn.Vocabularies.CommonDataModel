using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRSalesProductSetEntityVocabulary : SimpleVocabulary
    {
        public MCRSalesProductSetEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRSalesProductSetEntity";
            KeyPrefix = "commonDataModel.mcrsalesproductsetentity";
            KeySeparator = ".";
            Grouping = "/MCRSalesProductSetEntity";

            AddGroup("Common Data Model MCRSalesProductSetEntity Details", group =>
            {
                ProductSetNumber = group.Add(new VocabularyKey(nameof(ProductSetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSetDescription = group.Add(new VocabularyKey(nameof(ProductSetDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductSetNumber { get; private set; }
public VocabularyKey ProductSetDescription { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }


    }
}