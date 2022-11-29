using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProductInsights
{
    public class AssetVocabulary : SimpleVocabulary
    {
        public AssetVocabulary()
        {
            VocabularyName = "Asset";
            KeyPrefix = "commonDataModel.asset.productinsights";
            KeySeparator = ".";
            Grouping = "/Asset";

            AddGroup("Asset Details for ProductInsights", group =>
            {
			    AssetId = group.Add(new VocabularyKey(nameof(AssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AssetId { get; private set; }
    }
}