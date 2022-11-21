using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BLWICountryRegionGroupEntityVocabulary : SimpleVocabulary
    {
        public BLWICountryRegionGroupEntityVocabulary()
        {
            VocabularyName = "BLWI Country Region Group Entity";
            KeyPrefix = "commonDataModel.blwicountryregiongroupentity";
            KeySeparator = ".";
            Grouping = "/BLWICountryRegionGroupEntity";

            AddGroup("BLWICountryRegionGroupEntity Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupID = group.Add(new VocabularyKey(nameof(GroupID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BLWIReporting = group.Add(new VocabularyKey(nameof(BLWIReporting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowNum = group.Add(new VocabularyKey(nameof(RowNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionName = group.Add(new VocabularyKey(nameof(CountryRegionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey GroupID { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BLWIReporting { get; private set; }
        public VocabularyKey RowNum { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey CountryRegionName { get; private set; }
    }
}