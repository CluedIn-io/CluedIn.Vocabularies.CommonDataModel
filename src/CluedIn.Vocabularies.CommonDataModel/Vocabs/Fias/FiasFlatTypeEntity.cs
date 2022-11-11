using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiasFlatTypeEntityVocabulary : SimpleVocabulary
    {
        public FiasFlatTypeEntityVocabulary()
        {
            VocabularyName = "FiasFlatTypeEntity";
            KeyPrefix = "commonDataModel.fiasflattypeentity";
            KeySeparator = ".";
            Grouping = "/FiasFlatTypeEntity";

            AddGroup("FiasFlatTypeEntity Details", group =>
            {
                FlTypeId = group.Add(new VocabularyKey(nameof(FlTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShortName = group.Add(new VocabularyKey(nameof(ShortName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FlTypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ShortName { get; private set; }


    }
}