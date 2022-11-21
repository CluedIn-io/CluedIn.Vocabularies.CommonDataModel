using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorExceptionGroupEntityVocabulary : SimpleVocabulary
    {
        public VendorExceptionGroupEntityVocabulary()
        {
            VocabularyName = "Vendor Exception Group Entity";
            KeyPrefix = "commonDataModel.vendorexceptiongroupentity";
            KeySeparator = ".";
            Grouping = "/VendorExceptionGroupEntity";

            AddGroup("VendorExceptionGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey GroupId { get; private set; }
    }
}