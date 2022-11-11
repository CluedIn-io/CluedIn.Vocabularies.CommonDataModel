using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerPriorityClassificationGroupEntityVocabulary : SimpleVocabulary
    {
        public CustomerPriorityClassificationGroupEntityVocabulary()
        {
            VocabularyName = "CustomerPriorityClassificationGroupEntity";
            KeyPrefix = "commonDataModel.customerpriorityclassificationgroupentity";
            KeySeparator = ".";
            Grouping = "/CustomerPriorityClassificationGroupEntity";

            AddGroup("CustomerPriorityClassificationGroupEntity Details", group =>
            {
                CustomerPriorityClassificationGroupCode = group.Add(new VocabularyKey(nameof(CustomerPriorityClassificationGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustomerPriorityClassificationGroupCode { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}