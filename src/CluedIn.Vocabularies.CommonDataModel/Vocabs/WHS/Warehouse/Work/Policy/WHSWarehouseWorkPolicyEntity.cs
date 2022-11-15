using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkPolicyEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkPolicyEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Work Policy Entity";
            KeyPrefix = "commonDataModel.whswarehouseworkpolicyentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkPolicyEntity";

            AddGroup("WHSWarehouseWorkPolicyEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
    }
}