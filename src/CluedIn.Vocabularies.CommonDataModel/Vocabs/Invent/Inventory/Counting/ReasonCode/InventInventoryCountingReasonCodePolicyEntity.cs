using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryCountingReasonCodePolicyEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryCountingReasonCodePolicyEntityVocabulary()
        {
            VocabularyName = "Invent Inventory Counting Reason Code Policy Entity";
            KeyPrefix = "commonDataModel.inventinventorycountingreasoncodepolicyentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryCountingReasonCodePolicyEntity";

            AddGroup("InventInventoryCountingReasonCodePolicyEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventCountingReasonCodeType = group.Add(new VocabularyKey(nameof(InventCountingReasonCodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey InventCountingReasonCodeType { get; private set; }
    }
}