using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMPackDescriptionEntityVocabulary : SimpleVocabulary
    {
        public HMIMPackDescriptionEntityVocabulary()
        {
            VocabularyName = "HMIM Pack Description Entity";
            KeyPrefix = "commonDataModel.hmimpackdescriptionentity";
            KeySeparator = ".";
            Grouping = "/HMIMPackDescriptionEntity";

            AddGroup("HMIMPackDescriptionEntity Details", group =>
            {
                PackCode = group.Add(new VocabularyKey(nameof(PackCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PackCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}