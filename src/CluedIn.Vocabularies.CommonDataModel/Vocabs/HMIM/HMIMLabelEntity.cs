using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMLabelEntityVocabulary : SimpleVocabulary
    {
        public HMIMLabelEntityVocabulary()
        {
            VocabularyName = "HMIM Label Entity";
            KeyPrefix = "commonDataModel.hmimlabelentity";
            KeySeparator = ".";
            Grouping = "/HMIMLabelEntity";

            AddGroup("HMIMLabelEntity Details", group =>
            {
                LabelCode = group.Add(new VocabularyKey(nameof(LabelCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LabelCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}