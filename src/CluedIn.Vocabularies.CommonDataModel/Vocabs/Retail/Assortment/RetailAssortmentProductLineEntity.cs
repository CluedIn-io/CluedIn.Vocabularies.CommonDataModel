using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAssortmentProductLineEntityVocabulary : SimpleVocabulary
    {
        public RetailAssortmentProductLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailAssortmentProductLineEntity";
            KeyPrefix = "commonDataModel.retailassortmentproductlineentity";
            KeySeparator = ".";
            Grouping = "/RetailAssortmentProductLineEntity";

            AddGroup("Common Data Model RetailAssortmentProductLineEntity Details", group =>
            {
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailGroupMemberLineId = group.Add(new VocabularyKey(nameof(RetailGroupMemberLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssortmentId = group.Add(new VocabularyKey(nameof(AssortmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Color = group.Add(new VocabularyKey(nameof(Color), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Size = group.Add(new VocabularyKey(nameof(Size), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Style = group.Add(new VocabularyKey(nameof(Style), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigurationId = group.Add(new VocabularyKey(nameof(ConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDataAreaId = group.Add(new VocabularyKey(nameof(SourceDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LineType { get; private set; }
        public VocabularyKey RetailGroupMemberLineId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey AssortmentId { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey Color { get; private set; }
        public VocabularyKey Size { get; private set; }
        public VocabularyKey Style { get; private set; }
        public VocabularyKey ConfigurationId { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey SourceDataAreaId { get; private set; }


    }
}