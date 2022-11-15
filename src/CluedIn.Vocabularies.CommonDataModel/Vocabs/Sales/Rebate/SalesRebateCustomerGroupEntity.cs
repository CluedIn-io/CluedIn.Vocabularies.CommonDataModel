using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesRebateCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public SalesRebateCustomerGroupEntityVocabulary()
        {
            VocabularyName = "Sales Rebate Customer Group Entity";
            KeyPrefix = "commonDataModel.salesrebatecustomergroupentity";
            KeySeparator = ".";
            Grouping = "/SalesRebateCustomerGroupEntity";

            AddGroup("SalesRebateCustomerGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupId { get; private set; }
    }
}