using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesRebateProductFreightGroupEntityVocabulary : SimpleVocabulary
    {
        public SalesRebateProductFreightGroupEntityVocabulary()
        {
            VocabularyName = "Sales Rebate Product Freight Group Entity";
            KeyPrefix = "commonDataModel.salesrebateproductfreightgroupentity";
            KeySeparator = ".";
            Grouping = "/SalesRebateProductFreightGroupEntity";

            AddGroup("SalesRebateProductFreightGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
    }
}