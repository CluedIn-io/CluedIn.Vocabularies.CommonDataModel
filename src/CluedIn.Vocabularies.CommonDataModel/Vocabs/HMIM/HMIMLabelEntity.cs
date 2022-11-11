using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMLabelEntityVocabulary : SimpleVocabulary
    {
        public HMIMLabelEntityVocabulary()
        {
            VocabularyName = "Common Data Model HMIMLabelEntity";
            KeyPrefix = "commonDataModel.hmimlabelentity";
            KeySeparator = ".";
            Grouping = "/HMIMLabelEntity";

            AddGroup("Common Data Model HMIMLabelEntity Details", group =>
            {
                LabelCode = group.Add(new VocabularyKey(nameof(LabelCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LabelCode { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}