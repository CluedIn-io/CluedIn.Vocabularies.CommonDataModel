using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMStowageEntityVocabulary : SimpleVocabulary
    {
        public HMIMStowageEntityVocabulary()
        {
            VocabularyName = "HMIM Stowage Entity";
            KeyPrefix = "commonDataModel.hmimstowageentity";
            KeySeparator = ".";
            Grouping = "/HMIMStowageEntity";

            AddGroup("HMIMStowageEntity Details", group =>
            {
                StowageCode = group.Add(new VocabularyKey(nameof(StowageCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey StowageCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}