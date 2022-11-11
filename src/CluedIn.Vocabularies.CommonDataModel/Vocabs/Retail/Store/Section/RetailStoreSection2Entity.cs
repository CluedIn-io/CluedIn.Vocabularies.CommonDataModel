using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailStoreSection2EntityVocabulary : SimpleVocabulary
    {
        public RetailStoreSection2EntityVocabulary()
        {
            VocabularyName = "RetailStoreSection2Entity";
            KeyPrefix = "commonDataModel.retailstoresection2entity";
            KeySeparator = ".";
            Grouping = "/RetailStoreSection2Entity";

            AddGroup("RetailStoreSection2Entity Details", group =>
            {
                LastCheckedStock = group.Add(new VocabularyKey(nameof(LastCheckedStock), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SectionId = group.Add(new VocabularyKey(nameof(SectionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Size = group.Add(new VocabularyKey(nameof(Size), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SizeUnit = group.Add(new VocabularyKey(nameof(SizeUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LastCheckedStock { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SectionId { get; private set; }
        public VocabularyKey Size { get; private set; }
        public VocabularyKey SizeUnit { get; private set; }
        public VocabularyKey StoreNumber { get; private set; }


    }
}