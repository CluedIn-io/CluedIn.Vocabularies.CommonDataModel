using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFormFieldVocabulary : SimpleVocabulary
    {
        public MarketingFormFieldVocabulary()
        {
            VocabularyName = "Marketing Form Field";
            KeyPrefix = "commonDataModel.marketingformfield";
            KeySeparator = ".";
            Grouping = "/MarketingFormField";

            AddGroup("MarketingFormField Details", group =>
            {
                ContactMapping = group.Add(new VocabularyKey(nameof(ContactMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Defaultformlabel = group.Add(new VocabularyKey(nameof(Defaultformlabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Defaultformplaceholder = group.Add(new VocabularyKey(nameof(Defaultformplaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingFormFieldId = group.Add(new VocabularyKey(nameof(MarketingFormFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Marketingformfieldtype = group.Add(new VocabularyKey(nameof(Marketingformfieldtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Format = group.Add(new VocabularyKey(nameof(Format), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadMapping = group.Add(new VocabularyKey(nameof(LeadMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Renderas = group.Add(new VocabularyKey(nameof(Renderas), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingProvided = group.Add(new VocabularyKey(nameof(MarketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactmappingTarget = group.Add(new VocabularyKey(nameof(ContactmappingTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadmappingTarget = group.Add(new VocabularyKey(nameof(LeadmappingTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LookupTarget = group.Add(new VocabularyKey(nameof(LookupTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrototypeAttribute = group.Add(new VocabularyKey(nameof(PrototypeAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrototypeEntity = group.Add(new VocabularyKey(nameof(PrototypeEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrototypeTarget = group.Add(new VocabularyKey(nameof(PrototypeTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublicVisibility = group.Add(new VocabularyKey(nameof(PublicVisibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ContactMapping { get; private set; }
        public VocabularyKey Defaultformlabel { get; private set; }
        public VocabularyKey Defaultformplaceholder { get; private set; }
        public VocabularyKey MarketingFormFieldId { get; private set; }
        public VocabularyKey Marketingformfieldtype { get; private set; }
        public VocabularyKey Format { get; private set; }
        public VocabularyKey LeadMapping { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Renderas { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey MarketingProvided { get; private set; }
        public VocabularyKey ContactmappingTarget { get; private set; }
        public VocabularyKey LeadmappingTarget { get; private set; }
        public VocabularyKey LookupTarget { get; private set; }
        public VocabularyKey PrototypeAttribute { get; private set; }
        public VocabularyKey PrototypeEntity { get; private set; }
        public VocabularyKey PrototypeTarget { get; private set; }
        public VocabularyKey PublicVisibility { get; private set; }
    }
}