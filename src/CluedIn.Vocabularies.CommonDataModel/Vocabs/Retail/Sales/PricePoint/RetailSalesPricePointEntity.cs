using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSalesPricePointEntityVocabulary : SimpleVocabulary
    {
        public RetailSalesPricePointEntityVocabulary()
        {
            VocabularyName = "RetailSalesPricePointEntity";
            KeyPrefix = "commonDataModel.retailsalespricepointentity";
            KeySeparator = ".";
            Grouping = "/RetailSalesPricePointEntity";

            AddGroup("RetailSalesPricePointEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Price = group.Add(new VocabularyKey(nameof(Price), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey Price { get; private set; }


    }
}