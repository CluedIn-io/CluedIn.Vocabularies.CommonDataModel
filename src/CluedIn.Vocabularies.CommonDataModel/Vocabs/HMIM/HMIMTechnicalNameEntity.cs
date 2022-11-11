using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMTechnicalNameEntityVocabulary : SimpleVocabulary
    {
        public HMIMTechnicalNameEntityVocabulary()
        {
            VocabularyName = "Common Data Model HMIMTechnicalNameEntity";
            KeyPrefix = "commonDataModel.hmimtechnicalnameentity";
            KeySeparator = ".";
            Grouping = "/HMIMTechnicalNameEntity";

            AddGroup("Common Data Model HMIMTechnicalNameEntity Details", group =>
            {
                TechnicalNameCode = group.Add(new VocabularyKey(nameof(TechnicalNameCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TechnicalNameCode { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}