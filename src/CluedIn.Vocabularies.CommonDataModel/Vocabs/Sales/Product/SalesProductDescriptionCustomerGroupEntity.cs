using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesProductDescriptionCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public SalesProductDescriptionCustomerGroupEntityVocabulary()
        {
            VocabularyName = "SalesProductDescriptionCustomerGroupEntity";
            KeyPrefix = "commonDataModel.salesproductdescriptioncustomergroupentity";
            KeySeparator = ".";
            Grouping = "/SalesProductDescriptionCustomerGroupEntity";

            AddGroup("SalesProductDescriptionCustomerGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}