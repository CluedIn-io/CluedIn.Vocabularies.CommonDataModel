using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectAllocationKeyDetailsEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectAllocationKeyDetailsEntityVocabulary()
        {
            VocabularyName = "ProjProjectAllocationKeyDetailsEntity";
            KeyPrefix = "commonDataModel.projprojectallocationkeydetailsentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectAllocationKeyDetailsEntity";

            AddGroup("ProjProjectAllocationKeyDetailsEntity Details", group =>
            {
                AllocationKey = group.Add(new VocabularyKey(nameof(AllocationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineProperty = group.Add(new VocabularyKey(nameof(LineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationPercentage = group.Add(new VocabularyKey(nameof(AllocationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourcePersonnelNumber = group.Add(new VocabularyKey(nameof(ResourcePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AllocationKey { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey LineProperty { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey AllocationPercentage { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey ResourcePersonnelNumber { get; private set; }


    }
}