using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvProjectExpensePolicyGroupEntityVocabulary : SimpleVocabulary
    {
        public TrvProjectExpensePolicyGroupEntityVocabulary()
        {
            VocabularyName = "Trv Project Expense Policy Group Entity";
            KeyPrefix = "commonDataModel.trvprojectexpensepolicygroupentity";
            KeySeparator = ".";
            Grouping = "/TrvProjectExpensePolicyGroupEntity";

            AddGroup("TrvProjectExpensePolicyGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}