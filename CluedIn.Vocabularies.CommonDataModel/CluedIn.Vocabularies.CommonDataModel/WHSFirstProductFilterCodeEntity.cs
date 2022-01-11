using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSFirstProductFilterCodeEntityVocabulary : SimpleVocabulary
    {
        public WHSFirstProductFilterCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSFirstProductFilterCodeEntity";
            KeyPrefix = "commonDataModel.whsfirstproductfiltercodeentity";
            KeySeparator = ".";
            Grouping = "/WHSFirstProductFilterCodeEntity";

            AddGroup("Common Data Model WHSFirstProductFilterCodeEntity Details", group =>
            {
                ProductFilterDescription = group.Add(new VocabularyKey(nameof(ProductFilterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductFilterCode = group.Add(new VocabularyKey(nameof(ProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductFilterDescription { get; private set; }
public VocabularyKey ProductFilterCode { get; private set; }


    }
}