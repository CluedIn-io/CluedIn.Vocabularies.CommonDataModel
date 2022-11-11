using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmTitleEntityVocabulary : SimpleVocabulary
    {
        public HcmTitleEntityVocabulary()
        {
            VocabularyName = "HcmTitleEntity";
            KeyPrefix = "commonDataModel.hcmtitleentity";
            KeySeparator = ".";
            Grouping = "/HcmTitleEntity";

            AddGroup("HcmTitleEntity Details", group =>
            {
                TitleId = group.Add(new VocabularyKey(nameof(TitleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TitleId { get; private set; }


    }
}