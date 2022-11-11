using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventSupplementaryProductVendorGroupEntityVocabulary : SimpleVocabulary
    {
        public InventSupplementaryProductVendorGroupEntityVocabulary()
        {
            VocabularyName = "InventSupplementaryProductVendorGroupEntity";
            KeyPrefix = "commonDataModel.inventsupplementaryproductvendorgroupentity";
            KeySeparator = ".";
            Grouping = "/InventSupplementaryProductVendorGroupEntity";

            AddGroup("InventSupplementaryProductVendorGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}