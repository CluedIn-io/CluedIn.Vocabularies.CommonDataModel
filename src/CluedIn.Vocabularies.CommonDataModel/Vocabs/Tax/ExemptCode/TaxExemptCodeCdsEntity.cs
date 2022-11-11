using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxExemptCodeCdsEntityVocabulary : SimpleVocabulary
    {
        public TaxExemptCodeCdsEntityVocabulary()
        {
            VocabularyName = "TaxExemptCodeCdsEntity";
            KeyPrefix = "commonDataModel.taxexemptcodecdsentity";
            KeySeparator = ".";
            Grouping = "/TaxExemptCodeCdsEntity";

            AddGroup("TaxExemptCodeCdsEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}