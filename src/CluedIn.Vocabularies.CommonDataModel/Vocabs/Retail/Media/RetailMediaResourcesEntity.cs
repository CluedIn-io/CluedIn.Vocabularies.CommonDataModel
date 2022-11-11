using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailMediaResourcesEntityVocabulary : SimpleVocabulary
    {
        public RetailMediaResourcesEntityVocabulary()
        {
            VocabularyName = "RetailMediaResourcesEntity";
            KeyPrefix = "commonDataModel.retailmediaresourcesentity";
            KeySeparator = ".";
            Grouping = "/RetailMediaResourcesEntity";

            AddGroup("RetailMediaResourcesEntity Details", group =>
            {
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceUrl = group.Add(new VocabularyKey(nameof(ResourceUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isPartialUrl = group.Add(new VocabularyKey(nameof(isPartialUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SizeInKilobytes = group.Add(new VocabularyKey(nameof(SizeInKilobytes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUse = group.Add(new VocabularyKey(nameof(InUse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSecuredResource = group.Add(new VocabularyKey(nameof(IsSecuredResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharedStorageId = group.Add(new VocabularyKey(nameof(SharedStorageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExternallyHosted = group.Add(new VocabularyKey(nameof(IsExternallyHosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThumbnailUrl = group.Add(new VocabularyKey(nameof(ThumbnailUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThumbnailSharedStorageId = group.Add(new VocabularyKey(nameof(ThumbnailSharedStorageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SmallImageUrl = group.Add(new VocabularyKey(nameof(SmallImageUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SmallImageSharedStorageId = group.Add(new VocabularyKey(nameof(SmallImageSharedStorageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Width = group.Add(new VocabularyKey(nameof(Width), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Height = group.Add(new VocabularyKey(nameof(Height), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCatalog = group.Add(new VocabularyKey(nameof(IsCatalog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCategory = group.Add(new VocabularyKey(nameof(IsCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCustomer = group.Add(new VocabularyKey(nameof(IsCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPos = group.Add(new VocabularyKey(nameof(IsPos), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProduct = group.Add(new VocabularyKey(nameof(IsProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorker = group.Add(new VocabularyKey(nameof(IsWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstanceRelationType = group.Add(new VocabularyKey(nameof(InstanceRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ResourceUrl { get; private set; }
        public VocabularyKey isPartialUrl { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey SizeInKilobytes { get; private set; }
        public VocabularyKey InUse { get; private set; }
        public VocabularyKey IsSecuredResource { get; private set; }
        public VocabularyKey SharedStorageId { get; private set; }
        public VocabularyKey IsExternallyHosted { get; private set; }
        public VocabularyKey ThumbnailUrl { get; private set; }
        public VocabularyKey ThumbnailSharedStorageId { get; private set; }
        public VocabularyKey SmallImageUrl { get; private set; }
        public VocabularyKey SmallImageSharedStorageId { get; private set; }
        public VocabularyKey Width { get; private set; }
        public VocabularyKey Height { get; private set; }
        public VocabularyKey IsCatalog { get; private set; }
        public VocabularyKey IsCategory { get; private set; }
        public VocabularyKey IsCustomer { get; private set; }
        public VocabularyKey IsPos { get; private set; }
        public VocabularyKey IsProduct { get; private set; }
        public VocabularyKey IsWorker { get; private set; }
        public VocabularyKey InstanceRelationType { get; private set; }


    }
}