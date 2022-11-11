using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSAIndirectCostComponentEntityVocabulary : SimpleVocabulary
    {
        public PSAIndirectCostComponentEntityVocabulary()
        {
            VocabularyName = "Common Data Model PSAIndirectCostComponentEntity";
            KeyPrefix = "commonDataModel.psaindirectcostcomponententity";
            KeySeparator = ".";
            Grouping = "/PSAIndirectCostComponentEntity";

            AddGroup("Common Data Model PSAIndirectCostComponentEntity Details", group =>
            {
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComponentId = group.Add(new VocabularyKey(nameof(ComponentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Category { get; private set; }
        public VocabularyKey ComponentId { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}