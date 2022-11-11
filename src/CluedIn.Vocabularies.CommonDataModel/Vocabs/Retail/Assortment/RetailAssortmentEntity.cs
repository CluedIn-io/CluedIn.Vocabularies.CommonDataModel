using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAssortmentEntityVocabulary : SimpleVocabulary
    {
        public RetailAssortmentEntityVocabulary()
        {
            VocabularyName = "RetailAssortmentEntity";
            KeyPrefix = "commonDataModel.retailassortmententity";
            KeySeparator = ".";
            Grouping = "/RetailAssortmentEntity";

            AddGroup("RetailAssortmentEntity Details", group =>
            {
                AssortmentID = group.Add(new VocabularyKey(nameof(AssortmentID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublishedDateTime = group.Add(new VocabularyKey(nameof(PublishedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssortmentID { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PublishedDateTime { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }


    }
}