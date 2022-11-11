using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmSalesDistrictEntityVocabulary : SimpleVocabulary
    {
        public smmSalesDistrictEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmSalesDistrictEntity";
            KeyPrefix = "commonDataModel.smmsalesdistrictentity";
            KeySeparator = ".";
            Grouping = "/smmSalesDistrictEntity";

            AddGroup("Common Data Model smmSalesDistrictEntity Details", group =>
            {
                DistrictDescription = group.Add(new VocabularyKey(nameof(DistrictDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistrictId = group.Add(new VocabularyKey(nameof(DistrictId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DistrictDescription { get; private set; }
        public VocabularyKey DistrictId { get; private set; }


    }
}