using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmSalesDistrictEntityVocabulary : SimpleVocabulary
    {
        public SmmSalesDistrictEntityVocabulary()
        {
            VocabularyName = "Smm Sales District Entity";
            KeyPrefix = "commonDataModel.smmsalesdistrictentity";
            KeySeparator = ".";
            Grouping = "/SmmSalesDistrictEntity";

            AddGroup("SmmSalesDistrictEntity Details", group =>
            {
                DistrictDescription = group.Add(new VocabularyKey(nameof(DistrictDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistrictId = group.Add(new VocabularyKey(nameof(DistrictId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DistrictDescription { get; private set; }
        public VocabularyKey DistrictId { get; private set; }
    }
}