using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehousePackageClassEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehousePackageClassEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehousePackageClassEntity";
            KeyPrefix = "commonDataModel.whswarehousepackageclassentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehousePackageClassEntity";

            AddGroup("Common Data Model WHSWarehousePackageClassEntity Details", group =>
            {
                PackageClassDescription = group.Add(new VocabularyKey(nameof(PackageClassDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackageClassId = group.Add(new VocabularyKey(nameof(PackageClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PackageClassDescription { get; private set; }
        public VocabularyKey PackageClassId { get; private set; }


    }
}