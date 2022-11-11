using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailEcoResCategoryHierarchyEntityVocabulary : SimpleVocabulary
    {
        public RetailEcoResCategoryHierarchyEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailEcoResCategoryHierarchyEntity";
            KeyPrefix = "commonDataModel.retailecorescategoryhierarchyentity";
            KeySeparator = ".";
            Grouping = "/RetailEcoResCategoryHierarchyEntity";

            AddGroup("Common Data Model RetailEcoResCategoryHierarchyEntity Details", group =>
            {
                HierarchyModifier = group.Add(new VocabularyKey(nameof(HierarchyModifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AxRecId = group.Add(new VocabularyKey(nameof(AxRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey HierarchyModifier { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AxRecId { get; private set; }


    }
}