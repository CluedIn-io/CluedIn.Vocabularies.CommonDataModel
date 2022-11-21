using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjVendorRetentionTermEntityVocabulary : SimpleVocabulary
    {
        public ProjVendorRetentionTermEntityVocabulary()
        {
            VocabularyName = "Proj Vendor Retention Term Entity";
            KeyPrefix = "commonDataModel.projvendorretentiontermentity";
            KeySeparator = ".";
            Grouping = "/ProjVendorRetentionTermEntity";

            AddGroup("ProjVendorRetentionTermEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleID = group.Add(new VocabularyKey(nameof(RuleID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RuleID { get; private set; }
    }
}