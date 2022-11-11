using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesRebateProductGroupEntityVocabulary : SimpleVocabulary
    {
        public SalesRebateProductGroupEntityVocabulary()
        {
            VocabularyName = "SalesRebateProductGroupEntity";
            KeyPrefix = "commonDataModel.salesrebateproductgroupentity";
            KeySeparator = ".";
            Grouping = "/SalesRebateProductGroupEntity";

            AddGroup("SalesRebateProductGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupId { get; private set; }


    }
}