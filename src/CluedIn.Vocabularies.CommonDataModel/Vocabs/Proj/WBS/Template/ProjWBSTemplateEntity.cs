using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjWBSTemplateEntityVocabulary : SimpleVocabulary
    {
        public ProjWBSTemplateEntityVocabulary()
        {
            VocabularyName = "ProjWBSTemplateEntity";
            KeyPrefix = "commonDataModel.projwbstemplateentity";
            KeySeparator = ".";
            Grouping = "/ProjWBSTemplateEntity";

            AddGroup("ProjWBSTemplateEntity Details", group =>
            {
                HierarchyId = group.Add(new VocabularyKey(nameof(HierarchyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTemplate = group.Add(new VocabularyKey(nameof(IsTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey HierarchyId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey HierarchyType { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey IsTemplate { get; private set; }


    }
}