using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TNVEDCodesEntityVocabulary : SimpleVocabulary
    {
        public TNVEDCodesEntityVocabulary()
        {
            VocabularyName = "TNVEDCodesEntity";
            KeyPrefix = "commonDataModel.tnvedcodesentity";
            KeySeparator = ".";
            Grouping = "/TNVEDCodesEntity";

            AddGroup("TNVEDCodesEntity Details", group =>
            {
                Blocked = group.Add(new VocabularyKey(nameof(Blocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TnVedCode = group.Add(new VocabularyKey(nameof(TnVedCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Blocked { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TnVedCode { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}