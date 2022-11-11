using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorPaymFeeGroupEntityVocabulary : SimpleVocabulary
    {
        public VendVendorPaymFeeGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendVendorPaymFeeGroupEntity";
            KeyPrefix = "commonDataModel.vendvendorpaymfeegroupentity";
            KeySeparator = ".";
            Grouping = "/VendVendorPaymFeeGroupEntity";

            AddGroup("Common Data Model VendVendorPaymFeeGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey GroupId { get; private set; }


    }
}