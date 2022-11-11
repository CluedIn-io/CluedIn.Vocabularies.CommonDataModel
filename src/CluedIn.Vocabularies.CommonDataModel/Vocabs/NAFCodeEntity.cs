using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class NAFCodeEntityVocabulary : SimpleVocabulary
    {
        public NAFCodeEntityVocabulary()
        {
            VocabularyName = "NAFCodeEntity";
            KeyPrefix = "commonDataModel.nafcodeentity";
            KeySeparator = ".";
            Grouping = "/NAFCodeEntity";

            AddGroup("NAFCodeEntity Details", group =>
            {
                NAFCode = group.Add(new VocabularyKey(nameof(NAFCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey NAFCode { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}