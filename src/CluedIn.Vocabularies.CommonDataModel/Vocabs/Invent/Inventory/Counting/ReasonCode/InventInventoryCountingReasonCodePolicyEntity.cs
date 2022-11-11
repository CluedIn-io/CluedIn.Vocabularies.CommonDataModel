using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryCountingReasonCodePolicyEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryCountingReasonCodePolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventInventoryCountingReasonCodePolicyEntity";
            KeyPrefix = "commonDataModel.inventinventorycountingreasoncodepolicyentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryCountingReasonCodePolicyEntity";

            AddGroup("Common Data Model InventInventoryCountingReasonCodePolicyEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventCountingReasonCodeType = group.Add(new VocabularyKey(nameof(InventCountingReasonCodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey InventCountingReasonCodeType { get; private set; }


    }
}