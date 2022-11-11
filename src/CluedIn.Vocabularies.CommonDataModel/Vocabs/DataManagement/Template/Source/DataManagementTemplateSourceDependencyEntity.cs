using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataManagementTemplateSourceDependencyEntityVocabulary : SimpleVocabulary
    {
        public DataManagementTemplateSourceDependencyEntityVocabulary()
        {
            VocabularyName = "Common Data Model DataManagementTemplateSourceDependencyEntity";
            KeyPrefix = "commonDataModel.datamanagementtemplatesourcedependencyentity";
            KeySeparator = ".";
            Grouping = "/DataManagementTemplateSourceDependencyEntity";

            AddGroup("Common Data Model DataManagementTemplateSourceDependencyEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceEntity = group.Add(new VocabularyKey(nameof(SourceEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DependentOnEntity = group.Add(new VocabularyKey(nameof(DependentOnEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelationName = group.Add(new VocabularyKey(nameof(RelationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FriendlyName = group.Add(new VocabularyKey(nameof(FriendlyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidationRequired = group.Add(new VocabularyKey(nameof(ValidationRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey SourceEntity { get; private set; }
        public VocabularyKey DependentOnEntity { get; private set; }
        public VocabularyKey RelationName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FriendlyName { get; private set; }
        public VocabularyKey ValidationRequired { get; private set; }


    }
}