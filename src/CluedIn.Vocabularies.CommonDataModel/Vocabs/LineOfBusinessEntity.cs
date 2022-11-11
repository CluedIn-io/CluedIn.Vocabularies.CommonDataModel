using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LineOfBusinessEntityVocabulary : SimpleVocabulary
    {
        public LineOfBusinessEntityVocabulary()
        {
            VocabularyName = "Common Data Model LineOfBusinessEntity";
            KeyPrefix = "commonDataModel.lineofbusinessentity";
            KeySeparator = ".";
            Grouping = "/LineOfBusinessEntity";

            AddGroup("Common Data Model LineOfBusinessEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineOfBusiness = group.Add(new VocabularyKey(nameof(LineOfBusiness), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey LineOfBusiness { get; private set; }


    }
}