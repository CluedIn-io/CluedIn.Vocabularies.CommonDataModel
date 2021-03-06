using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSThirdProductFilterCodeEntityVocabulary : SimpleVocabulary
    {
        public WHSThirdProductFilterCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSThirdProductFilterCodeEntity";
            KeyPrefix = "commonDataModel.whsthirdproductfiltercodeentity";
            KeySeparator = ".";
            Grouping = "/WHSThirdProductFilterCodeEntity";

            AddGroup("Common Data Model WHSThirdProductFilterCodeEntity Details", group =>
            {
                ProductFilterDescription = group.Add(new VocabularyKey(nameof(ProductFilterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductFilterCode = group.Add(new VocabularyKey(nameof(ProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductFilterDescription { get; private set; }
public VocabularyKey ProductFilterCode { get; private set; }


    }
}