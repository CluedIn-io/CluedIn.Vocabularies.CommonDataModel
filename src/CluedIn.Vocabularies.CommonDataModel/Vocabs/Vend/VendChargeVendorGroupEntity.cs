using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendChargeVendorGroupEntityVocabulary : SimpleVocabulary
    {
        public VendChargeVendorGroupEntityVocabulary()
        {
            VocabularyName = "Vend Charge Vendor Group Entity";
            KeyPrefix = "commonDataModel.vendchargevendorgroupentity";
            KeySeparator = ".";
            Grouping = "/VendChargeVendorGroupEntity";

            AddGroup("VendChargeVendorGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}