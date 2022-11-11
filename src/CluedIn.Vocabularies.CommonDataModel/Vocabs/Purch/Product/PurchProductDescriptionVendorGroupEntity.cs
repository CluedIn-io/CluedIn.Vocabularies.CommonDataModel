using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchProductDescriptionVendorGroupEntityVocabulary : SimpleVocabulary
    {
        public PurchProductDescriptionVendorGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchProductDescriptionVendorGroupEntity";
            KeyPrefix = "commonDataModel.purchproductdescriptionvendorgroupentity";
            KeySeparator = ".";
            Grouping = "/PurchProductDescriptionVendorGroupEntity";

            AddGroup("Common Data Model PurchProductDescriptionVendorGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}