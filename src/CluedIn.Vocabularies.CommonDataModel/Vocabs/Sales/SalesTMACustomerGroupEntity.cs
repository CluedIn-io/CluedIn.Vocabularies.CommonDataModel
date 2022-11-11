using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesTMACustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public SalesTMACustomerGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesTMACustomerGroupEntity";
            KeyPrefix = "commonDataModel.salestmacustomergroupentity";
            KeySeparator = ".";
            Grouping = "/SalesTMACustomerGroupEntity";

            AddGroup("Common Data Model SalesTMACustomerGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }


    }
}