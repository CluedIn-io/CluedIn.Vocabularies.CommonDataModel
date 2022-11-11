using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInventTableEntityVocabulary : SimpleVocabulary
    {
        public RetailInventTableEntityVocabulary()
        {
            VocabularyName = "RetailInventTableEntity";
            KeyPrefix = "commonDataModel.retailinventtableentity";
            KeySeparator = ".";
            Grouping = "/RetailInventTableEntity";

            AddGroup("RetailInventTableEntity Details", group =>
            {
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Product = group.Add(new VocabularyKey(nameof(Product), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResProduct_DisplayProductNumber = group.Add(new VocabularyKey(nameof(EcoResProduct_DisplayProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey Product { get; private set; }
        public VocabularyKey EcoResProduct_DisplayProductNumber { get; private set; }


    }
}