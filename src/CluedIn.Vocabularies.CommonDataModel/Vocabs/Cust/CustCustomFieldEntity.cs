using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCustomFieldEntityVocabulary : SimpleVocabulary
    {
        public CustCustomFieldEntityVocabulary()
        {
            VocabularyName = "Cust Custom Field Entity";
            KeyPrefix = "commonDataModel.custcustomfieldentity";
            KeySeparator = ".";
            Grouping = "/CustCustomFieldEntity";

            AddGroup("CustCustomFieldEntity Details", group =>
            {
                CustomField = group.Add(new VocabularyKey(nameof(CustomField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataType = group.Add(new VocabularyKey(nameof(DataType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBoolean = group.Add(new VocabularyKey(nameof(DefaultBoolean), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDate = group.Add(new VocabularyKey(nameof(DefaultDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInt = group.Add(new VocabularyKey(nameof(DefaultInt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReal = group.Add(new VocabularyKey(nameof(DefaultReal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultText = group.Add(new VocabularyKey(nameof(DefaultText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxLength = group.Add(new VocabularyKey(nameof(MaxLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxValue = group.Add(new VocabularyKey(nameof(MaxValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinValue = group.Add(new VocabularyKey(nameof(MinValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateMaximum = group.Add(new VocabularyKey(nameof(ValidateMaximum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateMinimum = group.Add(new VocabularyKey(nameof(ValidateMinimum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomField { get; private set; }
        public VocabularyKey DataType { get; private set; }
        public VocabularyKey DefaultBoolean { get; private set; }
        public VocabularyKey DefaultDate { get; private set; }
        public VocabularyKey DefaultInt { get; private set; }
        public VocabularyKey DefaultReal { get; private set; }
        public VocabularyKey DefaultText { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey MaxLength { get; private set; }
        public VocabularyKey MaxValue { get; private set; }
        public VocabularyKey MinValue { get; private set; }
        public VocabularyKey ValidateMaximum { get; private set; }
        public VocabularyKey ValidateMinimum { get; private set; }
    }
}