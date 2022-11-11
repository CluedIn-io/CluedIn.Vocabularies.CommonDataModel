using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRPostageDiscountCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public MCRPostageDiscountCustomerGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRPostageDiscountCustomerGroupEntity";
            KeyPrefix = "commonDataModel.mcrpostagediscountcustomergroupentity";
            KeySeparator = ".";
            Grouping = "/MCRPostageDiscountCustomerGroupEntity";

            AddGroup("Common Data Model MCRPostageDiscountCustomerGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupCode { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}