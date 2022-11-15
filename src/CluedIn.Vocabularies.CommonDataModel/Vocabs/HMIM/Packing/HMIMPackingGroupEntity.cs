using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMPackingGroupEntityVocabulary : SimpleVocabulary
    {
        public HMIMPackingGroupEntityVocabulary()
        {
            VocabularyName = "HMIM Packing Group Entity";
            KeyPrefix = "commonDataModel.hmimpackinggroupentity";
            KeySeparator = ".";
            Grouping = "/HMIMPackingGroupEntity";

            AddGroup("HMIMPackingGroupEntity Details", group =>
            {
                PackingGroupCode = group.Add(new VocabularyKey(nameof(PackingGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PackingGroupCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}