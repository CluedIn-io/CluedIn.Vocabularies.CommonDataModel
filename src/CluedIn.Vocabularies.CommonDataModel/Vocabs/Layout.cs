using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LayoutVocabulary : SimpleVocabulary
    {
        public LayoutVocabulary()
        {
            VocabularyName = "Layout";
            KeyPrefix = "commonDataModel.layout";
            KeySeparator = ".";
            Grouping = "/Layout";

            AddGroup("Layout Details", group =>
            {
                Capacity = group.Add(new VocabularyKey(nameof(Capacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisabledAccess = group.Add(new VocabularyKey(nameof(DisabledAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisabledCapacity = group.Add(new VocabularyKey(nameof(DisabledCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FloorPlan = group.Add(new VocabularyKey(nameof(FloorPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutId = group.Add(new VocabularyKey(nameof(LayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Units = group.Add(new VocabularyKey(nameof(Units), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsableArea = group.Add(new VocabularyKey(nameof(UsableArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Capacity { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisabledAccess { get; private set; }
        public VocabularyKey DisabledCapacity { get; private set; }
        public VocabularyKey FloorPlan { get; private set; }
        public VocabularyKey LayoutId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Units { get; private set; }
        public VocabularyKey UsableArea { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}