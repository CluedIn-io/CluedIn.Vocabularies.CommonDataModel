using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetAcquisitionMethodEntityVocabulary : SimpleVocabulary
    {
        public AssetAcquisitionMethodEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetAcquisitionMethodEntity";
            KeyPrefix = "commonDataModel.assetacquisitionmethodentity";
            KeySeparator = ".";
            Grouping = "/AssetAcquisitionMethodEntity";

            AddGroup("Common Data Model AssetAcquisitionMethodEntity Details", group =>
            {
                AcquisitionMethod = group.Add(new VocabularyKey(nameof(AcquisitionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AcquisitionMethod { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}