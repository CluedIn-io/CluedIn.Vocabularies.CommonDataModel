using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTmpCatalogMediaEntityVocabulary : SimpleVocabulary
    {
        public RetailTmpCatalogMediaEntityVocabulary()
        {
            VocabularyName = "RetailTmpCatalogMediaEntity";
            KeyPrefix = "commonDataModel.retailtmpcatalogmediaentity";
            KeySeparator = ".";
            Grouping = "/RetailTmpCatalogMediaEntity";

            AddGroup("RetailTmpCatalogMediaEntity Details", group =>
            {
                Catalog = group.Add(new VocabularyKey(nameof(Catalog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogName = group.Add(new VocabularyKey(nameof(CatalogName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Url = group.Add(new VocabularyKey(nameof(Url), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociationStatus = group.Add(new VocabularyKey(nameof(AssociationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Catalog { get; private set; }
        public VocabularyKey CatalogName { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey Url { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AssociationStatus { get; private set; }


    }
}