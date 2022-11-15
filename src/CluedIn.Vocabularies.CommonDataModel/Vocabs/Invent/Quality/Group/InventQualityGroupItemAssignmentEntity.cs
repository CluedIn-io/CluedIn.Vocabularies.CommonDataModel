using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityGroupItemAssignmentEntityVocabulary : SimpleVocabulary
    {
        public InventQualityGroupItemAssignmentEntityVocabulary()
        {
            VocabularyName = "Invent Quality Group Item Assignment Entity";
            KeyPrefix = "commonDataModel.inventqualitygroupitemassignmententity";
            KeySeparator = ".";
            Grouping = "/InventQualityGroupItemAssignmentEntity";

            AddGroup("InventQualityGroupItemAssignmentEntity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityGroupId = group.Add(new VocabularyKey(nameof(QualityGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey QualityGroupId { get; private set; }
    }
}