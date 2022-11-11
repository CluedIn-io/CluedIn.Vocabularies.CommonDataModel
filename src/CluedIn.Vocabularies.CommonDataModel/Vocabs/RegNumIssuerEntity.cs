using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RegNumIssuerEntityVocabulary : SimpleVocabulary
    {
        public RegNumIssuerEntityVocabulary()
        {
            VocabularyName = "RegNumIssuerEntity";
            KeyPrefix = "commonDataModel.regnumissuerentity";
            KeySeparator = ".";
            Grouping = "/RegNumIssuerEntity";

            AddGroup("RegNumIssuerEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}