using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailEcoResProductEntityVocabulary : SimpleVocabulary
    {
        public RetailEcoResProductEntityVocabulary()
        {
            VocabularyName = "RetailEcoResProductEntity";
            KeyPrefix = "commonDataModel.retailecoresproductentity";
            KeySeparator = ".";
            Grouping = "/RetailEcoResProductEntity";

            AddGroup("RetailEcoResProductEntity Details", group =>
            {
                DisplayProductNumber = group.Add(new VocabularyKey(nameof(DisplayProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstanceRelationType = group.Add(new VocabularyKey(nameof(InstanceRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PdsCWProduct = group.Add(new VocabularyKey(nameof(PdsCWProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductType = group.Add(new VocabularyKey(nameof(ProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DisplayProductNumber { get; private set; }
        public VocabularyKey InstanceRelationType { get; private set; }
        public VocabularyKey PdsCWProduct { get; private set; }
        public VocabularyKey ProductType { get; private set; }
        public VocabularyKey SearchName { get; private set; }


    }
}