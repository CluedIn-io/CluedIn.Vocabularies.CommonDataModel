using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTmpCategoryMediaEntityVocabulary : SimpleVocabulary
    {
        public RetailTmpCategoryMediaEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTmpCategoryMediaEntity";
            KeyPrefix = "commonDataModel.retailtmpcategorymediaentity";
            KeySeparator = ".";
            Grouping = "/RetailTmpCategoryMediaEntity";

            AddGroup("Common Data Model RetailTmpCategoryMediaEntity Details", group =>
            {
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Url = group.Add(new VocabularyKey(nameof(Url), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociationStatus = group.Add(new VocabularyKey(nameof(AssociationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryHierarchy { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey Url { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey AssociationStatus { get; private set; }


    }
}