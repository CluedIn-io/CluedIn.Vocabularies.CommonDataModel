using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfiguratorLayoutGroupEntityVocabulary : SimpleVocabulary
    {
        public ConfiguratorLayoutGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model ConfiguratorLayoutGroupEntity";
            KeyPrefix = "commonDataModel.configuratorlayoutgroupentity";
            KeySeparator = ".";
            Grouping = "/ConfiguratorLayoutGroupEntity";

            AddGroup("Common Data Model ConfiguratorLayoutGroupEntity Details", group =>
            {
                LayoutGroupId = group.Add(new VocabularyKey(nameof(LayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutType = group.Add(new VocabularyKey(nameof(LayoutType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefinitionGroupId = group.Add(new VocabularyKey(nameof(DefinitionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileStructure = group.Add(new VocabularyKey(nameof(FileStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelimitedBy = group.Add(new VocabularyKey(nameof(DelimitedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelimiterCharacter = group.Add(new VocabularyKey(nameof(DelimiterCharacter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TextQualifier = group.Add(new VocabularyKey(nameof(TextQualifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Export = group.Add(new VocabularyKey(nameof(Export), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Import = group.Add(new VocabularyKey(nameof(Import), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterType = group.Add(new VocabularyKey(nameof(RegisterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LayoutGroupId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey LayoutType { get; private set; }
        public VocabularyKey DefinitionGroupId { get; private set; }
        public VocabularyKey FileStructure { get; private set; }
        public VocabularyKey DelimitedBy { get; private set; }
        public VocabularyKey DelimiterCharacter { get; private set; }
        public VocabularyKey TextQualifier { get; private set; }
        public VocabularyKey Export { get; private set; }
        public VocabularyKey Import { get; private set; }
        public VocabularyKey RegisterType { get; private set; }


    }
}