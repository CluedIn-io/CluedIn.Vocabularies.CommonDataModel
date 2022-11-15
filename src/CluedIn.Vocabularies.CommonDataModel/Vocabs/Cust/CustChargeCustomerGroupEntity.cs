using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustChargeCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public CustChargeCustomerGroupEntityVocabulary()
        {
            VocabularyName = "Cust Charge Customer Group Entity";
            KeyPrefix = "commonDataModel.custchargecustomergroupentity";
            KeySeparator = ".";
            Grouping = "/CustChargeCustomerGroupEntity";

            AddGroup("CustChargeCustomerGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}