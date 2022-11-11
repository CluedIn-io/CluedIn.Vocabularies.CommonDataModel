using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlMessageLevelEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlMessageLevelEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetControlMessageLevelEntity";
            KeyPrefix = "commonDataModel.budgetcontrolmessagelevelentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlMessageLevelEntity";

            AddGroup("Common Data Model BudgetControlMessageLevelEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroupId = group.Add(new VocabularyKey(nameof(UserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroupName = group.Add(new VocabularyKey(nameof(UserGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Selected = group.Add(new VocabularyKey(nameof(Selected), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey InUseBy { get; private set; }
        public VocabularyKey UserGroupId { get; private set; }
        public VocabularyKey UserGroupName { get; private set; }
        public VocabularyKey Selected { get; private set; }


    }
}