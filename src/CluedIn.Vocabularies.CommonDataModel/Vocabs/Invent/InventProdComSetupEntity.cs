using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventProdComSetupEntityVocabulary : SimpleVocabulary
    {
        public InventProdComSetupEntityVocabulary()
        {
            VocabularyName = "InventProdComSetupEntity";
            KeyPrefix = "commonDataModel.inventprodcomsetupentity";
            KeySeparator = ".";
            Grouping = "/InventProdComSetupEntity";

            AddGroup("InventProdComSetupEntity Details", group =>
            {
                WorkDoneForEnterprises = group.Add(new VocabularyKey(nameof(WorkDoneForEnterprises), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryToAThirdParty = group.Add(new VocabularyKey(nameof(DeliveryToAThirdParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMadeInCompany = group.Add(new VocabularyKey(nameof(ProductMadeInCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WorkDoneForEnterprises { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey DeliveryToAThirdParty { get; private set; }
        public VocabularyKey ProductMadeInCompany { get; private set; }


    }
}