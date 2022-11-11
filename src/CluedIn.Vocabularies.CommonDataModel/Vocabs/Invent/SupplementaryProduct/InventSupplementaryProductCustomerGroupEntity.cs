using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventSupplementaryProductCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public InventSupplementaryProductCustomerGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventSupplementaryProductCustomerGroupEntity";
            KeyPrefix = "commonDataModel.inventsupplementaryproductcustomergroupentity";
            KeySeparator = ".";
            Grouping = "/InventSupplementaryProductCustomerGroupEntity";

            AddGroup("Common Data Model InventSupplementaryProductCustomerGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}