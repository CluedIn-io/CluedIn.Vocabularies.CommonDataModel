using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMClassGroupEntityVocabulary : SimpleVocabulary
    {
        public HMIMClassGroupEntityVocabulary()
        {
            VocabularyName = "HMIM Class Group Entity";
            KeyPrefix = "commonDataModel.hmimclassgroupentity";
            KeySeparator = ".";
            Grouping = "/HMIMClassGroupEntity";

            AddGroup("HMIMClassGroupEntity Details", group =>
            {
                ClassGroupCode = group.Add(new VocabularyKey(nameof(ClassGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassCode = group.Add(new VocabularyKey(nameof(ClassCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DivisionCode = group.Add(new VocabularyKey(nameof(DivisionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingGroupCode = group.Add(new VocabularyKey(nameof(PackingGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportCategoryCode = group.Add(new VocabularyKey(nameof(TransportCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Multiplier = group.Add(new VocabularyKey(nameof(Multiplier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ClassGroupCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ClassCode { get; private set; }
        public VocabularyKey DivisionCode { get; private set; }
        public VocabularyKey PackingGroupCode { get; private set; }
        public VocabularyKey TransportCategoryCode { get; private set; }
        public VocabularyKey Multiplier { get; private set; }
    }
}