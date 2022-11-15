using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorPostingProfileHeaderEntityVocabulary : SimpleVocabulary
    {
        public VendorPostingProfileHeaderEntityVocabulary()
        {
            VocabularyName = "Vendor Posting Profile Header Entity";
            KeyPrefix = "commonDataModel.vendorpostingprofileheaderentity";
            KeySeparator = ".";
            Grouping = "/VendorPostingProfileHeaderEntity";

            AddGroup("VendorPostingProfileHeaderEntity Details", group =>
            {
                IsTransactionCancelEnabled = group.Add(new VocabularyKey(nameof(IsTransactionCancelEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfileToCloseSettlement = group.Add(new VocabularyKey(nameof(PostingProfileToCloseSettlement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransactionIncludedInAutoSettlement = group.Add(new VocabularyKey(nameof(IsTransactionIncludedInAutoSettlement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowEmptyDimensionValue = group.Add(new VocabularyKey(nameof(AllowEmptyDimensionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsTransactionCancelEnabled { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey PostingProfileToCloseSettlement { get; private set; }
        public VocabularyKey IsTransactionIncludedInAutoSettlement { get; private set; }
        public VocabularyKey AllowEmptyDimensionValue { get; private set; }
    }
}