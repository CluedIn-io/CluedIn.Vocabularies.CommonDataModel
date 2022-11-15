using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesTMACustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public SalesTMACustomerGroupEntityVocabulary()
        {
            VocabularyName = "Sales TMA Customer Group Entity";
            KeyPrefix = "commonDataModel.salestmacustomergroupentity";
            KeySeparator = ".";
            Grouping = "/SalesTMACustomerGroupEntity";

            AddGroup("SalesTMACustomerGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
    }
}