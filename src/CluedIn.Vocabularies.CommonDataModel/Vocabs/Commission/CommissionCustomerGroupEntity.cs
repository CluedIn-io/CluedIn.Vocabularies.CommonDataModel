using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommissionCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public CommissionCustomerGroupEntityVocabulary()
        {
            VocabularyName = "Commission Customer Group Entity";
            KeyPrefix = "commonDataModel.commissioncustomergroupentity";
            KeySeparator = ".";
            Grouping = "/CommissionCustomerGroupEntity";

            AddGroup("CommissionCustomerGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }
    }
}