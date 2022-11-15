using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsCommodityCostBasisTypeEntityVocabulary : SimpleVocabulary
    {
        public PdsCommodityCostBasisTypeEntityVocabulary()
        {
            VocabularyName = "Pds Commodity Cost Basis Type Entity";
            KeyPrefix = "commonDataModel.pdscommoditycostbasistypeentity";
            KeySeparator = ".";
            Grouping = "/PdsCommodityCostBasisTypeEntity";

            AddGroup("PdsCommodityCostBasisTypeEntity Details", group =>
            {
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeId { get; private set; }
        public VocabularyKey TypeDescription { get; private set; }
    }
}