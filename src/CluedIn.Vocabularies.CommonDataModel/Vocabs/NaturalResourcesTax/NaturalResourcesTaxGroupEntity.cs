using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class NaturalResourcesTaxGroupEntityVocabulary : SimpleVocabulary
    {
        public NaturalResourcesTaxGroupEntityVocabulary()
        {
            VocabularyName = "NaturalResourcesTaxGroupEntity";
            KeyPrefix = "commonDataModel.NaturalResourcesTaxGroupEntity";
            KeySeparator = ".";
            Grouping = "/NaturalResourcesTaxGroupEntity";

            AddGroup("NaturalResourcesTaxGroupEntity Details", group =>
            {
                TaxGroupOnNaturalResources = group.Add(new VocabularyKey(nameof(TaxGroupOnNaturalResources), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxGroupOnNaturalResources { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TaxCode { get; private set; }


    }
}