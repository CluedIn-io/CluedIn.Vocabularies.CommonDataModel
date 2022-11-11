using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRCouponCatalogEntityVocabulary : SimpleVocabulary
    {
        public MCRCouponCatalogEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRCouponCatalogEntity";
            KeyPrefix = "commonDataModel.mcrcouponcatalogentity";
            KeySeparator = ".";
            Grouping = "/MCRCouponCatalogEntity";

            AddGroup("Common Data Model MCRCouponCatalogEntity Details", group =>
            {
                CatalogCode = group.Add(new VocabularyKey(nameof(CatalogCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CouponId = group.Add(new VocabularyKey(nameof(CouponId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CatalogCode { get; private set; }
        public VocabularyKey CouponId { get; private set; }
        public VocabularyKey CatalogNumber { get; private set; }


    }
}