using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorPriceToleranceGroupEntityVocabulary : SimpleVocabulary
    {
        public VendorPriceToleranceGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorPriceToleranceGroupEntity";
            KeyPrefix = "commonDataModel.vendorpricetolerancegroupentity";
            KeySeparator = ".";
            Grouping = "/VendorPriceToleranceGroupEntity";

            AddGroup("Common Data Model VendorPriceToleranceGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}