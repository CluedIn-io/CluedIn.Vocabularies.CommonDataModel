using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatPortEntityVocabulary : SimpleVocabulary
    {
        public IntrastatPortEntityVocabulary()
        {
            VocabularyName = "Common Data Model IntrastatPortEntity";
            KeyPrefix = "commonDataModel.intrastatportentity";
            KeySeparator = ".";
            Grouping = "/IntrastatPortEntity";

            AddGroup("Common Data Model IntrastatPortEntity Details", group =>
            {
                PortId = group.Add(new VocabularyKey(nameof(PortId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescribePort = group.Add(new VocabularyKey(nameof(DescribePort), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PortState = group.Add(new VocabularyKey(nameof(PortState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PortId { get; private set; }
        public VocabularyKey DescribePort { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey PortState { get; private set; }


    }
}