using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailPackageEntityVocabulary : SimpleVocabulary
    {
        public RetailPackageEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailPackageEntity";
            KeyPrefix = "commonDataModel.retailpackageentity";
            KeySeparator = ".";
            Grouping = "/RetailPackageEntity";

            AddGroup("Common Data Model RetailPackageEntity Details", group =>
            {
                PackageId = group.Add(new VocabularyKey(nameof(PackageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackageName = group.Add(new VocabularyKey(nameof(PackageName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PackageId { get; private set; }
        public VocabularyKey PackageName { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }


    }
}