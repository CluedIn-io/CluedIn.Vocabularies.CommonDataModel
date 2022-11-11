using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMDivisionEntityVocabulary : SimpleVocabulary
    {
        public HMIMDivisionEntityVocabulary()
        {
            VocabularyName = "HMIMDivisionEntity";
            KeyPrefix = "commonDataModel.hmimdivisionentity";
            KeySeparator = ".";
            Grouping = "/HMIMDivisionEntity";

            AddGroup("HMIMDivisionEntity Details", group =>
            {
                DivisionCode = group.Add(new VocabularyKey(nameof(DivisionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassCode = group.Add(new VocabularyKey(nameof(ClassCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DivisionCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ClassCode { get; private set; }


    }
}