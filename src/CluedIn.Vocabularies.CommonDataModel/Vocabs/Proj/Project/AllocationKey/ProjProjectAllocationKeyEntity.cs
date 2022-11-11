using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectAllocationKeyEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectAllocationKeyEntityVocabulary()
        {
            VocabularyName = "ProjProjectAllocationKeyEntity";
            KeyPrefix = "commonDataModel.projprojectallocationkeyentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectAllocationKeyEntity";

            AddGroup("ProjProjectAllocationKeyEntity Details", group =>
            {
                AllocationKey = group.Add(new VocabularyKey(nameof(AllocationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AllocationKey { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}