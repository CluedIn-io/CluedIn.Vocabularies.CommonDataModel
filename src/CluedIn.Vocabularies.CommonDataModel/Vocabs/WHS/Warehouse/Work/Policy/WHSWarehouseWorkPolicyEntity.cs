using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkPolicyEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkPolicyEntity";
            KeyPrefix = "commonDataModel.whswarehouseworkpolicyentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkPolicyEntity";

            AddGroup("Common Data Model WHSWarehouseWorkPolicyEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }


    }
}