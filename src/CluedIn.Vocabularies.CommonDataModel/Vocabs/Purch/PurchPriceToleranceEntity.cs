using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPriceToleranceEntityVocabulary : SimpleVocabulary
    {
        public PurchPriceToleranceEntityVocabulary()
        {
            VocabularyName = "PurchPriceToleranceEntity";
            KeyPrefix = "commonDataModel.purchpricetoleranceentity";
            KeySeparator = ".";
            Grouping = "/PurchPriceToleranceEntity";

            AddGroup("PurchPriceToleranceEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPriceTolerancePercentage = group.Add(new VocabularyKey(nameof(UnitPriceTolerancePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey UnitPriceTolerancePercentage { get; private set; }


    }
}