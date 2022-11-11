using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSAIndirectComponentGroupEntityVocabulary : SimpleVocabulary
    {
        public PSAIndirectComponentGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PSAIndirectComponentGroupEntity";
            KeyPrefix = "commonDataModel.psaindirectcomponentgroupentity";
            KeySeparator = ".";
            Grouping = "/PSAIndirectComponentGroupEntity";

            AddGroup("Common Data Model PSAIndirectComponentGroupEntity Details", group =>
            {
                IndirectCostComponentGroup = group.Add(new VocabularyKey(nameof(IndirectCostComponentGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectComponentGroupName = group.Add(new VocabularyKey(nameof(IndirectComponentGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IndirectCostComponentGroup { get; private set; }
        public VocabularyKey IndirectComponentGroupName { get; private set; }


    }
}